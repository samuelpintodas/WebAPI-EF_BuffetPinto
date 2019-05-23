using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EF;

namespace WebAPI_EF_BuffetPinto.Controllers
{
    public class HotelController : ApiController
    {
        public IHttpActionResult GetHotel(int id)
        {
            using (var context = new BookingValaisPintoDaSilvaEntities())
            {
                var hotel = context.Hotel.FirstOrDefault((h) => h.IdHotel == id);

                if (hotel == null)
                {
                    return NotFound();
                }

                return Ok(hotel);
            }
        }
    }
}