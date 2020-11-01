using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DataSctructures_SortingAlgorithms.Classes
{
    class Selection_Sort : SortPanel
    {
		

		private Form myForm;
        public Selection_Sort(Form form, int w, int h) : base(" Selection Sort", w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)
        public override void Run()
        {
			try
			{
				for (int i = 0; i < array.Length - 1; i++)
				{
					int currentMinIndex = i;
					redColumn = currentMinIndex;
					for (int j = i + 1; j < array.Length; j++)
					{
						
						//repaint
						myForm.Refresh();
						Thread.Sleep(4 * sleepTime);
						if (array[currentMinIndex] > array[j])
						{
							currentMinIndex = j;
							redColumn = currentMinIndex;
							//repaint
							myForm.Refresh();
						}
					}

					if (currentMinIndex != i)
					{
						int tmp = array[currentMinIndex];
						array[currentMinIndex] = array[i];
						array[i] = tmp;
						//repaint
						Thread.Sleep(4 * sleepTime);
					}
					greenColumn++;
					myForm.Refresh();
				}
				greenColumn++;
				redColumn = -1;
				
			}
			catch ( Exception e)
			{
			}
			//repaint();
			myForm.Refresh();
		}
    }
}
