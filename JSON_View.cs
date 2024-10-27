using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Test_APP.File_Folder;
using System.Xml;
using Newtonsoft.Json;
using System.Security.Cryptography;



namespace Test_APP
{
	public class JSON_View
	{
		//write to Json file
		public void Serialize_To_Json(Folders_Model Directory_Model, string Path)
		{
			var Json = JsonConvert.SerializeObject(Directory_Model, Newtonsoft.Json.Formatting.Indented);
			Console.WriteLine("Directory information serialized and saved to " + Path);
			File.WriteAllText(Path, Json);
		}

		//Read from Json file
		public Folders_Model Deserialize_From_Json(string JsonPath)
		{
			if (!File.Exists(JsonPath))
				throw new FileNotFoundException("JSON file "+JsonPath+" not found.");
			var Json = File.ReadAllText(JsonPath);
			Console.WriteLine(Json);			
			Console.WriteLine("Directory information deserialized from JSON.");			
			return JsonConvert.DeserializeObject<Folders_Model>(Json);
		}
	}
}
