using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static List<TASKSTATE> GetTaskStates()
        {
            return db.TASKSTATEs.ToList();
        }

        public static void AddTask(TASK task)
        {
            try
            {
                db.TASKs.InsertOnSubmit(task);
                db.SubmitChanges();  
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static List<TaskDetailDTO> GetTasks()
        {
            List<TaskDetailDTO> taskList = new List<TaskDetailDTO>();  

                var list=(from t in db.TASKs
                          join s in db.TASKSTATEs on t.TaskState equals s.ID
                          join e in db.EMPLOYEEs on t.EmployeeID equals e.ID
                          join d in db.DEPARTMENTs on e.DepartmentID equals d.ID
                          join p in db.POSITIONs on e.PositionID equals p.ID
                          select new
                          {
                              taskID = t.ID,
                              title = t.TaskTitle,
                              content = t.TaskContent,
                              startdate = t.TaskStartDate,
                              deliveryDate = t.TaskEndDate,
                              taskStateName = s.StateName,
                              taskStateID = t.TaskState,
                              Username = e.Username,
                              Name = e.Name,
                              EmployeeID = t.EmployeeID,
                              LastName = e.LastName,
                              positionName = p.PositionName,
                              departmentName = d.DepartmentName,
                              positionID = e.PositionID,
                              departmentID = e.DepartmentID

                              
                          }).OrderBy(x => x.startdate).ToList();
            foreach (var item in list)
            {
                TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskStartDate = item.startdate;
                dto.TaskDeliveryDate = item.deliveryDate;
                dto.StateName = item.taskStateName;
                dto.TaskStateID = item.taskStateID;
                dto.Username = item.Username;
                dto.Name = item.Name;
                dto.LastName = item.LastName;
                dto.DepartmentName = item.departmentName;
                dto.PositionID = item.positionID;
                dto.PositionName = item.positionName;
                dto.EmployeeID = item.EmployeeID;
                taskList.Add(dto);
            }
            return taskList;
        }
    }
}
