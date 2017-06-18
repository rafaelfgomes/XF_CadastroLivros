using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_CadastroLivros.ViewModel;

namespace XF_CadastroLivros.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExcluirLivroView : ContentPage
    {

        LivroViewModel vmLivro;

        public ExcluirLivroView()
        {

            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;

            InitializeComponent();

        }

        protected override void OnAppearing()
        {

            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;

            base.OnAppearing();

        }

        async void OnLivroExcluirTapped(object sender, ItemTappedEventArgs args)
        {

            var selecionado = args.Item as Model.Livro;

            var escolha = await DisplayAlert("Excluir", "Deseja excluir?", "Sim", "Não");

            if (escolha)
            {

                App.LivroModel.RemoverLivro(selecionado.Id);

                await DisplayAlert("Excluido", "Livro excluído com sucesso!!!", "OK");

                OnAppearing();

            }

        }

    }

}