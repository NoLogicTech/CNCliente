using CNCliente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CNCliente.Services
{
    public interface ITarefaService
    {
        Task<IEnumerable<tarefa>> Get();
        Task<tarefa> Get(int id);
        Task Update(tarefa request);
        Task Add(tarefa request);
        Task Delete(int id);
    }
}
