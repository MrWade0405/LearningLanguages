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
using Hanssens.Net;

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

            return View(languagesList);
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            int idLangNative, idLangLearn;
            var storage = new LocalStorage();

            storage.Store("idLangNative", Convert.ToInt32(form["idLangNative"]));
            storage.Store("idLangLearn", Convert.ToInt32(form["idLangLearn"]));
            idLangLearn = Convert.ToInt32(storage.Get("idLangLearn"));
            idLangNative = Convert.ToInt32(storage.Get("idLangNative"));

            return RedirectToAction("Categories", new
            {
                idLangNative,
                idLangLearn
            });
        }
        [Route("Home/Categories")]
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
                        Learn = LearnLangCat.Find(x => x.Id == category.Id).Name
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;

            return View(NativeLearnLangCat);
        }

        [Route("Home/Categories/SubCategories")]
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
                        Learn = LearnLangSubCat.Find(x => x.Id == category.Id).Name
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            ViewBag.categoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;

            return View(NativeLearnLangSubCat);
        }

        [Route("Home/Categories/SubCategories/Tests")]
        public IActionResult Tests(int id, int idLangLearn, int idLangNative)
        {
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
                        Learn = LearnLangTests.Find(x => x.Id == test.Id).Name
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            ViewBag.categoryId = categories.GetItem(id).ParentId;
            ViewBag.subCategoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;
            return View(NativeLearnLangTests);
        }

        [Route("Home/Categories/SubCategories/Tests/Manual")]
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

            dynamic NativeLearnLangWords = words.GetList().Where(s => s.CategoryId == id)
                .Join(
                    wordTranslations.GetList().Where(s => s.LangId == idLangNative),
                    word => word.Id,
                    wordTrans => wordTrans.WordId,
                    (word, wordTrans) => new
                    {
                        Id = word.Id,
                        Name = wordTrans.Translation,
                        Picture = word.Picture,
                        Learn = LearnLangWords.Find(x => x.Id == word.Id).Name
                    }
            ).AsEnumerable().Select(c => c.ToExpando());

            //int countWords = NativeLearnLangWords.Count;

            //dynamic wordsItem = NativeLearnLangWords.Skip(page - 1).Take(1).AsEnumerable()
            //                                        .Select(c => c.ToExpando()); ;

            //PageViewModel pageViewModel = new PageViewModel(countWords, page, 1);
            //IndexViewModel viewModel = new IndexViewModel
            //{
            //    PageViewModel = pageViewModel,
            //    Words = wordsItem
            //};

            ViewBag.categoryId = categories.GetItem(id).ParentId;
            ViewBag.subCategoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;


            return View(NativeLearnLangWords);
        }

        [Route("Home/Categories/SubCategories/Tests/Test01")]
        public IActionResult Test01(int id, int idLangLearn, int idLangNative)
        {
            Random rand = new Random();

            var LearnLangWords = words.GetList().Where(s => s.CategoryId == id);

            int randomWordId1 = rand.Next(LearnLangWords.First().Id, LearnLangWords.Last().Id + 1);
            int randomWordId2 = rand.Next(LearnLangWords.First().Id, LearnLangWords.Last().Id + 1);
            while (randomWordId1 == randomWordId2) {
                randomWordId2 = rand.Next(LearnLangWords.First().Id, LearnLangWords.Last().Id + 1);
            }

            Words word1 = words.GetItem(randomWordId1);
            Words word2 = words.GetItem(randomWordId2);

            List<Words> twoWords = new List<Words>();

            twoWords.Add(word1);
            twoWords.Add(word2);

            ViewBag.categoryId = categories.GetItem(id).ParentId;
            ViewBag.subCategoryId = id;
            ViewBag.idLangLearn = idLangLearn;
            ViewBag.idLangNative = idLangNative;

            return View(twoWords);
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
