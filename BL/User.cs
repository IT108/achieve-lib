using achieve_lib.AD;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace achieve_lib.BL
{
	public class User
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		[JsonProperty("id")]
		public string Id { get; set; }

		[BsonElement("identityID")]
		[JsonProperty("identityID")]
		public string IdentityId { get; set; }

		[BsonElement("organizationID")]
		[JsonProperty("organizationID")]
		public string OrganizationId { get; set; }
		
		[BsonElement("grade")]
		[JsonProperty("grade")]
		public string Grade { get; set; } = "0";

		[BsonElement("gradeLiteral")]
		[JsonProperty("gradeLiteral")]
		public string GradeLiteral { get; set; } = "null";

		[BsonElement("room")]
		[JsonProperty("room")]
		public string Room { get; set; } = "null";

		[BsonElement("email")]
		[JsonProperty("email")]
		public string Email { get; set; } = "null";

		[BsonElement("name")]
		[JsonProperty("name")]
		public string Name { get; set; } = "None";

		[BsonElement("surname")]
		[JsonProperty("surname")]
		public string Surname { get; set; } = "None";

		[BsonElement("group")]
		[JsonProperty("group")]
		public string Group { get; set; } = "None";

		[BsonElement("adUser")]
		[JsonProperty("adUser")]
		public ADUser AdUser { get; set; } = new ADUser();

		[BsonElement("interests")]
		[JsonProperty("interests")]
		public List<string> Interests { get; set; } = new List<string>();

		[BsonElement("description")]
		[JsonProperty("description")]
		public string Description { get; set; } = "";

		[BsonElement("activities")]
		[JsonProperty("activities")]
		public List<string> Projects { get; set; } = new List<string>();
	}
}
