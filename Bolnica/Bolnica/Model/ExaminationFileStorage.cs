using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Globalization;

namespace Bolnica.Model
{
   public class ExaminationFileStorage
   {
        private String FileLocation { get; set; }
        public int next_id;

      public ExaminationFileStorage()
      {
            
      }

        public void Delete()
        {
            File.Delete(FileLocation);
        }

        public void Save(List<Examination> listExaminations)
        {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Examination ex in listExaminations)
            {
                if (ex.deleted == false)
                {
                    line = ex.ExaminationId.ToString() + "," + ex.StartTime.ToString() + "," + ex.EndTime.ToString() +
                       "," + ex.doctor.User.Username + "," + ex.patient.User.Username + "," + ex.room;
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);

        }

        public List<Examination> Load(String fileLocation)
        {
            FileLocation = fileLocation;
            List<Examination> examinations = new List<Examination>();
            examinations.Clear();
            try
            {
                String line;
                StreamReader sr = new StreamReader(FileLocation);

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    string[] words = line.Split(',');
                    Console.WriteLine(words[5]);
                    Console.WriteLine(words[4]);

                    Examination exam = new Examination(int.Parse(words[0]), Convert.ToDateTime(words[1]),
                        Convert.ToDateTime(words[2]), words[3], words[4], int.Parse(words[5]));
                    Console.WriteLine("NO");
                    examinations.Add(exam);
                    next_id = exam.ExaminationId;
                }
                next_id++;

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
            return examinations;
        }

    }
}