using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace achieve_lib
{



	public class ApiRequest
	{
		private string error;

		public ApiRequest()
		{
			IsSuccess = true;
			RequestNumber = Utils.PasswordGenerator.Generate(requiredLength: 20,
				requireNonAlphanumeric: false);
		}

		public string RequestNumber { get; set; }

		public string Caller { get; set; }

		public bool IsSuccess { get; set; } = true;

		public string Error
		{
			get
			{
				return error;
			}
			set
			{
				error = value;
			}
		}
	}
}
