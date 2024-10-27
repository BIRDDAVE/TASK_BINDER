using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Test_APP.File_Folder;

namespace Test_APP
{
	public class Folder_detail
	{
			public Folders_Model ScanDirectory(string path)
			{
				if (!Directory.Exists(path))
				{												
					MessageBox.Show("Please provide a valid directory path.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);		
					return null;
				}		
				var Folders_Info = new DirectoryInfo(path);
				var Build_Model = Build_Folder_Model(Folders_Info);
				Console.WriteLine("Directory structure loaded successfully.");
				return Build_Model;
			}

			public Folders_Model Build_Folder_Model(DirectoryInfo Directory_Info)
			{
				var Create_Model = new Folders_Model(Directory_Info.Name);
				foreach (var File_help_value in Directory_Info.GetFiles())
				{
					var Files_in_folders = new Files_Model(File_help_value.Name, File_help_value.Extension);
					Create_Model.Files.Add(Files_in_folders);
					Console.WriteLine("File_help_value"+File_help_value);	
				}
				// Add nested directories 
				foreach (var Nested_Help_Value in Directory_Info.GetDirectories())
				{
					Create_Model.NestedDirectories.Add(Build_Folder_Model(Nested_Help_Value));
					Console.WriteLine("Nested_Help_Value" + Nested_Help_Value);
				}
				return Create_Model;
			}
	}
}
