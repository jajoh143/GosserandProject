using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GosserandProject.Data.Commands.Admin;
using GosserandProject.Data.DTO.Admin;
using GossserandProject.Data.Queries.Page;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GosserandProject.Api.Controllers.Page
{
    public class PageManagementController : Controller
    {
        private IConfiguration _configuration;

        public PageManagementController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult GetPages()
        {
            return Ok(GetPageManagementData.GetPagesData(_configuration.GetConnectionString("DefaultConnection")));
        }

        [HttpPost]
        public IActionResult UpdatePage([FromBody]PageDetailDTO page)
        {
            return Ok(ModifyPageManagementData.UpdatePage(_configuration.GetConnectionString("DefaultConnection"), page));
        }

        [HttpPost]
        public IActionResult CreatePage([FromBody]PageDetailDTO page)
        {
            return Ok(ModifyPageManagementData.CreatePage(_configuration.GetConnectionString("DefaultConnection"), page));
        }
    }
}
