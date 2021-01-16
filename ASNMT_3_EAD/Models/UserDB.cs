using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace ASNMT_3_EAD.Models
{
		public static class UserDB
		{
		     
				public static void AddUser(UserData usr){
						SqlConnection con;
						SqlCommand cmd;
						string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
						con = new SqlConnection (conString);
						con.Open ();

						string query = "insert into Users(userName,email,password,imageAddress) values ('" + usr.UserName + "','" + usr.Email + "','" + usr.Password + "','" + usr.ImageAddress + "')";
						cmd = new SqlCommand (query,con);
						
						int a=cmd.ExecuteNonQuery ();
						if(a==1)
						{
								con.Close ();
						}
						else{
								con.Close ();
						}
				}
				public static bool verifyUser ( string email, string password, UserData ud){
						SqlConnection con;
						SqlCommand cmd;
						SqlDataReader sdr;
						string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Blog;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
						con = new SqlConnection (conString);
						con.Open ();

						string query = $"select* from Users where email='{email}' and password='{password}'";
						cmd = new SqlCommand (query, con);

						sdr = cmd.ExecuteReader ();
						if(sdr.HasRows){
								sdr.Read ();
								ud.UserName=sdr.GetString (0);
								ud.Email = sdr.GetString (1);
								ud.Password = sdr.GetString (2);
								ud.ImageAddress = sdr.GetString (3);
								return true;
						}
						return false;
				}
		}
}
