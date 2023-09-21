using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace BasicQueuingContinuation
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(update);
            timer.Start();
        }
        private void update(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                label2.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                label2.Text = "No customer.";
            }
        }
    }
}
