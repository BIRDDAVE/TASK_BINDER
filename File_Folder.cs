using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_APP
{
	public class File_Folder
	{
		//save info regarding Files which are stored in folder
		public class Files_Model
		{
			public string Name { get; }
			public string Extension { get; }

			public Files_Model(string name, string extension)  //Created constructor of File_Model
			{
				Name = name;
				Extension = extension;	
			}
		}

		//save info regarding Folders which are stored in folder
		public class Folders_Model
		{
			public string Name { get;   }
			public List<Files_Model> Files { get; set; }
			public List<Folders_Model> NestedDirectories { get;  }
			public Folders_Model(string name)           //Created constructor of Folders_Model
			{
				Name = name;
				Files = new List<Files_Model>();
				NestedDirectories = new List<Folders_Model>();				
			}
		}
	}	
}
