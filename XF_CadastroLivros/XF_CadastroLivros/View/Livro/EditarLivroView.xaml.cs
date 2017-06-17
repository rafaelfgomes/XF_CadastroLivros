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
    public partial class EditarLivroView : ContentPage
    {

        LivroViewModel vmLivro;

        public EditarLivroView()
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

        private void OnEditarUmLivro(object sender, ItemTappedEventArgs args)
        {

            var selecionado = args.Item as Model.Livro;

            Navigation.PushAsync(new EditarLivro(selecionado.Id, selecionado.NomeDoLivro, selecionado.NomeDoAutorLivro, selecionado.EmailDoAutor, selecionado.ISBN));

        }

    }

}