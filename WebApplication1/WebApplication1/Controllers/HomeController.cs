using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        //наименование контроллеров и представлений должны быть одинаково названы
        public ActionResult Index()
        {
            var weeks = new List<WeekDay>();
            var monday = new WeekDay
            {
                Day = "Понедельник",
                Subjects = new List<string>()
            };
            monday.Subjects.Add("Менеджмент");
            monday.Subjects.Add("Дискретка");
            monday.Subjects.Add("Комп сети");
            weeks.Add(monday);

            var tuesday = new WeekDay
            {
                Day = "Вторник",
                Subjects = new List<string>()
            };
            tuesday.Subjects.Add("Физра");
            tuesday.Subjects.Add("МатАнализ");
            weeks.Add(tuesday);

            var wednersday = new WeekDay
            {
                Day = "Среда",
                Subjects = new List<string>()
            };
            wednersday.Subjects.Add("ИСТ");
            wednersday.Subjects.Add("Дискретка");
            weeks.Add(wednersday);

            var thursday = new WeekDay
            {
                Day = "Четверг",
                Subjects = new List<string>()
            };
            thursday.Subjects.Add("ПпП");
            thursday.Subjects.Add("Физра");
            thursday.Subjects.Add("Менеджмент");
            weeks.Add(thursday);

            var friday = new WeekDay
            {
                Day = "Пятница",
                Subjects = new List<string>()
            };
            friday.Subjects.Add("ИСТ");
            friday.Subjects.Add("Комп сети");
            friday.Subjects.Add("АВС");
            friday.Subjects.Add("ПпП");
            weeks.Add(friday);

            var saturday = new WeekDay
            {
                Day = "Суббота",
                Subjects = new List<string>()
            };
            saturday.Subjects.Add("МатАнализ");
            saturday.Subjects.Add("МатАнализ");
            saturday.Subjects.Add("АВС");
            weeks.Add(saturday);

            //ViewBag.Weeks = weeks; //способ передачи через модель- кушает меньше ресурсов

            return View(weeks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}