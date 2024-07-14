namespace aos2_launcher
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.ButtonSetVersion = new System.Windows.Forms.Button();
			this.ComboBoxVersionSelect = new System.Windows.Forms.ComboBox();
			this.ButtonAbout = new System.Windows.Forms.Button();
			this.ButtonPlay = new System.Windows.Forms.Button();
			this.LabelCurrentVersion = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LabelCurrentVersion);
			this.groupBox1.Controls.Add(this.Label1);
			this.groupBox1.Controls.Add(this.ButtonSetVersion);
			this.groupBox1.Controls.Add(this.ComboBoxVersionSelect);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(172, 70);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Version Selection";
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(7, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(44, 13);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "Current:";
			// 
			// ButtonSetVersion
			// 
			this.ButtonSetVersion.Location = new System.Drawing.Point(91, 41);
			this.ButtonSetVersion.Name = "ButtonSetVersion";
			this.ButtonSetVersion.Size = new System.Drawing.Size(75, 23);
			this.ButtonSetVersion.TabIndex = 2;
			this.ButtonSetVersion.Text = "Set Version";
			this.ButtonSetVersion.UseVisualStyleBackColor = true;
			this.ButtonSetVersion.Click += new System.EventHandler(this.ButtonSetVersion_Click);
			// 
			// ComboBoxVersionSelect
			// 
			this.ComboBoxVersionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxVersionSelect.FormattingEnabled = true;
			this.ComboBoxVersionSelect.Location = new System.Drawing.Point(6, 42);
			this.ComboBoxVersionSelect.Name = "ComboBoxVersionSelect";
			this.ComboBoxVersionSelect.Size = new System.Drawing.Size(74, 21);
			this.ComboBoxVersionSelect.TabIndex = 0;
			this.ComboBoxVersionSelect.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVersionSelect_SelectedIndexChanged);
			// 
			// ButtonAbout
			// 
			this.ButtonAbout.Location = new System.Drawing.Point(12, 88);
			this.ButtonAbout.Name = "ButtonAbout";
			this.ButtonAbout.Size = new System.Drawing.Size(81, 23);
			this.ButtonAbout.TabIndex = 1;
			this.ButtonAbout.Text = "About";
			this.ButtonAbout.UseVisualStyleBackColor = true;
			this.ButtonAbout.Click += new System.EventHandler(this.ButtonAbout_Click);
			// 
			// ButtonPlay
			// 
			this.ButtonPlay.Location = new System.Drawing.Point(103, 88);
			this.ButtonPlay.Name = "ButtonPlay";
			this.ButtonPlay.Size = new System.Drawing.Size(81, 23);
			this.ButtonPlay.TabIndex = 2;
			this.ButtonPlay.Text = "Play";
			this.ButtonPlay.UseVisualStyleBackColor = true;
			this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
			// 
			// LabelCurrentVersion
			// 
			this.LabelCurrentVersion.AutoSize = true;
			this.LabelCurrentVersion.Location = new System.Drawing.Point(49, 20);
			this.LabelCurrentVersion.Name = "LabelCurrentVersion";
			this.LabelCurrentVersion.Size = new System.Drawing.Size(31, 13);
			this.LabelCurrentVersion.TabIndex = 4;
			this.LabelCurrentVersion.Text = "0.0.0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 122);
			this.Controls.Add(this.ButtonPlay);
			this.Controls.Add(this.ButtonAbout);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "AOS2 Version Selector";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button ButtonSetVersion;
		private System.Windows.Forms.ComboBox ComboBoxVersionSelect;
		private System.Windows.Forms.Button ButtonAbout;
		private System.Windows.Forms.Button ButtonPlay;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label LabelCurrentVersion;
	}
}

