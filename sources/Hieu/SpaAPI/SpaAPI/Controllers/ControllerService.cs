using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaAPI.Models;

namespace SpaAPI.Controllers
{
    [Route("api/dichvu")]
    [ApiController]
    public class ControllerService : ControllerBase
    {
        private readonly SpaManagementContext context;

        public ControllerService(SpaManagementContext _context)
        {
            context = _context;
        }
        /*SpaManagementContext context = new SpaManagementContext();
      
        [HttpGet]
        public ServiceCustomer GetByServiceID (int id)
        {
            ServiceCustomer sc = new ServiceCustomer();
            using (context)
            {
                sc = context.ServiceCustomer
                    .Where(_sc => _sc.ServiceId == id)
                    .Select(_sc => new ServiceCustomer()
                    {
                        ServiceId = _sc.ServiceId,
                        ServiceName = _sc.ServiceName,
                        ServiceImage = _sc.ServiceImage,
                        Price = _sc.Price,
                        TherapistId = _sc.TherapistId,
                        ServiceDescription = _sc.ServiceDescription,
                        ServiceTime = _sc.ServiceTime,
                        BreakTime = _sc.BreakTime,
                        Code = _sc.Code
                    }) .FirstOrDefault();

            }
            return sc;
        }*/
        [HttpGet]

        public IActionResult GetListDichVu()
        {
            List<ServiceCustomer> dichvu = context.ServiceCustomer.ToList();

            return new JsonResult(dichvu);
        }

       

        [HttpPost]
        public IActionResult CreateService(ServiceCustomer sc)
        {
            try
            {
                sc.ServiceId = 0;
                context.Add(sc);
                context.SaveChanges();
            }
            catch
            {
                return BadRequest("Error!");
            }
            return new StatusCodeResult(200);

        }
        [Route("id")]
        [HttpGet]


        public IActionResult GetListDichVuById(int id)
        {
            try
            {
                List<ServiceCustomer> dichvu = context.ServiceCustomer.Where(_service => _service.ServiceId == id).ToList();
                return new JsonResult(dichvu);
            }
            catch
            {
                return BadRequest("Error!");
            }
        }


    }
}
