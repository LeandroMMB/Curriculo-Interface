using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currículo.Classes
{
    public class Cls_UsuarioLogado
    {
        public static string Usuario { get; private set; }
        public static string Senha { get; private set; }

        public Cls_UsuarioLogado(string usuario, string senha)
        {
            Usuario = usuario;
            Senha = senha;
        }
    }
}
