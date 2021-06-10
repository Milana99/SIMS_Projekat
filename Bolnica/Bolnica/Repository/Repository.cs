using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bolnica.Repository
{
    public abstract class Repository<T>
    {

        public string FileLocation { get; set; }

        public Repository(String fileLocation)
        {
            FileLocation = fileLocation;
        }
        public abstract T addOne(string[] words);
        public abstract String getOne(T element);
        public List<T> Load()
        {
            List<T> list = new List<T>();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    string[] words = line.Split(',');
                    list.Add(addOne(words));
                }
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            return list;
        }

        public void Save(List<T> list)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (T element in list)
            {
                lines.Add(getOne(element));
            }
            File.WriteAllLines(FileLocation, lines);
        }

        public void Delete()
        {
            File.Delete(FileLocation);
        }

    }
}
