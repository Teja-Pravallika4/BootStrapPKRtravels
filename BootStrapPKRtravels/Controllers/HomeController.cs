using BootStrapPKRtravels.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BootStrapPKRtravels.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            List<MstBus> qry = new List<MstBus>();
            using (MYBUSEntities dc = new MYBUSEntities())
            {
                qry = (from s in dc.BusInfoes
                       where s.BoardingPoint == "MUM"

                       select new MstBus
                       {
                           BusID = s.BusID,
                           BoardingPoint = s.BoardingPoint,
                           TravelDate = s.TravelDate,
                           Amount = s.Amount,
                           Rating = s.Rating,


                       }).ToList();

            }
            return View(qry);
        }
    }
}