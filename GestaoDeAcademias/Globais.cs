using System;

namespace GestaoDeAcademias
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;  //1=BÁSICO - 2= GERENTE - 3=MANUTENÇÃO
        public static DateTime data = DateTime.Today;
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "BaseGestaoDeAcademias.db";
        public static string caminhoBanco = caminho+@"\Banco\";
        public static string caminhoFoto = caminho + @"\Fotos\";
    }
}
