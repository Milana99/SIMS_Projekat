using System;
using System.Collections.Generic;
using System.IO;

namespace Bolnica.Repository
{
   public class ExaminationRepository
   {
        private String FileLocation { get; set; }
        public int next_id;

        public ExaminationRepository(String newFileLocation)
        {
            FileLocation = newFileLocation;
        }

        public List<Model.Examination> LoadExamination()
        {
            List<Model.Examination> examinations = new List<Model.Examination>();
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

                    Model.Examination exam = new Model.Examination(int.Parse(words[0]), Convert.ToDateTime(words[1]),
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
      
      public void SaveExamination(List<Model.Examination> listExaminations)
      {
            File.Delete(FileLocation);
            String line;
            List<String> lines = new List<String>();

            foreach (Model.Examination ex in listExaminations)
            {
                if (ex.deleted == false)
                {
                    line = ex.ExaminationId.ToString() + "," + ex.StartTime.ToString() + "," + ex.EndTime.ToString() +
                       "," + ex.doctor.User.Username + "," + ex.patient.User.Username + "," + ex.room.RoomId;
                    lines.Add(line);
                }
            }
            File.WriteAllLines(FileLocation, lines);
        }
      
      public void DeleteExaminations()
      {
            File.Delete(FileLocation);
        }
   
     
   
   }
}