using System.Collections.Generic;
using System;
using Bolnica.Model;

namespace Bolnica.Service
{
    public class BasicRenovationService
    {
        public Repository.BasicRenovationRepository renovationRepository;
        public BasicRenovationService()
        {
            renovationRepository = new Repository.BasicRenovationRepository(@"C:\Users\pc\OneDrive\Radna površina\Radovan\Upravnik\Renovation.txt");
        }
        public BasicRenovation GetOneRenovation(int renovationId)
        {
            List<Model.BasicRenovation> renovations = GetAllRenovations();
            foreach(Model.BasicRenovation renovation in renovations)
            {
                if(renovation.RenovationId == renovationId)
                {
                    return renovation;
                }
            }
            return null;
        }

        public List<BasicRenovation> GetAllRenovations()
        {
            return renovationRepository.LoadRenovation();
        }

        public void CreateRenovation(BasicRenovation renovation)
        {
            List<Model.BasicRenovation> renovations = GetAllRenovations();
            renovations.Add(renovation);
            renovationRepository.SaveRenovation(renovations);
        }

        public void DeleteRenovation(int renovationId)
        {
            List<Model.BasicRenovation> renovations = GetAllRenovations();
            foreach(Model.BasicRenovation renovation in renovations)
            {
                if(renovation.RenovationId == renovationId)
                {
                    renovation.deleted = true;
                    renovationRepository.SaveRenovation(renovations);
                    return;
                }
            }
        }

        public void UpdateRenovation(BasicRenovation updatedRenovation)
        {
            List<Model.BasicRenovation> renovations = GetAllRenovations();
            foreach (Model.BasicRenovation renovation in renovations)
            {
                if(renovation.RenovationId == updatedRenovation.RenovationId)
                {
                    renovation.RenovationDescription = updatedRenovation.RenovationDescription;
                    renovation.StartTime = updatedRenovation.StartTime;
                    renovation.EndTime = updatedRenovation.EndTime;
                    renovationRepository.SaveRenovation(renovations);
                    return;
                }
            }
        }

        public bool IsRoomFree(DateTime newStartTime, DateTime newEndTime, int RoomId)
        {
            if(isRoomFreeExaminations(newStartTime, newEndTime, RoomId) && isRoomFreeRenovations(newStartTime, newEndTime, RoomId))
            {
                return true;
            }
            return false;
        }

        public bool isRoomFreeRenovations(DateTime newStartTime, DateTime newEndTime, int RoomId)
        {
            List<Model.BasicRenovation> renovations = GetAllRenovations();
            foreach (BasicRenovation renovation in renovations)
            {
                int start1 = DateTime.Compare(renovation.StartTime, newStartTime);
                int start2 = DateTime.Compare(renovation.EndTime, newStartTime);
                int end1 = DateTime.Compare(renovation.StartTime, newEndTime);
                int end2 = DateTime.Compare(renovation.EndTime, newEndTime);

                if (((start1 <= 0 && start2 >= 0) || (end1 <= 0 && end2 >= 0) || (start1 >= 0 && end2 <= 0)) && (RoomId == renovation.room.RoomId))
                {
                    return false;
                }
            }
            return true;
        }

        public bool isRoomFreeExaminations(DateTime newStartTime, DateTime newEndTime, int RoomId)
        {
            Controller.ExaminationController examinationController = new Controller.ExaminationController();
            List<Model.Examination> examinations = examinationController.GetAllExaminations();
            foreach (Examination examination in examinations)
            {
                //if(((ex.StartTime<=newTime1) && (ex.EndTime>newTime1)) || ((ex.StartTime<newTime2)&&(ex.EndTime>=newTime2)))
                int start1 = DateTime.Compare(examination.StartTime, newStartTime);
                int start2 = DateTime.Compare(examination.EndTime, newStartTime);
                int end1 = DateTime.Compare(examination.StartTime, newEndTime);
                int end2 = DateTime.Compare(examination.EndTime, newEndTime);

                if (((start1 <= 0 && start2 >= 0) || (end1 <= 0 && end2 >= 0) || (start1 >= 0 && end2 <= 0))&&(RoomId==examination.room.RoomId))
                {
                    return false;
                }
            }
            return true;
        }


    }
}