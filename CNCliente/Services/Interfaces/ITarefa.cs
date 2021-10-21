using CNCliente.Models;
using System.Collections.Generic;

namespace CNCliente.Services.Interfaces
{
    public interface ITarefa
    {
        public IEnumerable<tarefa> GetAllRecords();
        public tarefa GetTaskData(int id);
        public void AddTask(tarefa tarefa);
        public void UpdateTask(tarefa tarefa);
        public void DeleteTask(int id);
    }
}
