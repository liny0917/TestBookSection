using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WindowsFormsApp1
{
	public class Book
	{
		private string[] paragraphs;

		public Book(string fileName)
		{
			var content = System.IO.File.ReadAllText(fileName);
			this.paragraphs = content.Split('\n');
		}

		public string GetPage(int pageIndex, int pageSize=1)
		{
			int beginIndex = pageIndex * pageSize; // 0,2 =>0~1; 1,2=> 2~3
			
			beginIndex = beginIndex < 0 ? 0 : beginIndex;
			beginIndex = beginIndex >= this.paragraphs.Length ? paragraphs.Length-1 : beginIndex;

			int endIndex = beginIndex + pageSize - 1;
			endIndex = endIndex >= this.paragraphs.Length ? paragraphs.Length - 1 : endIndex;

			StringBuilder sb = new StringBuilder();
			for (int idx = beginIndex; idx <= endIndex; idx++)
			{
				sb.AppendLine(paragraphs[idx]);
			}

			return sb.ToString();
		}
	}
}