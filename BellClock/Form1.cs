using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeNow.Text = System.DateTime.Now.ToString("HH:mm:ss");
            dateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            /*if (dateTimePicker1.Value == DateTime.Now.ToString("ss"))
            {
                System.Media.SystemSounds.Exclamation.Play();
            }*/
        }

        private void testBTN_Click(object sender, EventArgs e)
        {
            string newRing = "\"H:\"" + hourSelect.Value.ToString() + "\"M:\"" + minSelect.Value.ToString();

            foreach(var x in checkedListBox1.CheckedItems)
            {
                int i = (int)daysOfWeekEnum.DayOfWeek.יום_ראשון;
                MessageBox.Show(i.ToString());
                newRing += x.ToString();
            }
            
        }
    }
}
