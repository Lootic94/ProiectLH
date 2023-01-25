using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCSharp
{
    internal class FileReader
    {
        public List<Aircraft> ReadFile()
        {
            List<Aircraft> aircrafts = new List<Aircraft>();
            string[] result = new string[2];
            string path = "C:\\Users\\horat\\OneDrive\\Desktop\\ProiectLH\\ProjectCSharp\\ProjectCSharp\\Aircraft.txt";
            string[] separator = { ", " };
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        if (result[1] == "PrivateJet")
                        {
                            aircrafts.Add(new PrivateJet(result[0]));
                        }
                        else if (result[1] == "Liner")
                        {
                            aircrafts.Add(new Liner(result[0]));
                        }
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("File does not exist !");
            }
            return aircrafts;
        }
    }
}
