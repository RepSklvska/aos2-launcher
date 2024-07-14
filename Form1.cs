using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace aos2_launcher
{
	public partial class Form1 : Form
	{
		public Repository repo = new Repository(@"C:\Users\a\Desktop\aos2-all-versions");
		public Dictionary<string, Branch> branches = new Dictionary<string, Branch>();
		public IList<string> versions = new List<string>();
		public string selectedVersion = "";
		public string currentVersion = "";
		public Form1()
		{
			versions.Add("1.6.2");
			versions.Add("1.6.3b");
			versions.Add("1.6.4");
			versions.Add("1.7.6");
			versions.Add("1.8.4");
			versions.Add("1.9");

			InitializeComponent();

			currentVersion = repo.Head.FriendlyName;
			selectedVersion = currentVersion;
			LabelCurrentVersion.Text = currentVersion;
			ComboBoxVersionSelect.DataSource = versions;
			ComboBoxVersionSelect.SelectedIndex = versions.IndexOf(currentVersion);
			ButtonSetVersion.Enabled = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Console.WriteLine(System.Environment.CurrentDirectory);
			foreach (var branch in repo.Branches)
			{
				Console.WriteLine("Branch: " + branch.FriendlyName);
				branches.Add(branch.FriendlyName, branch);
			};
			//Commands.Checkout(repo, branches["1.6.2"]);
		}

		private void ComboBoxVersionSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			ComboBox comboBox = (ComboBox)sender;
			selectedVersion = versions[comboBox.SelectedIndex];
			ButtonSetVersion.Enabled = selectedVersion != currentVersion;
		}

		private void ButtonSetVersion_Click(object sender, EventArgs e)
		{
			Console.WriteLine(selectedVersion);
			if (selectedVersion == currentVersion)
			{
				Console.WriteLine("??");
			}
			else
			{
				ButtonSetVersion.Enabled = false;
				Commands.Checkout(repo, branches[selectedVersion]);
				LabelCurrentVersion.Text = selectedVersion;
			}
		}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
			{
				WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C explorer steam://rungameid/390710"
			};
			process.StartInfo = startInfo;
			process.Start();

			this.Close();
		}

		private void ButtonAbout_Click(object sender, EventArgs e)
		{
			FormInfo formInfo = new FormInfo();
			formInfo.ShowDialog();
		}
	}
}
