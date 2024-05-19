using GeneratePass.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GeneratePass.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        
        

        [HttpPost]
        public ActionResult Index(bool checkbox, bool checkbox2, bool checkbox3, bool checkbox4)
        {
            if (checkbox && checkbox2 && checkbox3 && checkbox4== !true)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+0123456789";
                Random random = new Random();
                int length = 12;
                char[] password = new char[length];

                for (int i = 0; i < length; i++)
                {
                    password[i] = chars[random.Next(chars.Length)];
                }

                string generatedPassword5 = new string(password);

                ViewBag.Message = generatedPassword5;
            }
            if (checkbox && checkbox2 == true)
            {
                if (checkbox3)
                {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;

                }
                else
                {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }

            }




            if (checkbox2 && checkbox3 == true)
            {
                if (checkbox)
                {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;

                }
                else
                {
                    const string chars = "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;


                }
            }




            if (checkbox3 && checkbox4 == true)
            {
                if (checkbox2)
                {

                    const string chars = "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+0123456789";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;

                }
                else
                {
                    const string chars = "!@#$%^&*()_+0123456789";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }
            }




            if (checkbox && checkbox3 == true)
            {
                if (checkbox2) {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }
                else {
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()_+";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }
            }




            if (checkbox2 && checkbox4 == true)
            {
                if (checkbox3)
                {
                    const string chars = "abcdefghijklmnopqrstuvwxyz!@#$%^&*()_+0123456789";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }
                else
                {
                    const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
                    Random random = new Random();
                    int length = 12;
                    char[] password = new char[length];

                    for (int i = 0; i < length; i++)
                    {
                        password[i] = chars[random.Next(chars.Length)];
                    }

                    string generatedPassword5 = new string(password);

                    ViewBag.Message = generatedPassword5;
                }
            }




            

            if (checkbox && checkbox2 && checkbox3 && checkbox4) {


                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*()_+0123456789";
                Random random = new Random();
                int length = 12;
                char[] password = new char[length];

                for (int i = 0; i < length; i++)
                {
                    password[i] = chars[random.Next(chars.Length)];
                }

                string generatedPassword5 = new string(password);

                ViewBag.Message = generatedPassword5;
            }
            
            


            return View();
        }
    }
}