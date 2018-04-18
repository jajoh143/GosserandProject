using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<IActionResult> GetPages()
        {
            return Ok(await GetPageManagementData.GetPagesData(_configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
