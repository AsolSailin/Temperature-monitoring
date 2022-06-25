using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_monitoring
{
    class Temperature
    {
        public List<int> temp;

        public Temperature()
        {
            temp = new List<int>();
        }
        public void Add(int t)
        {
            temp.Add(t);
        }
        public void Load(string path)
        {
            StreamReader stream = null;
            try
            {

            }
            catch
            {

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

            }
            catch
            {

            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }
    }
}
