using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LearningLanguages.Models;
using DAL.Repositories;
using DAL;
using DAL.Models;
using SmartBreadcrumbs.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace LearningLanguages.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Categories> categories = new CategoriesRepository();
        IRepository<CategoriesTranslations> categoriesTranslations = new CategoriesTranslationsRepository();
        IRepository<Languages> languages = new LanguagesRepository();

        [HttpGet]
        [DefaultBreadcrumb("Select languages")]
        public IActionResult Index()
        {
            SelectList languagesList = new SelectList(languages.GetList(), "Id", "Name");
            ViewBag.languagesList = languagesList;
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            return RedirectToAction("Categories", new
            {
                idLangNative = Convert.ToInt32(form["idLangNative"]),
                idLangLearn = Convert.ToInt32(form["idLangLearn"])
            });
        }

        [Breadcrumb("Categories")]
        public IActionResult Categories(int idLangNative, int idLangLearn)
        {
            var LearnLang = categories.GetList().Where(s => s.ParentId == null)
                .Join(
                    categoriesTranslations.GetList().Where(s => s.LangId == idLangLearn),
                    category => category.Id,
                    categoryTrans => categoryTrans.CategoryId,
                    (category, categoryTrans) => new
                    {
                        Id = category.Id,
                        Name = categoryTrans.Translation
                    }
            ).ToList();

            dynamic NativeLang = categories.GetList().Where(s => s.ParentId == null)
                .Join(
                    categoriesTranslations.GetList().Where(s => s.LangId == idLangNative),
                    category => category.Id,
                    categoryTrans => categoryTrans.CategoryId,
                    (category, categoryTrans) => new
                    {
                        Id = category.Id,
                        Name = categoryTrans.Translation,
                        Picture = category.Picture,
                        Learn = LearnLang.Find(x => x.Id == category.Id).Name,
                        idLangLearn,
                        idLangNative
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            return View(NativeLang);
        }

        [HttpGet]
        [Breadcrumb("SubCategories")]
        public IActionResult SubCategories(int id)
        {
            return View(categories.GetList().Where(s => s.ParentId == id));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
