using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaAPI.Models;

namespace SpaAPI.Controllers
{
    [Route("api/chinhanh")]
    [ApiController]
    public class ControllerOutlet : ControllerBase
    {
        private readonly SpaManagementContext context;

        public ControllerOutlet(SpaManagementContext _context)
        {
            context = _context;
        }

        [HttpGet]

        public IActionResult GetListChiNhanh()
        {
            List<Outlet> chinhanh = context.Outlet.ToList();

            return new JsonResult(chinhanh);
        }
        [Route("id")]

        [HttpGet]
        public IActionResult GetListChiNhanhById(int id)
        {
            try
            {
                List<Outlet> chinhanh = context.Outlet.Where(_outlet => _outlet.OutletId == id).ToList();
                return new JsonResult(chinhanh);
            }
            catch (Exception ex)
            {
                return BadRequest("Error!");
            }
        }

     
    }
}
