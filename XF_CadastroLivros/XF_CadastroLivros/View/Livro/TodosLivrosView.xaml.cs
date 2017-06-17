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
    public partial class TodosLivrosView : ContentPage
    {

        LivroViewModel vmLivro;

        public TodosLivrosView()
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

        private void OnLivroTapped(object sender, ItemTappedEventArgs args)
        {

            var selecionado = args.Item as Model.Livro;
            DisplayAlert("Dados do livro", String.Format("Livro: {0}\nAutor: {1}\nEmail: {2}\nISBN: {3}", selecionado.NomeDoLivro, selecionado.NomeDoAutorLivro, selecionado.EmailDoAutor, selecionado.ISBN), "OK");

        }

    }

}