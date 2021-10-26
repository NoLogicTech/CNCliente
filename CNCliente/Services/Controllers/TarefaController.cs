using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using CNCliente.Models;

namespace CNCliente.Services
{
    public class TarefaService:ITarefaService
    {
        private readonly HttpClient httpClient;

        public TarefaService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<tarefa>> Get()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<tarefa>>("/api/tarefa");
        }
        public async Task<tarefa> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<tarefa>($"/api/tarefa/{id}");
        }
        public async Task Add(tarefa element)
        {
            throw new NotImplementedException();
        }
        public async Task Update(tarefa request)
        {
            throw new NotImplementedException();
        }
        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}