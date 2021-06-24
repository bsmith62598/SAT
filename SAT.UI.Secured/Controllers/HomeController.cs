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
            #region Email Notes
            /*
             * To send emails you typically need to add two using statements:
             * System.Net: Gives us acces to provide credentials for the SMTP server (username/PW portal)
             * System.Net.Mail: Access to the MailMessage class and it's associated methods.
             * 
             * Information required to send the email:
             * SMTP server name - mail.domain.ext
             * Email username (created at SmarterASP)
             * Email Password (created at SmarterASP)
             * port numbers - optional and will only need to be defined if you are unable to send emails. The default port is port 25, the alternative is 8889.
             */
            #endregion

            if (!ModelState.IsValid)
            {
                return View(cvm);
            }

            //The first thing we need to do is configure the email message as a string:
            string message = $"You have received a message from {cvm.Name} with a " +
                $"subject of {cvm.Subject}. Please respond to {cvm.EmailAddress} with " +
                $"your response to the following message:<br />{cvm.Message}";

            //Now we need to configure a MailMesage object
            MailMessage mm = new MailMessage("admin@brandonsmithjr.com", "bsmith62598@gmail.com", cvm.Subject, message);

            //Configure some properties:
            mm.IsBodyHtml = true; //determines whether the email body should be rendered as HTML
            mm.Priority = MailPriority.High;
            mm.ReplyToList.Add(cvm.EmailAddress);
            //Updates the reply to go to the sender's email instead of the admin account at the website

            //Send the email:
            SmtpClient client = new SmtpClient("mail.brandonsmithjr.com");
            //The email service credentials
            client.Credentials = new NetworkCredential("admin@brandonsmithjr.com", "Bsmith062598!");

            //Attempt to send the email and handle any exceptions if we can't:
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

