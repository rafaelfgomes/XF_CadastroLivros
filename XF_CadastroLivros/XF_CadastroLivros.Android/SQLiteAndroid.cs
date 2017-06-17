using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XF_CadastroLivros.Dados;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(XF_CadastroLivros.Droid.SQLiteAndroid))]
namespace XF_CadastroLivros.Droid
{
    public class SQLiteAndroid : ISQlite
    {

        public SQLiteAndroid() { }

        public SQLiteConnection GetConexao()
        {

            var arquivodb = "livros.db3";

            string caminho = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);

            var local = Path.Combine(caminho, arquivodb);

            var conexao = new SQLiteConnection(local);

            return conexao;

        }

    }

}