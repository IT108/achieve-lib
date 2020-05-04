using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace achieve_lib.BL
{
	public class Project
	{
		[BsonId]
		[BsonRepresentation(BsonType.ObjectId)]
		[JsonProperty("id")]
		public string Id { get; set; }

		[BsonElement("name")]
		[JsonProperty("name")]
		public string Name { get; set; }

		[BsonElement("description")]
		[JsonProperty("description")]
		public string Description { get; set; }

		[BsonElement("participants")]
		[JsonProperty("participants")]
		public List<string> Participants { get; set; }

		[BsonElement("profiles")]
		[JsonProperty("profiles")]
		public List<string> Profiles { get; set; }


		[BsonElement("curator")]
		[JsonProperty("curator")]
		public string Curator { get; set; }

		[BsonElement("stages")]
		[JsonProperty("stages")]
		public List<Stage> Stages { get; set; }

		[BsonElement("startDate")]
		[JsonProperty("startDate")]
		public DateTime StartDate { get; set; }

		[BsonElement("endDate")]
		[JsonProperty("endDate")]
		public DateTime EndDate { get; set; }
	}
}
