using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bolnica.ServiceInterface
{
    interface IIsRoomFree
    {
        bool IsRoomFreeRenovations(DateTime newStartTime, DateTime newEndTime, int RoomId);
        bool IsRoomFreeExaminations(DateTime newStartTime, DateTime newEndTime, int id);
    }
}
