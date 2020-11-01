using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSctructures_SortingAlgorithms.Classes
{
    public class Insertion_Sort : SortPanel
    {
		private Form myForm;
		public Insertion_Sort(Form form, int w, int h) : base(" Insertion Sort", w, h)
		{	
			
			this.myForm = form;
		}
		public override void Run()
        {
			try
			{
				for (int i = 1; i < array.Length; i++)
				{
					greenColumn = i;
					redColumn = greenColumn;
					int k;
					for (k = i - 1; k >= 0 && array[k] > array[k + 1]; k--)
					{
						Thread.Sleep(3 * sleepTime);
						//repaint
						myForm.Refresh();
						redColumn = k + 1;
						//repaint
						myForm.Refresh();
						Thread.Sleep(4 * sleepTime);
						int tmp = array[k + 1];
						array[k + 1] = array[k];
						array[k] = tmp;
					}
					redColumn = k + 1;
					//repaint					
					myForm.Refresh();
				}
				redColumn = -1;
			}
			catch (Exception e)
			{
				Console.WriteLine("Exception: "+ e.Message);
			}
			myForm.Refresh();
		}

		
	}
}
