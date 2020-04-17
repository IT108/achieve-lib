using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices;

namespace achieve_lib.AD
{
	public class ADUser
	{
		public ADUser() { }

		public ADUser(string username, string displayName, string name, string surname, string principalName)
		{
			Username = username;
			DisplayName = displayName;
			FirstName = name;
			Surname = surname;
			PrincipalName = principalName;
		}

		public ADUser(SearchResult user)
		{
			Groups = new List<string>();
			DisplayName = user.Properties["displayName"][0].ToString();
			Username = user.Properties["sAMAccountName"][0].ToString();
			FirstName = user.Properties["givenname"][0].ToString();
			Surname = user.Properties["sn"][0].ToString();
			PrincipalName = user.Properties["userPrincipalName"][0].ToString();
			foreach (var group in user.Properties["memberOf"])
			{
				Groups.Add(group.ToString());
			}

		}

		[Required]
		[JsonRequired]
		[JsonProperty("username")]
		public string Username { get; set; }

		[Required]
		[JsonRequired]
		[JsonProperty("display_name")]
		public string DisplayName { get; set; }

		[Required]
		[JsonRequired]
		[JsonProperty("givenname")]
		public string FirstName { get; set; }

		[Required]
		[JsonRequired]
		[JsonProperty("surname")]
		public string Surname { get; set; }

		[Required]
		[JsonRequired]
		[JsonProperty("principal_name")]
		public string PrincipalName { get; set; }

		[Required]
		[JsonRequired]
		[JsonProperty("groups")]
		public List<string> Groups { get; set; }

	}
}
