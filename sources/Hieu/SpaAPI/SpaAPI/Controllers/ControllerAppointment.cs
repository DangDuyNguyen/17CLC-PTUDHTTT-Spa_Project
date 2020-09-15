using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpaAPI.Models;
using SQLitePCL;

namespace SpaAPI.Controllers
{
    [Route("api/appointment")]
    [ApiController]
    public class ControllerAppointment : ControllerBase
    {
        /*SpaManagementContext context = new SpaManagementContext();

        [HttpGet]

        public BookAppointment GetAppointmentByBookId(int id)
        {
            BookAppointment book = new BookAppointment();

            using (context)
            {
                book = context.BookAppointment
                    .Where(_book => _book.BookId == id)
                    .Select(_book => new BookAppointment()
                    {
                        BookId = _book.BookId,
                        CustomerId = _book.CustomerId,
                        ConsultantId = _book.ConsultantId,
                        List_Service = _book.List_Service,
                        List_Product = _book.List_Product,
                        DateAppointment = _book.DateAppointment,
                        DateFoundedAppointment = _book.DateFoundedAppointment,
                        StaffId = _book.StaffId,
                        OutletId = _book.OutletId,
                        Rating = _book.Rating,
                        Feedback = _book.Feedback,
                        TotalPrice = _book.TotalPrice,
                        StatusBook = _book.StatusBook
                    }).FirstOrDefault();
            }
            return book;
        }*/

        private readonly SpaManagementContext context;

        public ControllerAppointment(SpaManagementContext _context)
        {
            context = _context;
        }

        public IActionResult GetListAppointmentById(int id)
        {
            try
            {
                List<BookAppointment> cuochen = context.BookAppointment.Where(_appointment => _appointment.BookId == id).ToList();
                return new JsonResult(cuochen);
            }
            catch (Exception ex)
            {
                return BadRequest("Error!");
            }
        }
        [Route("khachhang")]
        [HttpGet]

        public IActionResult GetListAppointmentByCustomerId(int id)
        {
            try
            {
                List<BookAppointment> cuochen = context.BookAppointment.Where(_appointment => _appointment.CustomerId == id).ToList();
                return new JsonResult(cuochen);
            }
            catch (Exception ex)
            {
                return BadRequest("Error!");
            }
        }
    }
}
