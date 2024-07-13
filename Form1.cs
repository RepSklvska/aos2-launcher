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

		}
	}
}
