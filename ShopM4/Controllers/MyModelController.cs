﻿using System;
using Microsoft.AspNetCore.Authorization;
using System.Data;
using Microsoft.AspNetCore.Mvc;
using ShopM4_DataMigrations.Data;
using ShopM4_Models;
using ShopM4_Utility;

using ShopM4_DataMigrations.Repository.IRepository;
using ShopM4_DataMigrations.Repository;

namespace ShopM4.Controllers
{
    [Authorize(Roles = PathManager.AdminRole)]
    public class MyModelController : Controller
    {
        //private ApplicationDbContext db;
        private IRepositoryMyModel repositoryMyModel;

        public MyModelController(IRepositoryMyModel repositoryMyModel)
        {
            this.repositoryMyModel = repositoryMyModel;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<MyModel> models = repositoryMyModel.GetAll();

            return View(models);
        }

        // GET CREATE
        public IActionResult Create()
        {
            // ???
            return View();
        }

        // POST CREATE
        [HttpPost]
        public IActionResult Create(MyModel myModel)
        {
            repositoryMyModel.Add(myModel);
            repositoryMyModel.Save();

            return RedirectToAction("Index");
        }
    }
}

