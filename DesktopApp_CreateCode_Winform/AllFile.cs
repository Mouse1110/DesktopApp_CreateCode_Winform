using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemCustomFile
{
    class AllFile
    {
        string path = Environment.CurrentDirectory + "/" + "log.txt";
       
        public void writeFile(string txt)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(txt);
            }
        }
        public string readFile()
        {
            string txt = "";
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        txt += line;
                    }
                    return txt;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return "";
            }
        }
    }
    class OptionOTD
    {

        public String code;
        public String note;

        public OptionOTD(string value)
        {
            //value : {"code":"A","note":"dasd dasds"}
            //[{"code":"A","note":"Khung máy"},{"code":"B","note":"Bát kẹp"}]
            string[] arrValue = value.Split(':');

            code = arrValue[1].Split(',')[0].Substring(1, 1);
            note = arrValue[2].Substring(1, arrValue[2].Length - 3);
        }
    }
}
