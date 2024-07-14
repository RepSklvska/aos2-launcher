namespace aos2_launcher
{
	partial class FormInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
			tabControl1 = new System.Windows.Forms.TabControl();
			TabPageVersions = new System.Windows.Forms.TabPage();
			richTextBox1 = new System.Windows.Forms.RichTextBox();
			TabPageTheLauncher = new System.Windows.Forms.TabPage();
			groupBox2 = new System.Windows.Forms.GroupBox();
			LinkLabelEmail = new System.Windows.Forms.LinkLabel();
			LinkLabelSteam = new System.Windows.Forms.LinkLabel();
			LinkLabelGithubPage = new System.Windows.Forms.LinkLabel();
			label2 = new System.Windows.Forms.Label();
			pictureBox1 = new System.Windows.Forms.PictureBox();
			groupBox1 = new System.Windows.Forms.GroupBox();
			LinkLabelGithubRepo = new System.Windows.Forms.LinkLabel();
			label1 = new System.Windows.Forms.Label();
			ButtonOK = new System.Windows.Forms.Button();
			tabControl1.SuspendLayout();
			TabPageVersions.SuspendLayout();
			TabPageTheLauncher.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(TabPageVersions);
			tabControl1.Controls.Add(TabPageTheLauncher);
			tabControl1.Location = new System.Drawing.Point(14, 14);
			tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new System.Drawing.Size(373, 217);
			tabControl1.TabIndex = 0;
			// 
			// TabPageVersions
			// 
			TabPageVersions.Controls.Add(richTextBox1);
			TabPageVersions.Location = new System.Drawing.Point(4, 24);
			TabPageVersions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			TabPageVersions.Name = "TabPageVersions";
			TabPageVersions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			TabPageVersions.Size = new System.Drawing.Size(365, 189);
			TabPageVersions.TabIndex = 0;
			TabPageVersions.Text = "Versions";
			TabPageVersions.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			richTextBox1.BackColor = System.Drawing.Color.White;
			richTextBox1.Location = new System.Drawing.Point(7, 7);
			richTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			richTextBox1.Name = "richTextBox1";
			richTextBox1.ReadOnly = true;
			richTextBox1.Size = new System.Drawing.Size(349, 172);
			richTextBox1.TabIndex = 0;
			richTextBox1.TabStop = false;
			richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// TabPageTheLauncher
			// 
			TabPageTheLauncher.Controls.Add(groupBox2);
			TabPageTheLauncher.Controls.Add(groupBox1);
			TabPageTheLauncher.Location = new System.Drawing.Point(4, 24);
			TabPageTheLauncher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			TabPageTheLauncher.Name = "TabPageTheLauncher";
			TabPageTheLauncher.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			TabPageTheLauncher.Size = new System.Drawing.Size(365, 189);
			TabPageTheLauncher.TabIndex = 1;
			TabPageTheLauncher.Text = "The Launcher";
			TabPageTheLauncher.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(LinkLabelEmail);
			groupBox2.Controls.Add(LinkLabelSteam);
			groupBox2.Controls.Add(LinkLabelGithubPage);
			groupBox2.Controls.Add(label2);
			groupBox2.Controls.Add(pictureBox1);
			groupBox2.Location = new System.Drawing.Point(8, 92);
			groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox2.Name = "groupBox2";
			groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox2.Size = new System.Drawing.Size(349, 88);
			groupBox2.TabIndex = 2;
			groupBox2.TabStop = false;
			groupBox2.Text = "Author";
			// 
			// LinkLabelEmail
			// 
			LinkLabelEmail.AutoSize = true;
			LinkLabelEmail.Location = new System.Drawing.Point(181, 48);
			LinkLabelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			LinkLabelEmail.Name = "LinkLabelEmail";
			LinkLabelEmail.Size = new System.Drawing.Size(36, 15);
			LinkLabelEmail.TabIndex = 4;
			LinkLabelEmail.TabStop = true;
			LinkLabelEmail.Text = "Email";
			LinkLabelEmail.LinkClicked += LinkLabelEmail_LinkClicked;
			// 
			// LinkLabelSteam
			// 
			LinkLabelSteam.AutoSize = true;
			LinkLabelSteam.Location = new System.Drawing.Point(7, 48);
			LinkLabelSteam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			LinkLabelSteam.Name = "LinkLabelSteam";
			LinkLabelSteam.Size = new System.Drawing.Size(77, 15);
			LinkLabelSteam.TabIndex = 3;
			LinkLabelSteam.TabStop = true;
			LinkLabelSteam.Text = "Steam Profile";
			LinkLabelSteam.LinkClicked += LinkLabelSteam_LinkClicked;
			// 
			// LinkLabelGithubPage
			// 
			LinkLabelGithubPage.AutoSize = true;
			LinkLabelGithubPage.Location = new System.Drawing.Point(94, 48);
			LinkLabelGithubPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			LinkLabelGithubPage.Name = "LinkLabelGithubPage";
			LinkLabelGithubPage.Size = new System.Drawing.Size(74, 15);
			LinkLabelGithubPage.TabIndex = 2;
			LinkLabelGithubPage.TabStop = true;
			LinkLabelGithubPage.Text = "GitHub Page";
			LinkLabelGithubPage.LinkClicked += LinkLabelGithubPage_LinkClicked;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(7, 18);
			label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(129, 15);
			label2.TabIndex = 1;
			label2.Text = "Iztecteocuitlatl Sokolov";
			// 
			// pictureBox1
			// 
			pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new System.Drawing.Point(284, 22);
			pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(58, 58);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(LinkLabelGithubRepo);
			groupBox1.Controls.Add(label1);
			groupBox1.Location = new System.Drawing.Point(8, 8);
			groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox1.Name = "groupBox1";
			groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			groupBox1.Size = new System.Drawing.Size(349, 77);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Information";
			// 
			// LinkLabelGithubRepo
			// 
			LinkLabelGithubRepo.AutoSize = true;
			LinkLabelGithubRepo.Location = new System.Drawing.Point(7, 33);
			LinkLabelGithubRepo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			LinkLabelGithubRepo.Name = "LinkLabelGithubRepo";
			LinkLabelGithubRepo.Size = new System.Drawing.Size(104, 15);
			LinkLabelGithubRepo.TabIndex = 1;
			LinkLabelGithubRepo.TabStop = true;
			LinkLabelGithubRepo.Text = "GitHub Reopsitory";
			LinkLabelGithubRepo.LinkClicked += LinkLabelGithubRepo_LinkClicked;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(7, 18);
			label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(219, 15);
			label1.TabIndex = 0;
			label1.Text = "Acceleration of Suguri 2 Version Selector";
			// 
			// ButtonOK
			// 
			ButtonOK.Location = new System.Drawing.Point(300, 238);
			ButtonOK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			ButtonOK.Name = "ButtonOK";
			ButtonOK.Size = new System.Drawing.Size(88, 27);
			ButtonOK.TabIndex = 1;
			ButtonOK.Text = "OK";
			ButtonOK.UseVisualStyleBackColor = true;
			ButtonOK.Click += ButtonOK_Click;
			// 
			// FormInfo
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(401, 278);
			Controls.Add(ButtonOK);
			Controls.Add(tabControl1);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormInfo";
			ShowIcon = false;
			Text = "About";
			TopMost = true;
			tabControl1.ResumeLayout(false);
			TabPageVersions.ResumeLayout(false);
			TabPageTheLauncher.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage TabPageVersions;
		private System.Windows.Forms.TabPage TabPageTheLauncher;
		private System.Windows.Forms.Button ButtonOK;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel LinkLabelGithubRepo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.LinkLabel LinkLabelSteam;
		private System.Windows.Forms.LinkLabel LinkLabelGithubPage;
		private System.Windows.Forms.LinkLabel LinkLabelEmail;
	}
}