using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ASNMT_3_EAD.Models
{
		public class Records
		{
				public List<Posts> posts = new List<Posts> ();
				public string UserName{ get; set; }
				public Records(){
						SqlConnection con;
						SqlCommand cmd;
						SqlDataReader sdr;
						string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
						con = new SqlConnection (conString);
						con.Open ();

						string query = $"select* from Posts";
						cmd = new SqlCommand (query, con);

						sdr = cmd.ExecuteReader ();
						while (sdr.Read ())
						{
								posts.Add (new Posts { ID=sdr.GetInt32(0),UserName = sdr.GetString (1),Date=sdr.GetString(2),Title=sdr.GetString(3),Content=sdr.GetString(4) });
						}

						con.Close ();
				
				}
				public void Add(Posts p){
						posts.Add (p);
				}
		}
}
