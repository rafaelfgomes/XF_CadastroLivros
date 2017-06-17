using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XF_CadastroLivros.Model;

namespace XF_CadastroLivros.ViewModel
{
    public class LivroViewModel
    {

        public LivroViewModel() { }

        #region Propriedades
        public int Id { get; set; }
        public string NomeDoLivro { get; set; }
        public string NomeDoAutorLivro { get; set; }
        public string EmailDoAutor { get; set; }
        public string ISBN { get; set; }

        public List<Livro> Livros
        {

            get
            {

                return App.LivroModel.MostrarLivros().ToList();

            }

        }

        #endregion

    }

}
