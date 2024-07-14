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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.TabPageVersions = new System.Windows.Forms.TabPage();
			this.TabPageTheLauncher = new System.Windows.Forms.TabPage();
			this.ButtonOK = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LinkLabelGithubRepo = new System.Windows.Forms.LinkLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.LinkLabelGithubPage = new System.Windows.Forms.LinkLabel();
			this.LinkLabelSteam = new System.Windows.Forms.LinkLabel();
			this.LinkLabelEmail = new System.Windows.Forms.LinkLabel();
			this.tabControl1.SuspendLayout();
			this.TabPageVersions.SuspendLayout();
			this.TabPageTheLauncher.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.TabPageVersions);
			this.tabControl1.Controls.Add(this.TabPageTheLauncher);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(320, 188);
			this.tabControl1.TabIndex = 0;
			// 
			// TabPageVersions
			// 
			this.TabPageVersions.Controls.Add(this.richTextBox1);
			this.TabPageVersions.Location = new System.Drawing.Point(4, 22);
			this.TabPageVersions.Name = "TabPageVersions";
			this.TabPageVersions.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageVersions.Size = new System.Drawing.Size(312, 162);
			this.TabPageVersions.TabIndex = 0;
			this.TabPageVersions.Text = "Versions";
			this.TabPageVersions.UseVisualStyleBackColor = true;
			// 
			// TabPageTheLauncher
			// 
			this.TabPageTheLauncher.Controls.Add(this.groupBox2);
			this.TabPageTheLauncher.Controls.Add(this.groupBox1);
			this.TabPageTheLauncher.Location = new System.Drawing.Point(4, 22);
			this.TabPageTheLauncher.Name = "TabPageTheLauncher";
			this.TabPageTheLauncher.Padding = new System.Windows.Forms.Padding(3);
			this.TabPageTheLauncher.Size = new System.Drawing.Size(312, 162);
			this.TabPageTheLauncher.TabIndex = 1;
			this.TabPageTheLauncher.Text = "The Launcher";
			this.TabPageTheLauncher.UseVisualStyleBackColor = true;
			// 
			// ButtonOK
			// 
			this.ButtonOK.Location = new System.Drawing.Point(257, 206);
			this.ButtonOK.Name = "ButtonOK";
			this.ButtonOK.Size = new System.Drawing.Size(75, 23);
			this.ButtonOK.TabIndex = 1;
			this.ButtonOK.Text = "OK";
			this.ButtonOK.UseVisualStyleBackColor = true;
			this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.White;
			this.richTextBox1.Location = new System.Drawing.Point(6, 6);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(300, 150);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.TabStop = false;
			this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.Image = global::aos2_launcher.Properties.Resources.avatar;
			this.pictureBox1.Location = new System.Drawing.Point(243, 19);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(50, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LinkLabelGithubRepo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(7, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(299, 67);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Information";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Acceleration of Suguri 2 Version Selector";
			// 
			// LinkLabelGithubRepo
			// 
			this.LinkLabelGithubRepo.AutoSize = true;
			this.LinkLabelGithubRepo.Location = new System.Drawing.Point(6, 29);
			this.LinkLabelGithubRepo.Name = "LinkLabelGithubRepo";
			this.LinkLabelGithubRepo.Size = new System.Drawing.Size(93, 13);
			this.LinkLabelGithubRepo.TabIndex = 1;
			this.LinkLabelGithubRepo.TabStop = true;
			this.LinkLabelGithubRepo.Text = "GitHub Reopsitory";
			this.LinkLabelGithubRepo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGithubRepo_LinkClicked);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LinkLabelEmail);
			this.groupBox2.Controls.Add(this.LinkLabelSteam);
			this.groupBox2.Controls.Add(this.LinkLabelGithubPage);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.pictureBox1);
			this.groupBox2.Location = new System.Drawing.Point(7, 80);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(299, 76);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Author";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Iztecteocuitlatl Sokolov";
			// 
			// LinkLabelGithubPage
			// 
			this.LinkLabelGithubPage.AutoSize = true;
			this.LinkLabelGithubPage.Location = new System.Drawing.Point(81, 42);
			this.LinkLabelGithubPage.Name = "LinkLabelGithubPage";
			this.LinkLabelGithubPage.Size = new System.Drawing.Size(68, 13);
			this.LinkLabelGithubPage.TabIndex = 2;
			this.LinkLabelGithubPage.TabStop = true;
			this.LinkLabelGithubPage.Text = "GitHub Page";
			this.LinkLabelGithubPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelGithubPage_LinkClicked);
			// 
			// LinkLabelSteam
			// 
			this.LinkLabelSteam.AutoSize = true;
			this.LinkLabelSteam.Location = new System.Drawing.Point(6, 42);
			this.LinkLabelSteam.Name = "LinkLabelSteam";
			this.LinkLabelSteam.Size = new System.Drawing.Size(69, 13);
			this.LinkLabelSteam.TabIndex = 3;
			this.LinkLabelSteam.TabStop = true;
			this.LinkLabelSteam.Text = "Steam Profile";
			this.LinkLabelSteam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelSteam_LinkClicked);
			// 
			// LinkLabelEmail
			// 
			this.LinkLabelEmail.AutoSize = true;
			this.LinkLabelEmail.Location = new System.Drawing.Point(155, 42);
			this.LinkLabelEmail.Name = "LinkLabelEmail";
			this.LinkLabelEmail.Size = new System.Drawing.Size(32, 13);
			this.LinkLabelEmail.TabIndex = 4;
			this.LinkLabelEmail.TabStop = true;
			this.LinkLabelEmail.Text = "Email";
			this.LinkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelEmail_LinkClicked);
			// 
			// FormInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(344, 241);
			this.Controls.Add(this.ButtonOK);
			this.Controls.Add(this.tabControl1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormInfo";
			this.ShowIcon = false;
			this.Text = "About";
			this.TopMost = true;
			this.tabControl1.ResumeLayout(false);
			this.TabPageVersions.ResumeLayout(false);
			this.TabPageTheLauncher.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

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