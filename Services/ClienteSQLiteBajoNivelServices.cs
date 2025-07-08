using Progreso3_Huertas.Interfaces;
using Progreso3_Huertas.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progreso3_Huertas.Services
{
    class ClienteSQLiteBajoNivelServices : IClientesService
    {
        string _dbPath = FileSystem.AppDataDirectory+"/cliente.db3";
        SQLiteAsyncConnection _sqlConnection;

        public async void Init()
        {
            _sqlConnection = new SQLiteAsyncConnection(_dbPath);
            _sqlConnection.CreateTableAsync<Cliente>();
        }

        public ClienteSQLiteBajoNivelServices()
        {
            Init();
        }
        public Task<bool> AntiguedadEmpresaCliente(int AntiguedadMeses)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> DevuelveListadoCliente()
        {
            try
            {
                var clientes = _sqlConnection.Table<Cliente>().ToListAsync();
                return clientes;
            }
            catch
            {
                throw;
            }
        }


        public Task<bool> InsertarCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }
        public Task<bool> EliminarCliente(int id)
        {
            throw new NotImplementedException();
        }

        
    }
}
