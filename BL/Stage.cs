using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace achieve_lib.BL
{
	public class Stage
	{
		[BsonElement("name")]
		[JsonProperty("name")]
		public string Name { get; set; }

		[BsonElement("date")]
		[JsonProperty("date")]
		public DateTime Date { get; set; }

		[BsonElement("points")]
		[JsonProperty("points")]
		public int Points { get; set; }
	}
}
