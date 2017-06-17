using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF_CadastroLivros.Dados;
using SQLite;

namespace XF_CadastroLivros.Model
{
    public class Livro
    {

        public Livro()
        {

            database = DependencyService.Get<ISQlite>().GetConexao();
            database.CreateTable<Livro>();

        }

        #region Propriedades
        
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NomeDoLivro { get; set; }
        public string NomeDoAutorLivro { get; set; }
        public string EmailDoAutor { get; set; }
        public string ISBN { get; set; }

        #endregion

        #region Database local

        private SQLiteConnection database;
        static object locker = new object();

        public int CadastrarLivro(Livro livro)
        {

            lock(locker)
            {

                if (livro.Id != 0)
                {

                    database.Update(livro);
                    return livro.Id;

                }
                else
                {

                    return database.Insert(livro);

                }

            }

        }

        public IEnumerable<Livro> MostrarLivros()
        {

            lock(locker)
            {

                return (from c in database.Table<Livro>() select c).ToList();

            }

        }

        public Livro MostrarLivro(int Id)
        {

            lock (locker)
            {

                return database.Table<Livro>().Where(c => c.Id == Id).FirstOrDefault();

            }

        }

        public int RemoverLivro(int Id)
        {

            lock (locker)
            {

                return database.Delete<Livro>(Id);

            }

        }

        #endregion

    }

}