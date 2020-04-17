using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace achieve_lib
{
	public class EdgeRequest
	{
		private string error;

		public EdgeRequest()
		{
			IsSuccess = true;
			RequestNumber = Utils.PasswordGenerator.Generate(requiredLength: 20,
				requireNonAlphanumeric: false);
		}

		[Required]
		[JsonProperty("api_key")]
		public string ApiKey { get; set; }

		public string RequestNumber { get; set; }

		public string Caller { get; set; }

		public bool IsSuccess { get; set; } = true;

		public string Error
		{
			get {
				return error;
			}
			set {
				error = value;
			}
		}
	}
}
