using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASNMT_3_EAD.Models
{
		public class User
		{
				public string UserName { get; set; }
				public string Email { get; set; }
				public string password { get; set; }
				public IFormFile Image { get; set; }

		}
}
