using System
using  Cadastro.classes;
 
{
     public static void Main(string[]args)
    { 
      var Cadastro = new Cadastro();
        Cadastro.NomeLoja ="Orion"
        Cadastro.Quantidade = 1;
        Cadastro.Categoria ="Suspense"
    }

    Console.WriteLine("Atendimento realizado com sucesso");
    Console.ReadLine();
    }
}
