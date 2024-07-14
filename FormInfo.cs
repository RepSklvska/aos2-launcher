using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aos2_launcher
{
	public partial class FormInfo : Form
	{
		public FormInfo()
		{
			InitializeComponent();
			LinkLabelGithubRepo.Links.Add(0, LinkLabelGithubRepo.Text.Length, "https://github.com/RepSklvska/aos2-launcher");
			LinkLabelGithubPage.Links.Add(0, LinkLabelGithubPage.Text.Length, "https://repsklvska.github.io/");
			LinkLabelEmail.Links.Add(0, LinkLabelEmail.Text.Length, "mailto:bi1ebi@hotmail.com");
			LinkLabelSteam.Links.Add(0, LinkLabelSteam.Text.Length, "https://steamcommunity.com/id/gunpowderfans/");
		}

		private void ButtonOK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void LinkLabelGithubRepo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = e.Link.LinkData.ToString(),
				UseShellExecute = true
			});
		}

		private void LinkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = e.Link.LinkData.ToString(),
				UseShellExecute = true
			});
		}

		private void LinkLabelSteam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = e.Link.LinkData.ToString(),
				UseShellExecute = true
			});
		}

		private void LinkLabelGithubPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(new ProcessStartInfo
			{
				FileName = e.Link.LinkData.ToString(),
				UseShellExecute = true
			});
		}
	}
}
