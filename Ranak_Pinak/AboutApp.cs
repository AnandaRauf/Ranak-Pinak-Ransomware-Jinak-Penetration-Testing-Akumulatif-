using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.IO;
namespace Ranak_Pinak
{
	public partial class AboutApp : Form
	{
		public AboutApp()
		{
			InitializeComponent();
		}

		private void AboutApp_Load(object sender, EventArgs e)
		{
			
			var Url1 = "Website Retail Tech Source";
			var Url2 = "Alamat bisnis Retail Tech Source";
			lblUrl1.Text = Url1;
			lblUrl2.Text = Url2;
			lblCopyright.Text = "08 November 2021";
			lblVersion.Text = "Version" + this.GetType().Assembly.GetName().Version.ToString();
			label1.Text = "Retail Tech Source ialah situs serba ada sesuai kebutuhan anda,produk yang anda cari dijamin ada dan original langsung dari owner produk-nya. Dari E-commerce sampai Jasa profesional.";
		}

		private void btnOk_Click(object sender, EventArgs e)
		{
			
			var forms1 = new Form1();
			forms1.Show();
			this.Visible = false;
		}
		

		private void lblUrl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.retailtechsource.com/");
		}

		private void lblUrl2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("https://goo.gl/maps/KLbW5tU86kqERWMv5");
		}
	}

}

