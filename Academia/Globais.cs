using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Academia
{
    class Globais
    {
        public static string versao = "1.0"; 
        public static Boolean logado = false;
        public static int nivel = 0;

        public static string caminhoDir = System.AppDomain.CurrentDomain.BaseDirectory.ToString(); 
        public static string nomeBD = "bd_academia.db";
        public static string caminhoBD = caminhoDir+ @"\banco de dados\";
        public static string caminhoFotos = caminhoDir + @"\Fotos\";


    }
}
