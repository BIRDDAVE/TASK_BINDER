using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test_APP;
using static Test_APP.File_Folder;
using static Test_APP.Folder_detail;
using Newtonsoft.Json;
using System.Security.Policy;




namespace Test_APP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}		

		public void text_PATH_TextChanged(object sender, EventArgs e)
		{
			//Function is used in function -->button_JSON_Click	
		}
		public void button_JSON_Click(object sender, EventArgs e)
		{
			JSON_folder_view.Text = "";
			string Directory_Path = text_PATH.Text;			
			string Json_file_name = "Generated_Json.json";	
			string[] Type_sizes = { "B", "KB", "MB", "GB", "TB" };
			
			Folder_detail scanner = new Folder_detail();
			Folders_Model Directory = null;
			JSON_View Json_Builder = new JSON_View();

			try
			{
				Directory = scanner.ScanDirectory(Directory_Path);
			}
			catch (Exception error)
			{				
				Console.WriteLine("Error:"+ error.Message);				
			}

			if (Directory is null)
			{
				return ;
			}

			// Print unique file extensions
			File_Extensions(Directory);

			Json_Builder.Serialize_To_Json(Directory, Json_file_name);                  //Write to Json file	
			var Json_Data_Loaded = Json_Builder.Deserialize_From_Json(Json_file_name);     //Read from Json file

			//Print to text box 
			string Read_Json = JsonConvert.SerializeObject(Json_Data_Loaded, Formatting.Indented);
			JSON_folder_view.Text = Read_Json;
			Directory_Size(Directory_Path);
		}	

		//Folders_Model Deserialized_Directory 
		public  void File_Extensions(Folders_Model Directory_Info)
		{			
			var Unique_Files_Extensions = new HashSet<string>(); //Identify Unique_Files_Extensions
			CollectFileExtensions(Directory_Info, Unique_Files_Extensions);

			Console.WriteLine("Unique file extensions found:");
			foreach (var Unique_Files_Extensions_help_value in Unique_Files_Extensions)
			{
				Console.WriteLine(Unique_Files_Extensions_help_value);
			}
		}

		public void CollectFileExtensions(Folders_Model Directory_Info_help_value_2, HashSet<string> Extensions)
		{
			if (Directory_Info_help_value_2==null)
			{
				Application.Restart();
				Console.WriteLine(string.Empty);
				return;
			}	

			foreach (var file in Directory_Info_help_value_2.Files)
			{
				Extensions.Add(file.Extension);
			}

			foreach (var Nested_value in Directory_Info_help_value_2.NestedDirectories)
			{
				CollectFileExtensions(Nested_value, Extensions);
			}
		}
		public void Directory_Size(string Folder_Path)
		{
			string[] Type_sizes = { "B", "KB", "MB", "GB", "TB" };
			int Order = 0;
			double FolderSize = 0;
			bool flag =false;

			if (!Directory.Exists(Folder_Path))
			{
				flag = true;				
				Console.WriteLine(string.Empty);
			}

			if (flag == true)
			{
				Console.WriteLine("Path is wrong and Application is restarted");
				Console.WriteLine(string.Empty);
			}

			if (flag == false)
			{
				// Read all files in directory
				FileInfo[] Files_Groupe = new DirectoryInfo(Folder_Path).GetFiles("*", SearchOption.AllDirectories);

				// Calculate size all files in directory
				foreach (FileInfo file in Files_Groupe)
				{
					FolderSize += file.Length;
				}

				while (FolderSize >= 1024 && Order < Type_sizes.Length - 1)
				{
					Order++;
					FolderSize = FolderSize / (1024);
				}
				Console.WriteLine($"{FolderSize:0.##} {Type_sizes[Order]}");
				Size_folder.Text = ($"{FolderSize:0.##} {Type_sizes[Order]}");
			}
		}

		public void JSON_folder_view_TextChanged(object sender, EventArgs e)
		{
			//Function is used in function -->button_JSON_Click
		}

		public void Size_folder_TextChanged(object sender, EventArgs e)
		{
			//Function is used in function -->button_JSON_Click
		}
	}
}

