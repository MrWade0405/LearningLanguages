using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using LearningLanguages.Models;
using DAL.Repositories;
using DAL;
using DAL.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace LearningLanguages.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Categories> categories = new CategoriesRepository();
        IRepository<CategoriesTranslations> categoriesTranslations = new CategoriesTranslationsRepository();
        IRepository<Languages> languages = new LanguagesRepository();

        IRepository<Words> words = new WordsRepository();
        IRepository<WordTranslations> wordTranslations = new WordTranslationsRepository();

        IRepository<Tests> tests = new TestsRepository();
        IRepository<TestTranslations> testTranslations = new TestTranslationsRepository();

        [HttpGet]
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

        public IActionResult Categories(int idLangNative, int idLangLearn)
        {
            var LearnLangCat = categories.GetList().Where(s => s.ParentId == null)
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

            dynamic NativeLearnLangCat = categories.GetList().Where(s => s.ParentId == null)
                .Join(
                    categoriesTranslations.GetList().Where(s => s.LangId == idLangNative),
                    category => category.Id,
                    categoryTrans => categoryTrans.CategoryId,
                    (category, categoryTrans) => new
                    {
                        Id = category.Id,
                        Name = categoryTrans.Translation,
                        Picture = category.Picture,
                        Learn = LearnLangCat.Find(x => x.Id == category.Id).Name,
                        idLangLearn,
                        idLangNative
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            return View(NativeLearnLangCat);
        }

        [HttpGet]
        public IActionResult SubCategories(int id, int idLangLearn, int idLangNative)
        {
            var LearnLangSubCat = categories.GetList().Where(s => s.ParentId == id)
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

            dynamic NativeLearnLangSubCat = categories.GetList().Where(s => s.ParentId == id)
                .Join(
                    categoriesTranslations.GetList().Where(s => s.LangId == idLangNative),
                    category => category.Id,
                    categoryTrans => categoryTrans.CategoryId,
                    (category, categoryTrans) => new
                    {
                        Id = category.Id,
                        Name = categoryTrans.Translation,
                        Picture = category.Picture,
                        Learn = LearnLangSubCat.Find(x => x.Id == category.Id).Name,
                        idLangLearn,
                        idLangNative
                    }
            ).AsEnumerable().Select(c => c.ToExpando());


            return View(NativeLearnLangSubCat);
        }

        public IActionResult Tests(int id, int idLangLearn, int idLangNative)
        {
            //var LearnLangWords = words.GetList().Where(s => s.CategoryId == id)
            //    .Join(
            //        wordTranslations.GetList().Where(s => s.LangId == idLangLearn),
            //        word => word.Id,
            //        wordTrans => wordTrans.WordId,
            //        (word, wordTrans) => new
            //        {
            //            Id = word.Id,
            //            Name = wordTrans.Translation
            //        }
            //).ToList();

            //dynamic NativeLearnLangWords = words.GetList().Where(s => s.CategoryId == id)
            //    .Join(
            //        wordTranslations.GetList().Where(s => s.LangId == idLangNative),
            //        word => word.Id,
            //        wordTrans => wordTrans.WordId,
            //        (word, wordTrans) => new
            //        {
            //            Id = word.Id,
            //            Name = wordTrans.Translation,
            //            Picture = word.Picture,
            //            Learn = LearnLangWords.Find(x => x.Id == word.Id).Name,
            //            idLangLearn,
            //            idLangNative
            //        }
            //).AsEnumerable().Select(c => c.ToExpando());

            var LearnLangTests = tests.GetList()
                .Join(
                    testTranslations.GetList().Where(s => s.LangId == idLangLearn),
                    test => test.Id,
                    testTrans => testTrans.TestId,
                    (test, testTrans) => new
                    {
                        Id = test.Id,
                        Name = testTrans.Translation
                    }
            ).ToList();

            dynamic NativeLearnLangTests = tests.GetList()
                .Join(
                    testTranslations.GetList().Where(s => s.LangId == idLangNative),
                    test => test.Id,
                    testTrans => testTrans.TestId,
                    (test, testTrans) => new
                    {
                        Id = test.Id,
                        Name = testTrans.Translation,
                        Icon = test.Icon,
                        Learn = LearnLangTests.Find(x => x.Id == test.Id).Name,
                        idLangLearn,
                        idLangNative
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            //ViewBag.NativeLearnLangTests = NativeLearnLangTests;
            ViewBag.CategoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative
                ;
            return View(NativeLearnLangTests);
        }

        public IActionResult Manual(int id, int idLangLearn, int idLangNative,int page=1)
        {
            var LearnLangWords = words.GetList().Where(s => s.CategoryId == id)
                .Join(
                    wordTranslations.GetList().Where(s => s.LangId == idLangLearn),
                    word => word.Id,
                    wordTrans => wordTrans.WordId,
                    (word, wordTrans) => new
                    {
                        Id = word.Id,
                        Name = wordTrans.Translation
                    }
            ).ToList();

            var NativeLearnLangWords = words.GetList().Where(s => s.CategoryId == id)
                .Join(
                    wordTranslations.GetList().Where(s => s.LangId == idLangNative),
                    word => word.Id,
                    wordTrans => wordTrans.WordId,
                    (word, wordTrans) => new
                    {
                        Id = word.Id,
                        Name = wordTrans.Translation,
                        Picture = word.Picture,
                        Learn = LearnLangWords.Find(x => x.Id == word.Id).Name,
                        idLangLearn,
                        idLangNative
                    }
            ).ToList();

            int countWords = NativeLearnLangWords.Count;

            dynamic wordsItem = NativeLearnLangWords.Skip(page - 1).Take(1).AsEnumerable()
                                                    .Select(c => c.ToExpando()); ;

            PageViewModel pageViewModel = new PageViewModel(countWords, page, 1);
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Words = wordsItem
            };

            ViewBag.CategoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;


            return View(viewModel);
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
