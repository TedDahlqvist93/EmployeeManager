using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL;

namespace BLL
{
    public class TaskBLL
    {
        public static TaskDTO GetAll()
        {
            TaskDTO taskDTO = new TaskDTO();
            taskDTO.Employees = EmployeeDAO.GetEmployees();
            taskDTO.Departments = DepartmentDAO.GetDepartments();
            taskDTO.Positions = PositionDAO.GetPositions();
            taskDTO.TaskStates = TaskDAO.GetTaskStates();
            taskDTO.Tasks = TaskDAO.GetTasks();
            return taskDTO;
        }

        public static void AddTask(TASK task)
        {
            TaskDAO.AddTask(task);
        }
    }
}
