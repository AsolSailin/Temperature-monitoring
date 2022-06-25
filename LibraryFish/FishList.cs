using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_monitoring
{
    class FishList
    {
        public List<string> fish;

        public FishList()
        {
            fish = new List<string>();
        }
        public void Add(string f)
        {
            fish.Add(f);
        }
        public void Load(string path)
        {
            StreamReader stream = null;
            try
            {
                stream = new StreamReader(File.Open(path, FileMode.Open));

            }
            catch (Exception)
            {
                Console.WriteLine("Load Error!");
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }
        public void Save(string path)
        {
            StreamWriter stream = null;

            try
            {
                stream = new StreamWriter(File.Open(path, FileMode.Create));

                foreach (var f in fish)
                {
                    stream.WriteLine(f);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Save Error!");
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }
    }
}

