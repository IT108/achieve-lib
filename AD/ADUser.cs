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

		[JsonProperty("username")]
		public string Username { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }

		[JsonProperty("firstname")]
		public string FirstName { get; set; }

		[JsonProperty("surname")]
		public string Surname { get; set; }

		[JsonProperty("principalName")]
		public string PrincipalName { get; set; }

		[JsonProperty("groups")]
		public List<string> Groups { get; set; }

	}
}
