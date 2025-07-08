using Progreso3_Huertas.Models;
using Progreso3_Huertas.Services;

namespace Progreso3_Huertas
{
    public partial class MainPage : ContentPage
    {
        ClienteSQLiteBajoNivelServices _sqliteService;

        public MainPage()
        {
            InitializeComponent();
            _sqliteService = new ClienteSQLiteBajoNivelServices();  
        }

        

        private void GuardarCliente_Clicked(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                Nombre = Nombre.Text,
                Empresa = Empresa.Text,
                AntiguedadMeses = AntiguedadMeses.Text,
                Activo = Activo.Text

            };
            var guardar = _sqliteService.InsertarCliente(cliente);
            if (guardar)
            {
                var cliente
            }

        }

    }
