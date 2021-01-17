using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ASNMT_3_EAD.Models
{
		public class Posts
		{
		    public int ID{ get; set; }
				public string UserName { get; set; }
				public string Title { get; set; }
				public string Content { get; set; }
				public string Date{ get; set; }
				public string user2{ get; set; }

				public string getProfileImage(){
						SqlConnection con;
						SqlCommand cmd;
						SqlDataReader sdr;
						string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
						con = new SqlConnection (conString);
						con.Open ();

						string query = $"select* from Users where userName='{this.UserName}'";
						cmd = new SqlCommand (query, con);

						sdr = cmd.ExecuteReader ();
						if (sdr.HasRows)
						{
								sdr.Read ();
							 
								return sdr.GetString (3); //image address
						}
						return null;
				}
		}
}
