using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace achieve_lib.AD
{
	public class ADAuthRequest : EdgeRequest
	{
		[Required]
		[JsonProperty("domain")]
		public string Domain { get; set; }

		[Required]
		[JsonProperty("username")]
		public string Username { get; set; }

		[Required]
		[JsonProperty("password")]
		public string Password { get; set; }

		[Required]
		[JsonProperty("result")]
		public ADUser Result { get; set; }
	}
}

