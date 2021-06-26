using System;
using Figgle;

namespace projetofinal
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao="";
            string sair = "" ;
            string frase1="Programa finalizado!";
            DateTime hora2=DateTime.Now;


            do
            {

                try
                {
                    opMenu();
                    opcao = Console.ReadLine();


                    switch (opcao)
                    {
                        case "1":
                            adicao();
                            break;

                        case "2":
                            subtracao();
                            break;

                        case "3":
                            divisao();
                            break;

                        case "4":
                            multiplicacao();
                            break;

                        case "5":
                            raizq();
                            break;

                        case "6":
                            potenciacao();
                            break;

                        case "7":
                            Converter();
                            break;

                        case "8":
                            bhaskara();
                            break; 
                            
                        case "9":
                            fibonacci();
                            break;

                        case "10":
                              graus();
                              break;

                        case "11":
                             imc ();
                              break;

                        case "12":
                              creditos();
                              break;


                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção Inválida!");
                            Console.ResetColor();
                            break;
                    }

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Deseja retornar ao menu principal? S/N?");
                    Console.ResetColor();
                    sair = Console.ReadLine().ToUpper();


                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Limite de numeros digitados atingido.");
                    Console.ResetColor();
                    Console.WriteLine("Aperte uma tecla para voltar ao menu principal.");
                    Console.ReadKey();
                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não é possivel dividir por zero!");
                    Console.ResetColor();
                    Console.WriteLine("Aperte uma tecla para voltar ao menu principal.");
                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Número em formato inválido!");
                    Console.ResetColor();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Aperte uma tecla para voltar ao menu.");
                    Console.ResetColor();
                    Console.ReadKey();
                }



            } while (sair != "N" && sair != "NAO");

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(FiggleFonts.Standard.Render(frase1));
            Console.WriteLine($"Programa finalizado em: {hora2}");
            Console.ResetColor();

        }

        static void adicao()
        {
            int numero1=0;
            int numero2=0;
            int resultado=0;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = numero1 + numero2;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"A SOMA DE {numero1}+{numero2} É = {resultado}.");
            Console.ResetColor();
        }

        static void subtracao()
        {
            double numero1=0;
            double numero2=0;
            double resultado=0;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            resultado = numero1 - numero2;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"A SUBTRAÇÃO DE {numero1}-{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void divisao()
        {
            decimal numero1=0;
            decimal numero2=0;
            decimal resultado=0;

            Console.Write("Digite o primiro número: ");
            numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDecimal(Console.ReadLine());

            while (numero2 == 0)
            {
                throw new DivideByZeroException();
            }

            resultado = numero1 / numero2;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"A DIVISÃO DE {numero1}/{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void multiplicacao()
        {
            double numero1=0;
            double numero2=0;
            double resultado=0;

            Console.Write("Digite o primeiro número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            numero2 = Convert.ToDouble(Console.ReadLine());

            resultado = numero1 * numero2;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"A MULTIPLICAÇÃO DE {numero1}*{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void raizq ()
        {
            double numero1=0;
            double resultado=0;

            Console.Write("Digite um número: ");
            numero1 = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Sqrt(numero1);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"A RAIZ QUADRADA DE {numero1} É = {resultado}");
            Console.ResetColor();
        }

        static void potenciacao()
        {
            double numero1=0;
            double numero2=0;
            double resultado=0;

            Console.Write("Digite a base: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o expoente: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado = Math.Pow(numero1, numero2);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"O RESULTADO DA POTENCIÇÃO DE BASE{numero1}, E EXPOENTE{numero2} É = {resultado}");
            Console.ResetColor();
        }

        static void Converter()
        {
            double milhas, resultado;
            double km = 1.609;

            Console.Write("Digite a distância em Milhas: ");
            milhas = double.Parse(Console.ReadLine());
            resultado = milhas * km;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"O RESULTADO DA CONVERSÃO É:{resultado} KM.");
            Console.ResetColor();

        }

        static void bhaskara()
        {
            double a=0;
            double b=0;
            double c=0;
            double d=0;
            double x1=0;
            double x2=0;
            Console.WriteLine("Informe os valores de A,B e C.");
            Console.Write("(A): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            a=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("(B): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            b=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();


            Console.Write("(C): ");
            Console.ForegroundColor=ConsoleColor.Blue;
            c=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();


            d=Math.Pow(b,2)-4*a*c;
            x1=(-b+ Math.Sqrt(d))/2*a;
            x2=(-b- Math.Sqrt(d))/2*a;



            if(d<0){
                Console.ForegroundColor=ConsoleColor.Black;
                Console.BackgroundColor=ConsoleColor.Blue;
                Console.WriteLine("Como delta= "+d+", a equação não possui raízes reais!");
                Console.ResetColor();

            } else if (a==0){
                Console.ForegroundColor=ConsoleColor.Black;
                Console.BackgroundColor=ConsoleColor.Blue;
                Console.WriteLine("Não é uma equação de segundo grau!");
                Console.ResetColor();

            } else {
                Console.ForegroundColor=ConsoleColor.Black;
                Console.BackgroundColor=ConsoleColor.Blue;
                Console.WriteLine("X1 = "+x1+" e X2 = "+x2+". ");
                Console.ResetColor();

            }

        }
            static void fibonacci(){

            int c1=1;
            int c2=0;
            int c3=0;
            int x=0;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Digite a quantidade de números para serem exibidos da sequência de Fibonacci.");
            Console.Write("--> ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();
            Console.WriteLine();

            for(int i=0;i<x;i++){
                c3=c1+c2;
                Console.WriteLine(c3);
                c2=c1;
                c1=c3;
            }
            
        }
        static void graus(){

            double f=0;
            double c=0;
            Console.WriteLine("Convertendo graus Fahrenheit para graus Celsius. \n");
            
            Console.Write("Digite uma temperatura: ");
            f=Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();
            c= (f-32)/1.8;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.BackgroundColor=ConsoleColor.Blue;
            Console.WriteLine("Temperatura convertida em Celcius é: "+c);
            Console.ResetColor();

        }
        static void imc(){

            double m=0;
            double a=0;
            double imc=0;

            Console.WriteLine("---------------");
            Console.WriteLine("Calculando IMC!");
            Console.WriteLine("---------------");
            Console.WriteLine();

            
            Console.Write("Digite seu peso em kg: ");
            m=Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura em metros: ");
            a=Convert.ToDouble(Console.ReadLine());
            imc= Math.Round(m/(a*a),2);



            if(imc<17){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m². ");
                Console.WriteLine("Diagnóstico: Muito abaixo do peso.");
                Console.ResetColor();

            }else if (imc>=17.00&&imc<=18.49){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Abaixo do peso.");
                Console.ResetColor();

            }else if (imc>=18.50&&imc<=24.99){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Peso normal.");
                Console.ResetColor();

            } else if (imc>=25.00&&imc<=29.99){
                 Console.BackgroundColor = ConsoleColor.Blue;
                 Console.ForegroundColor = ConsoleColor.Black;
                 Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                 Console.WriteLine("Diagnóstico: Acima do peso.");
                 Console.ResetColor();

            } else if (imc>=30.00&&imc<=34.99){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obesidade 1.");
                Console.ResetColor();

            } else if(imc>=35.00&&imc<=39.99){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obesidade 2 (severa).");
                Console.ResetColor();

            } else if (imc>=40.00){
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Seu IMC É "+imc+" kg/m².");
                Console.WriteLine("Diagnóstico: Obasidade 3 (mórbida).");
                Console.ResetColor();

            }
        }

        static void creditos(){
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("Projeto destinado a matéria de PC na EtecAB");
            Console.WriteLine("Desenvolvido por: Isadora Kondo");
            Console.WriteLine("Github: https://github.com/DevIqcKondo");
            Console.WriteLine();
            Console.BackgroundColor=ConsoleColor.DarkCyan;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("Algumas pessoas acham que foco ");
            Console.WriteLine("significa dizer sim para a coisa");
            Console.WriteLine("em que você irá se focar.");
            Console.WriteLine("Mas não é nada disso.");
            Console.WriteLine("Significa dizer não às centenas");
            Console.WriteLine("de outras boas idéias que existem.");
            Console.WriteLine("Você precisa selecionar cuidadosamente.");
            Console.WriteLine("-Steve Jobs");
            Console.ResetColor();

        }

        static void opMenu()
        {
            Console.Clear();
            DateTime hora = DateTime.Now;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" +-------------- CALCULADORA -----------------+");

            Console.WriteLine(" | ☼ 1- Adição        |  ☼ 7- Conversor Mi/Km |");
            Console.WriteLine(" | ☼ 2- Subtração     |  ☼ 8- Bhaskara        |");
            Console.WriteLine(" | ☼ 3- Divisão       |  ☼ 9- Fibonacci       |");
            Console.WriteLine(" | ☼ 4- Multiplicação |  ☼ 10- Graus          |");
            Console.WriteLine(" | ☼ 5- Raiz          |  ☼ 11- IMC            |");
            Console.WriteLine(" | ☼ 6- Potenciação   |  ☼ 12- Créditos       |");
            Console.WriteLine(" +--------------------------------------------+");
            Console.WriteLine($"Programa iniciado em: {hora}");
            Console.ResetColor();
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Selecione a opção desejada: ");
            Console.ResetColor();
            

        }
    }
}
