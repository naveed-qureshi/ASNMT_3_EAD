using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASNMT_3_EAD.Models
{
		public class PostsRepository
		{
				public static Records records = new Records ();
				public static void AddPost ( Posts p )
				{
						records.Add (p);
				}
		}
}
