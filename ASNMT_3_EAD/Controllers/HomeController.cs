
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using  ASNMT_3_EAD.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace ASNMT_3_EAD.Controllers
{
		public class HomeController : Controller
		{
		   [HttpGet]
				public PartialViewResult LoginForm(){
						return PartialView("LoginForm");
				}
				public ViewResult Post(string UserName )
				{
						Posts pts = new Posts ();
						pts.UserName = UserName;
						return View ("Post",pts);
				}
				public ViewResult Profile()
				{
						UserData ud = new UserData ();
						if (HttpContext.Request.Cookies.ContainsKey ("uName"))
						{
								ud.UserName = HttpContext.Request.Cookies["uName"];
								UserDB.getUserData (ud);
								return View (ud);
						}

						return View (ud);
				}
				public ViewResult Login (string email,string password )
				{
						UserData ud = new UserData ();
						if (UserDB.verifyUser (email, password,ud))
						{
								PostsRepository.records.UserName = ud.UserName;
								HttpContext.Response.Cookies.Append ("uName", ud.UserName);
								return View ("Blogs", PostsRepository.records);
						}
						//return View ("Thankscshtml",ud);
						else
								return View ("LoginForm");
				}

				[HttpPost]
				public async Task<ViewResult> SignUpAsync (User usr)
				{
						
						string filePath = Path.Combine (Directory.GetCurrentDirectory (),"wwwroot/images/"+ usr.Image.FileName);
						using (Stream fileStream = new FileStream (filePath, FileMode.Create))
						{
								await usr.Image.CopyToAsync (fileStream);
						}
						UserData usrData = new UserData () { UserName = usr.UserName, Email = usr.Email, Password = usr.password, ImageAddress = $"/images/{usr.Image.FileName}" };
						UserDB.AddUser (usrData);

						PostsRepository.records.UserName = usr.UserName;
						HttpContext.Response.Cookies.Append ("uName", usr.UserName);
						return View ("Blogs", PostsRepository.records);
				}

				[HttpPost]
				public ViewResult Blogs(Posts p){
						
						PostsRepository.records.UserName = p.UserName;
						PostsRepository.records.Add (p);
						UserDB.AddPost (p);
						return View ("Blogs", PostsRepository.records);
				}
				
				public ViewResult PostDetails(int id){
						Posts p = new Posts ();
						p.ID = id;
						UserDB.getPostData (p);
						if(HttpContext.Request.Cookies.ContainsKey("uName")){
								p.user2 = HttpContext.Request.Cookies["uName"];
						}
						return View (p);
				}
		}
}
