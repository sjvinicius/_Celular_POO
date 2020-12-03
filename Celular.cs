using System;

namespace _Celular
{
    public class Celular
    {
        //Cor do Celular
        public string color;
        //Modelo do Celular
        public string model;
        //Tamanho do Celular
        public string size;
        //Ligado ou Desligado
        public bool power;


        //Métodos

        //  DESLIGAR DISPOSITIVO
        public bool Desligar(){

            if(power != false) {

                Console.WriteLine("------       Desligando Dipositivo ...");
                
                return power = false;

            }

            return power = false;

        }

        //  LIGAR DISPOSITIVO
        public bool Ligar(){

            if(power != true) {

                Console.WriteLine("------       Ligando Dipositivo ...");
                
                return power = true;

            }
            
            return power = false;

        }

        //Ligação
        public void Ligacao(){

            Console.WriteLine("------       Digite o numero que quer ligar");
            Console.ReadLine();
            Console.WriteLine("------       Esse Número encontra-se fora da área de cobertura");
        
        }

        //Mensagem
        public void Mensagem(){

            Console.Write("------       Digite sua mensagem: ");
            Console.ReadLine();
            Console.WriteLine("------        MENSAGEM ENVIADA");

        }
    }
}