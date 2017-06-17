using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF_CadastroLivros.Dados
{
    public interface ISQlite
    {
        SQLiteConnection GetConexao();

    }

}
