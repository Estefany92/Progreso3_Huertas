using Progreso3_Huertas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progreso3_Huertas.Interfaces
{
    interface IClientesService
    {
        public void Init();
        public Task<List<Cliente>> DevuelveListadoCliente();
        public Task<bool> InsertarCliente(Cliente cliente);
        public Task<bool> EliminarCliente(int id);


    }
}
