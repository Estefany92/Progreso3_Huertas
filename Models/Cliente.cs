using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progreso3_Huertas.Models
{
    [Table ("Clientes")]
    class Cliente
    {
        [PrimaryKey]
        public int Id { get; set; }
        [MaxLength(100), NotNull]
        public string Nombre { get; set; }
        [MaxLength(100), NotNull]
        public string Empresa { get; set; }
        [MaxLength(100), NotNull]
        public int AntiguedadMeses { get; set; }
        public bool Activo { get; set; }
    }
}
