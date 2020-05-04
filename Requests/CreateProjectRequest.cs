using achieve_lib.BL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace achieve_lib.Requests
{
	public class CreateProjectRequest
	{
		[JsonProperty("project")]
		public Project Project { get; set; }

		[JsonProperty("answer")]
		public int answer { get; set; }
	}
}
