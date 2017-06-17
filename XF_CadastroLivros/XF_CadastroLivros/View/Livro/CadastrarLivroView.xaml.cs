using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_CadastroLivros.View.Livro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastrarLivroView : ContentPage
    {

        private int livroId = 0;

        public CadastrarLivroView()
        {

            InitializeComponent();

        }

        public CadastrarLivroView(int id)
        {

            InitializeComponent();

            var livro = App.LivroModel.MostrarLivro(id);

            txtNomeLivro.Text = livro.NomeDoLivro;
            txtNomeAutorLivro.Text = livro.NomeDoAutorLivro;
            txtEmailDoAutor.Text = livro.EmailDoAutor;
            txtISBN.Text = livro.ISBN;
            livroId = livro.Id;

        }

        public void OnSalvar(object sender, EventArgs args)
        {

            Model.Livro livro = new Model.Livro()
            {

                NomeDoLivro = txtNomeLivro.Text,
                NomeDoAutorLivro = txtNomeAutorLivro.Text,
                EmailDoAutor = txtEmailDoAutor.Text,
                ISBN = txtISBN.Text

            };

            Limpar();

            App.LivroModel.CadastrarLivro(livro);

            DisplayAlert("", "Livro cadastrado com sucesso!!!", "OK");

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