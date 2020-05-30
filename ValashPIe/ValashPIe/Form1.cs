using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ValashPIe
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Thread t = new Thread(new ThreadStart(Loading));
            t.Start();
            InitializeComponent();
            Thread.Sleep(10000);
            t.Abort();
        }
        
        public void Loading() 
        {
            Application.Run(new FormLoad());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
