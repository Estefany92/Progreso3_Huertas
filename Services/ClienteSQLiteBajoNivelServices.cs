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

            try
            {
                _sqlConnection.DeleteAsync(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Cliente>> DevuelveListadoCliente()
        {
            try
            {
                var clientes = await _sqlConnection.Table<Cliente>().ToListAsync();
                return clientes;
            }
            catch(Exception)
            {
                throw;
            }
        }


        public async  Task<bool> InsertarCliente(Cliente cliente)
        {
            try
            {
                _sqlConnection.InsertAsync(cliente);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public async Task<bool> EliminarCliente(int id)
        {
            try
            {
                _sqlConnection.DeleteAsync(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
