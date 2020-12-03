using System;

namespace _Celular
{
    class Program
    {
        static void Main(string[] args)
        {

            //  Variáveis
            string power;
            string repetir;
            string acao;


            //  Instâncias
            Celular phone1 = new Celular();
            
            
            //  Início
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("---------VIVO-----TIM-----OI-----CLARO-----SAMSUNG--------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------");
            
            
            //  Cadastro
            Console.WriteLine("\n-------      CADASTRAR DISPOSITIVO");
            Console.Write("\n-------      Cor: ");
            phone1.color = Console.ReadLine();
            Console.Write("\n-------      Modelo: ");
            phone1.model = Console.ReadLine();
            Console.Write("\n-------      Tamanho: ");
            phone1.size = Console.ReadLine();

            
            //  Ligado ou Desligado
            Console.WriteLine("\n-------      O seu aparelho está Ligado? (S/N)");
            power = Console.ReadLine().ToUpper();
            
            if (power == "S" || power == "SIM" || power == "SI") {

                phone1.power = true; 

            } else if (power == "N" || power == "NÃO" || power == "NAO" || power == "NA "){

                phone1.power = false;

            }


            //  Ligar o Celular
            do
            {
                
                if (phone1.power == false)
                {
                    
                    Console.Write("-------      Deseja Ligar o Aparelho? (S/N) ");
                    power = Console.ReadLine().ToUpper();

                    if (power == "S" || power == "SIM" || power == "SI") {

                        phone1.Ligar();

                    }
                    else if (power == "N" || power == "NÃO" || power == "NAO" || power == "NA "){

                        phone1.Desligar();

                    }
                    
                }

            } while ( phone1.power == false);


            //  AÇÕES

            do
            {
                
                Console.WriteLine("-------      [1] Enviar Mensagem ");
                Console.WriteLine("-------      [2] Fazer Ligação ");
                acao = Console.ReadLine();

                do
                {
                    
                    switch (acao)
                    {
                        case "1":

                            phone1.Mensagem();

                            break;
                        case "2":

                            phone1.Ligacao();

                            break;
                        default:

                            Console.WriteLine("Operação Inválida");

                            break;
                    }

                } while (acao != "1" && acao != "2");

                Console.WriteLine("Refazer a operação? (S/N)");
                repetir = Console.ReadLine().ToUpper();
            
            } while (repetir == "S" || repetir == "SIM" || repetir == "SI");

        }
    }
}
