﻿using Progreso3_Huertas.Interfaces;
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
        string _dbPath = FileSystem.AppDataDirectory+"/Logs_Huertas.txt";
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
            int antiguedadDias = cliente.AntiguedadMeses * 10;
            if (antiguedadDias > 1500)
            {
                return false;
            }
            
            try
            {
                await _sqlConnection.InsertAsync(cliente);
                return true;
            }
            catch(Exception)
            {
                Console.WriteLine($"Error al insertar cliente");
                return false;
                
            }

        }
        public async Task<bool> EliminarCliente(int id)
        {
            try
            {
                await _sqlConnection.DeleteAsync(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
