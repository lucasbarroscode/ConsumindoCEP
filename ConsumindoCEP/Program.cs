using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoCEP
{
    using CEPService;
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Informe o CEP que deseja buscar: ");
            var cep = Console.ReadLine();


            if (!string.IsNullOrEmpty(cep))
            {
                ConsultaCep(cep);
            }

        }
        private static void ConsultaCep(string cep)
        {
            using (var ws = new AtendeClienteClient())
            {
                var resposta = ws.consultaCEP(cep);

                Console.Clear();
                Console.WriteLine(String.Format("Endereço : {0}", resposta.end));
                Console.WriteLine(String.Format("Bairro : {0}", resposta.bairro));
                Console.WriteLine(String.Format("Cidade : {0}", resposta.cidade));
                Console.WriteLine(String.Format("UF : {0}", resposta.uf));
                Console.WriteLine(String.Format("CEP : {0}", resposta.cep));
                Console.WriteLine("");
                


                InfoCEPs infoceps = new InfoCEPs();
                InfoCEP infocep = new InfoCEP();

               // infocep.CepId = resposta.cep;
                infocep.Endereco = resposta.end;
                infocep.Bairro = resposta.bairro;
                infocep.Cidade = resposta.cidade;
                infocep.UF = resposta.uf;
                infocep.Cep = resposta.cep;

                infoceps.InfoCEP.Add(infocep);

                infoceps.SaveChanges();


                Console.WriteLine("Exibindo cadastros inseridos no banco de dados SQL Server");
                foreach (var valores in infoceps.InfoCEP)
                {
                  Console.WriteLine(valores.Cep.ToString() + " - " + valores.Endereco.ToString() + " - " + valores.Bairro.ToString() + " - " + valores.Cidade.ToString() + " - " + valores.UF.ToString());
                }
                Console.WriteLine("Pressione qualquer tecla para finalizar");
                Console.ReadKey();


            }
        }
    }
}
