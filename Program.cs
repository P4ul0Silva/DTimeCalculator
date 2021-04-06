using System;

namespace DTimeCalculator
{
    class DTC
    {

        static void Main(String[] args)
        {
            
            
            
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("//                                                                                      //");
            Console.WriteLine("//       DDDDDD                TTTTTTTTTTTTTTT              CCCCCC                      //");
            Console.WriteLine("//       DD    DD                    TT                   CC                            //");  
            Console.WriteLine("//       DD     DD                   TT                   CC                            //");
            Console.WriteLine("//       DD     DD                   TT                   CC                            //");
            Console.WriteLine("//       DD    DD                    TT                   CC                            //");
            Console.WriteLine("//       DDDDDD    Download          TT   Time              CCCCCC  Calculator          //");
            Console.WriteLine("//                                                                            P4uloSilva//");
            Console.WriteLine("//////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Bem Vindo à Calculadora de Download DTC \nCalcule quanto tempo vai durar o seu Download:\n ");
            Console.WriteLine("Pressione 1 para Começar a Calcular ou X para Sair");
            string opcao = Console.ReadLine();
            while (opcao == "1")
            {
            Console.WriteLine(" 1: Velocidade da sua Conexão(somente números): ...\n\n\nOu pressione Enter para fechar o programa.");     
            double downspeed = double.Parse(Console.ReadLine());
            Console.WriteLine("\nAgora o tamanho do Download em MB\nExemplo:\n     10, 999, 5000, 10500...\n");
            Console.WriteLine("     |MB     |GB            ");
            double downsize = double.Parse(Console.ReadLine());
            double Dtime = downsize / (downspeed/8);
            DateTime agora = DateTime.Now;
            DateTime agora2 = agora.AddSeconds(Dtime);
            TimeSpan interval = agora - agora2;
            Console.WriteLine($" ");
            Console.WriteLine($"\nComeçando exatamente agora {DateTime.Now}...\nO seu Download de {downsize}MB, à uma velocidade de {downspeed}Mb/s com duração de: {interval.ToString()}\nIrá terminar às {agora2}\n\n\n");

        

            }

            
            

            
            if (opcao == "x"){
                Console.WriteLine("Obrigado por usar meu programa! ;)\n                                   P4ul0Silva");
            }

            
        
            
            
            
           
        

            

        }

    }
}
