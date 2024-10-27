using System.Threading;

namespace Test_APP
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.text_PATH = new System.Windows.Forms.TextBox();
			this.button_JSON = new System.Windows.Forms.Button();
			this.JSON_folder_view = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Size_folder = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(6, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "PATH Folder";
			// 
			// text_PATH
			// 
			this.text_PATH.Location = new System.Drawing.Point(91, 26);
			this.text_PATH.Name = "text_PATH";
			this.text_PATH.Size = new System.Drawing.Size(306, 20);
			this.text_PATH.TabIndex = 2;
			this.text_PATH.TextChanged += new System.EventHandler(this.text_PATH_TextChanged);
			// 
			// button_JSON
			// 
			this.button_JSON.Location = new System.Drawing.Point(403, 25);
			this.button_JSON.Name = "button_JSON";
			this.button_JSON.Size = new System.Drawing.Size(122, 23);
			this.button_JSON.TabIndex = 3;
			this.button_JSON.Text = "Analyze JSON";
			this.button_JSON.UseVisualStyleBackColor = true;
			this.button_JSON.Click += new System.EventHandler(this.button_JSON_Click);
			// 
			// JSON_folder_view
			// 
			this.JSON_folder_view.BackColor = System.Drawing.Color.RoyalBlue;
			this.JSON_folder_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.JSON_folder_view.ForeColor = System.Drawing.Color.White;
			this.JSON_folder_view.Location = new System.Drawing.Point(167, 95);
			this.JSON_folder_view.Multiline = true;
			this.JSON_folder_view.Name = "JSON_folder_view";
			this.JSON_folder_view.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.JSON_folder_view.Size = new System.Drawing.Size(487, 352);
			this.JSON_folder_view.TabIndex = 4;
			this.JSON_folder_view.TextChanged += new System.EventHandler(this.JSON_folder_view_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(377, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "JSON VIEW";
			// 
			// Size_folder
			// 
			this.Size_folder.Location = new System.Drawing.Point(649, 26);
			this.Size_folder.Name = "Size_folder";
			this.Size_folder.Size = new System.Drawing.Size(100, 20);
			this.Size_folder.TabIndex = 6;
			this.Size_folder.TextChanged += new System.EventHandler(this.Size_folder_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(558, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Size of directory:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(838, 487);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Size_folder);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.JSON_folder_view);
			this.Controls.Add(this.button_JSON);
			this.Controls.Add(this.text_PATH);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox text_PATH;
		public System.Windows.Forms.Button button_JSON;
		public System.Windows.Forms.TextBox JSON_folder_view;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Size_folder;
		private System.Windows.Forms.Label label3;
	}
}

