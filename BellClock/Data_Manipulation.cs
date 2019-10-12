using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellClock
{
    class Data_Manipulation
    {
        /// <summary>
        /// This method writes the data to the file as JSON Array!
        /// Accepts: JObject
        /// </summary>
        /// <param name="jobj">you need to make sure it is following the rules</param>
        public static void Write_JObject_Data_ToFile(JObject jobj)
        {

            string path = "./user_data/database_bell.json";
            StreamReader sr = new StreamReader(path);
            string temp = sr.ReadToEnd();
            sr.Close();
            JArray jarray = new JArray();
            jarray = JArray.Parse(temp);
            jarray.Add(jobj);
            StreamWriter sw = new StreamWriter(path);
            sw.Write(jarray.ToString(Newtonsoft.Json.Formatting.None));
            //MessageBox.Show(jarray.ToString());
            sw.Close();
        }

        public enum DaysOfWeek
        {
            ראשון=0,
            שני,
            שלישי,
            רביעי,
            חמישי,
            שישי
        }
    }
}
