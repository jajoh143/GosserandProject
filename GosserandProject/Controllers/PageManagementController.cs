using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Data.Commands;
using GosserandProject.Data.DTO.Admin;
using GosserandProject.Models.ViewModels.Admin.PageManagement;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace GosserandProject.Web.Controllers
{
   
    public class PageManagementController : Controller
    {
        private readonly IConfiguration _configuration;

        public PageManagementController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            var model = new PageManagementViewModel(_configuration.GetConnectionString("DefaultConnection"));
            return View(model);
        }

        public IActionResult Edit(int Id)
        {
            var model = new PageManagementDetailViewModel(_configuration.GetConnectionString("DefaultConnection"), Id);
            return View(model);
        }

       
        public IActionResult Create()
        {
            var model = new PageManagementCreateViewModel();
            return View(model);
        }

       
    }
}