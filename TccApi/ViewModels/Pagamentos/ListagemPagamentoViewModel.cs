using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TccApi.Services.Pagamentos;
using TccApi.Models;
using TccApi.Services.Pagamentos;
using System.Collections.ObjectModel;

namespace TccApi.ViewModels.Pagamentos
{
    public class ListagemPagamentoViewModel : BaseViewModel
    {
        private PagamentoService pService;

        public ObservableCollection<Pagamento> Pagamentos { get; set; }

        public ListagemPagamentoViewModel()
        {
            string token = Preferences.Get("UsuarioToken", string.Empty);
            pService = new PagamentoService(token);
            Pagamentos = new ObservableCollection<Pagamento>();
        }
    }
}
