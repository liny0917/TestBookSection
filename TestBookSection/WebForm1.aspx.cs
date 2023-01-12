using Magnum.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TestBooSectionkModule;


namespace TestBookSection
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		
		TestBook  tb;
		protected void Page_Load(object sender, EventArgs e)
		{
			
		}	

		protected void BtnOpen_Click(object sender, EventArgs e)
		{
			string path = AppDomain.CurrentDomain.BaseDirectory + this.FileUpload1.FileName;
	
			this.FileUpload1.SaveAs(path);
			if (System.IO.File.Exists(path))
			{
				tb = new TestBook(path);		

			}
			//OpenFileDialog dialog = new OpenFileDialog();
			//dialog.Title = "Select txt file";
			//dialog.Filter = "text files |*.txt";
			//if (dialog.ShowDialog() != DialogResult.OK)
			//{
			//	return;
			//}

			//this.tb = new TestBook(dialog.FileName);

		}

		

		//private void OpenFile()
		//{
		//	OpenFileDialog dialog = new OpenFileDialog();
		//	dialog.Title = "Select txt file";
		//	dialog.Filter = "text files |*.txt";
		//	dialog.Multiselect = true;
		//	dialog.ShowDialog();
		//	if (dialog.ShowDialog() != DialogResult.OK)
		//	{
		//		return;
		//	}

		//	this.tb. = new TestBook(dialog.FileName);


		

		protected void BtnView_Click(object sender, EventArgs e)
		{
			int.TryParse(txtIndex.Text.Trim(), out int pageIndex);
			int.TryParse(txtSize.Text.Trim(), out int pageSize);

			pageSize = pageSize <= 0 ? 1 : pageSize;

			
			txtContent.Text = this.tb.GetPage(pageIndex, pageSize);
			
		}
	}
}