using achieve_lib.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achieve_lib.Requests
{
	public class CreateUserRequest
	{
		public string Key { get; set; }

		public User User { get; set; }
	}
}
