using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DataSctructures_SortingAlgorithms.Classes
{
    public class Quick_Sort : SortPanel
    {
		
		private Form myForm;
        public Quick_Sort(Form form, int w, int h) : base(" Quick Sort", w, h)
        {
            this.Initialize_Array();
            this.myForm = form;
        }
        //TODO for Final Project 2 (Final Evaluation)
        public override void Run()
        {

        }

    }
}
