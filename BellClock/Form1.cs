using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace BellClock
{
    public partial class Form1 : Form
    {
        static JArray jarray = new JArray();
        public void WriteBellData_ToList()
        {
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("./user_data/database_bell.json");
            string temp = sr.ReadToEnd();
            jarray = JArray.Parse(temp);
            foreach (JObject x in jarray)
            {
                string hour = x.GetValue("hour").ToString();
                string minute = x.GetValue("minute").ToString();
                listBox1.Items.Add(String.Format("{0}:{1}", hour, minute));
            }
            sr.Close();
        }

        public void RemoveBellData()
        {

        }

        public void ClearBellData()
        {
            listBox1.Items.Clear();
        }

        public Form1()
        {
            InitializeComponent();
            WriteBellData_ToList();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Clock code ->

            timeNow.Text = System.DateTime.Now.ToString("HH:mm:ss");
            dateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");

            //Code for playing the bell ->

            foreach(JObject obj in jarray)
            {
                int i=0;
                int[] arr = new int[6];
                foreach (int x in obj.GetValue("days"))
                {
                    if(x==1)
                    {
                        int t = (int)Enum.Parse(typeof(DayOfWeek), DateTime.Now.DayOfWeek.ToString());
                    }
                }

            }
        }

        private void testBTN_Click(object sender, EventArgs e)
        {

            int[] arr = new int[6];

            foreach (var x in checkedListBox1.CheckedIndices)
            {
                int temp = (int)x;
                arr[temp] = 1;
            }

            JArray array = new JArray();
            foreach (int x in arr)
            {
                array.Add(x);
            }

            JObject newBell = new JObject();
            //newBell.Add("id", listBox1.Items.Count);
            newBell.Add("hour", dateTimePicker1.Value.Hour.ToString("D2"));
            newBell.Add("minute", dateTimePicker1.Value.Minute.ToString("D2"));
            newBell.Add("days", array);

            Data_Manipulation.Write_JObject_Data_ToFile(newBell);
            WriteBellData_ToList();

            //MessageBox.Show(newRing);
            //WriteBellData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearBellData();
            File.WriteAllText("./user_data/database_bell.json", "[]");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Delete selected register
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string path = "./user_data/database_bell.json";
            StreamReader sr = new StreamReader(path);
            string temp = sr.ReadToEnd();
            JArray jarray = JArray.Parse(temp);
            //MessageBox.Show(jarray.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JObject jobj = new JObject();
            jobj.Add("id", "vitaly");
            Data_Manipulation.Write_JObject_Data_ToFile(jobj);
            //WriteBellData_ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            place_holder_bell_lable.Visible = false;
            listBox2.Visible = true;
            listBox2.Items.Clear();
            int[] arr = new int[6];
            JObject temp = (JObject)jarray.ElementAt(index);
            int i = 0;
            foreach(int x in temp.GetValue("days"))
            {
                if(x!=0)
                {
                    listBox2.Items.Add(Enum.Parse(typeof(Data_Manipulation.DaysOfWeek), i.ToString()));
                    i++;
                }
                
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = "./user_data/sound/pewpewmp3.mp3";
            wplayer.controls.play();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            
            MessageBox.Show(i.ToString());
        }
    }
}
