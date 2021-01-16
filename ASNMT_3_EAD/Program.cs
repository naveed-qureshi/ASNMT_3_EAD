using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASNMT_3_EAD
{
		public class Program
		{
				public static void Main ( string[] args )
				{
						CreateHostBuilder (args).Build ().Run ();
				}

				public static IHostBuilder CreateHostBuilder ( string[] args ) =>
						Host.CreateDefaultBuilder (args)
								.ConfigureWebHostDefaults (webBuilder =>
								 {
										 webBuilder.UseStartup<Startup> ();
								 });
		}
}
