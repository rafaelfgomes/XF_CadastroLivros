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
    public partial class EditarLivro : ContentPage
    {

        LivroViewModel vmLivro;
        int idLivro;

        public EditarLivro()
        {

            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;

            InitializeComponent();

        }

        public EditarLivro(int id, string nomeLivro, string nomeAutor, string emailAutor, string ISBN)
        {
            
            InitializeComponent();

            idLivro = id;
            txtNomeLivro.Text = nomeLivro;
            txtNomeAutorLivro.Text = nomeAutor;
            txtEmailDoAutor.Text = emailAutor;
            txtISBN.Text = ISBN;

        }

        protected override void OnAppearing()
        {

            vmLivro = new LivroViewModel();
            BindingContext = vmLivro;

            base.OnAppearing();

        }

        private void OnEditar(object sender, EventArgs args)
        {

            Model.Livro livro = new Model.Livro()
            {

                Id = idLivro,
                NomeDoLivro = txtNomeLivro.Text,
                NomeDoAutorLivro = txtNomeAutorLivro.Text,
                EmailDoAutor = txtEmailDoAutor.Text,
                ISBN = txtISBN.Text

            };

            Limpar();

            App.LivroModel.CadastrarLivro(livro);

            DisplayAlert("", "Livro editado com sucesso!!!", "OK");

            Navigation.PopAsync();

        }

        public void OnCancelar()
        {

            Limpar();
            Navigation.PopAsync();

        }

        private void Limpar()
        {

            txtNomeLivro.Text = txtNomeAutorLivro.Text = txtEmailDoAutor.Text = txtISBN.Text = string.Empty;

        }

    }

}