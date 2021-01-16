
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
				public ViewResult LoginForm(){
						return View ();
				}
				public ViewResult Post(string UserName )
				{
						return View ("Post",UserName);
				}
				public ViewResult Profile()
				{
						return View ();
				}
				public ViewResult PostDetails ( )
				{
						return View ();
				}
				public ViewResult Login (string email,string password )
				{
						UserData ud = new UserData ();
						if (UserDB.verifyUser (email, password,ud))
								return View ("Blogs",ud);
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

						return View ("Blogs") ;
				}
		}
}
