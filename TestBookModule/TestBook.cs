using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBooSectionkModule
{
	public class TestBook
	{
		private string[] paragraphs;

		public TestBook(string fileName)
		{
			var content = System.IO.File.ReadAllText(fileName);
			
			this.paragraphs = content.Split('\n');
		
		}

		public string GetPage(int pageIndex, int pageSize = 1)
		{
			int beginIndex = pageIndex * pageSize; // 0,2 =>0~1; 1,2=> 2~3

			beginIndex = beginIndex < 0 ? 0 : beginIndex;
			beginIndex = beginIndex >= this.paragraphs.Length ? paragraphs.Length - 1 : beginIndex;

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
