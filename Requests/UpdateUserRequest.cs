using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace achieve_lib.Requests
{
	public class UpdateUserRequest
	{

		[JsonProperty("grade")]
		public string Grade { get; set; } = "0";

		[JsonProperty("gradeLiteral")]
		public string GradeLiteral { get; set; } = "null";

		[JsonProperty("room")]
		public string Room { get; set; } = "null";

		[JsonProperty("email")]
		public string Email { get; set; } = "null";

		[JsonProperty("name")]
		public string Name { get; set; } = "None";

		[JsonProperty("surname")]
		public string Surname { get; set; } = "None";

		[JsonProperty("interests")]
		public List<string> Interests { get; set; } = new List<string>();

		[JsonProperty("description")]
		public string Description { get; set; } = "";
	}
}
