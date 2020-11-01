using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace DataSctructures_SortingAlgorithms.Classes
{
    class Bubble_Sort : SortPanel
    {
        private Form myForm;
        public Bubble_Sort(Form form, int w, int h) : base(" Bubble Sort", w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)
        public override void Run()
        {
			try
			{
				bool needNextPass = true;
				for (int k = 1; k < array.Length && needNextPass; k++)
				{
					needNextPass = false;
					for (int i = 0; i < array.Length - k; i++)
					{
						redColumn = i;
						//repaint
						myForm.Refresh();
						Thread.Sleep(4 * sleepTime);
						if (array[i] > array[i + 1])
						{
							redColumn = i + 1;
							int temp = array[i];
							array[i] = array[i + 1];
							array[i + 1] = temp;
							//repaint
							myForm.Refresh();
							Thread.Sleep(4 * sleepTime);
							needNextPass = true;
						}
					}
					greenColumn = size - k;
				}
				greenColumn = 0;
				redColumn = -1;
			}
			catch (Exception exception)
			{
			}
			//repaint
			myForm.Refresh();
		}
		//==================================================================
		public override void Draw(Graphics G)
		{
			if (greenColumn == -1)
			{
				for (int i = 0 ; i < array.Length; i++)
				{
					DrawColumn(G, Color.White, i);
				}
			}
			else
			{
				for (int i = 0; i < array.Length; i++)
				{
					DrawColumn(G, Color.Green, i);
				}
			}
			for (int i = 0; i <= greenColumn; i++)
			{
				DrawColumn(G, Color.White, i);
			}
			if (redColumn != -1)
			{
				DrawColumn(G, Color.Red, redColumn);
			}
		}
	}
}
