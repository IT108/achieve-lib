using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace achieve_lib.AD
{
	public class User
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		[JsonProperty("id")]
		public string Id { get; set; }
		
		[BsonElement("name")]
		[JsonProperty("name")]
		public string Name { get; set; }

		[BsonElement("surname")]
		[JsonProperty("surname")]
		public string Surname { get; set; }

		[BsonElement("group")]
		[JsonProperty("group")]
		public string Group { get; set; }

		[BsonElement("adUser")]
		[JsonProperty("adUser")]
		public ADUser AdUser { get; set; }

		[BsonElement("interests")]
		[JsonProperty("interests")]
		public List<string> Interests { get; set; }

		[BsonElement("activities")]
		[JsonProperty("activities")]
		public List<string> Activities { get; set; }
	}
}
