using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_CadastroLivros.ViewModel;
using Xamarin.Forms.PlatformConfiguration;

namespace XF_CadastroLivros.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {

        public PaginaInicial()
        {
            
            InitializeComponent();

        }

        private void OnCadastrar(object sender, EventArgs args)
        {

            Navigation.PushAsync(new View.Livro.CadastrarLivroView());

        }

        private void OnMostrarTodos(object sender, EventArgs args)
        {

            Navigation.PushAsync(new TodosLivrosView());

        }

        private void OnEditar(object sender, EventArgs args)
        {

            Navigation.PushAsync(new EditarLivroView());

        }

        private void OnExcluir(object sender, EventArgs args)
        {

            Navigation.PushAsync(new ExcluirLivroView());

        }

    }

}