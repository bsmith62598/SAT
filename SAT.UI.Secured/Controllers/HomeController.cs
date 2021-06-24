using SAT.UI.Secured.Models;
using System;
using System.Net;
using System.Net.Mail;
using System.Web.Mvc;

namespace SAT.UI.Secured.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact(ContactViewModel cvm)
        {

            if (!ModelState.IsValid)
            {
                return View(cvm);
            }
            
            string message = $"You have received a message from {cvm.Name} with a " +
                $"subject of {cvm.Subject}. Please respond to {cvm.EmailAddress} with " +
                $"your response to the following message:<br />{cvm.Message}";
            
            MailMessage mm = new MailMessage("admin@brandonsmithjr.com", "bsmith62598@gmail.com", cvm.Subject, message);
            
            mm.IsBodyHtml = true; 
            mm.Priority = MailPriority.High;
            mm.ReplyToList.Add(cvm.EmailAddress);
            
            SmtpClient client = new SmtpClient("mail.brandonsmithjr.com");
            
            client.Credentials = new NetworkCredential("admin@brandonsmithjr.com", "Bsmith062598!");
            
            try
            {
                client.Send(mm);
            }
            catch (Exception ex)
            {
                ViewBag.CustomerMessage = $"Not today, NO NO NO<br />Error message: {ex.Message}.";
                return View(cvm);
            }
            ViewBag.CustomerMessage = $"Thank you for your email. We typically resond within 27 days.";
            return View("Contact");
        }
    }
}

