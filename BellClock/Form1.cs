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
using NAudio.Gui;
using WaveFormRendererLib;

namespace BellClock
{
    public partial class Form1 : Form
    {
        static JArray jarray = new JArray();
        static DayOfWeek dayofweek;
        static string SongToPlay = "default.mp3";
        public void WriteBellData_ToList()
        {
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader("./user_data/database_bell.json");
            string temp = sr.ReadToEnd();
            if(temp!="")
            { 
                jarray = JArray.Parse(temp); 
            }
            
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
            var filenames = from fullFilename
                in Directory.EnumerateFiles("./user_data/sound/")
                            select Path.GetFileName(fullFilename);
            foreach (string filename in filenames)
            {
                listBox3.Items.Add(filename);
            }
            WriteBellData_ToList();

            openFileDialog1.Title = "בחירת שיר מהמחשב";
            openFileDialog1.Filter = "mp3 Files (*.mp3)|*.mp3";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Clock code ->

            timeNow.Text = System.DateTime.Now.ToString("HH:mm");
            dateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");

            dayofweek = DateTime.Now.DayOfWeek;

            //MessageBox.Show("Inside tick");

            //Code for playing the bell ->
            
            foreach (JObject obj in jarray)
            {
                int i = 0;

                foreach (int x in obj.GetValue("days"))
                {
                    //MessageBox.Show("Day of week parsing: " + (int)Enum.Parse(typeof(DayOfWeek), DateTime.Now.DayOfWeek.ToString())
                    //    + " i: " + i + "\n x: " + x);
;                   if(x==1)
                    {
                        if(i == (int)Enum.Parse(typeof(DayOfWeek), DateTime.Now.DayOfWeek.ToString()))
                        {
                            //MessageBox.Show("Inside Days check");
                            if((int)obj.GetValue("hour")==DateTime.Now.Hour)
                            {
                                //MessageBox.Show("Inside hour check\n" + "The minute is: " + DateTime.Now.Minute.ToString()+"  " + (int)obj.GetValue("minute"));
                                if ((int)obj.GetValue("minute") == (int)DateTime.Now.Minute)
                                {
                                    //MessageBox.Show("Playing bell");
                                    WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                                    wplayer.URL = "./user_data/sound/" + SongToPlay;
                                    MessageBox.Show("./user_data/sound/" + SongToPlay);
                                    wplayer.controls.play();
                                }
                            }
                        }
                    }
                    i++;
                }
            }
        }

        private void testBTN_Click(object sender, EventArgs e)
        {

            int[] arr = new int[6];

            foreach (var x in checkedListBox1.CheckedIndices)
            {
                int temp = (int)x;
                //MessageBox.Show(temp.ToString());
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
            int IndexToDelete = listBox1.SelectedIndex;
            jarray.RemoveAt(IndexToDelete);
            string path = "./user_data/database_bell.json";
            StreamWriter sw = new StreamWriter(path);
            sw.Write(jarray.ToString(Newtonsoft.Json.Formatting.None));
            //MessageBox.Show(jarray.ToString());
            sw.Close();
            WriteBellData_ToList();

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
            if (listBox1.SelectedIndex >= 0)
            {
                int index = listBox1.SelectedIndex;
                place_holder_bell_lable.Visible = false;
                listBox2.Visible = true;
                listBox2.Items.Clear();
                int[] arr = new int[6];
                JObject temp = (JObject)jarray.ElementAt(index);
                int i = 0;
                foreach (int x in temp.GetValue("days"))
                {
                    if (x != 0)
                    {
                        listBox2.Items.Add(Enum.Parse(typeof(Data_Manipulation.DaysOfWeek), i.ToString()));    
                    }
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
            SongToPlay = listBox3.SelectedItem.ToString();
            MessageBox.Show("בחרת בצלצול" + SongToPlay);
        }

        private void SelectSong_button_Click(object sender, EventArgs e)
        {
            //openFileDialog1.ShowDialog();
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //listBox3.Items.Add(openFileDialog1.SafeFileName); //Addes the song to the list TODO: a function to call
            }

            var maxPeakProvider = new MaxPeakProvider();
            var rmsPeakProvider = new RmsPeakProvider(200); // e.g. 200
            var samplingPeakProvider = new SamplingPeakProvider(200); // e.g. 200
            var averagePeakProvider = new AveragePeakProvider(4); // e.g. 4

            var myRendererSettings = new StandardWaveFormRendererSettings();
            myRendererSettings.Width = 640;
            myRendererSettings.TopHeight = 32;
            myRendererSettings.BottomHeight = 32;
            myRendererSettings.BackgroundColor = Color.White;

            var renderer = new WaveFormRenderer();
            var audioFilePath = "./user_data/sound/" + openFileDialog1.SafeFileName;
            var image = renderer.Render(audioFilePath, myRendererSettings);
            pictureBox1.Image = image;

        }
    }
}
