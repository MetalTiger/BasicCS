// See https://aka.ms/new-console-template for more information

namespace BasicCS
{
    
    class Program 
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Hello, World!");
            //Calculadora();
            //Calculadora2();
            //saludos();
            compras();

            double a = numero1() + 5;
            double b = numero1(5) + 5;

            Animal animal1 = new Animal();
            animal1.nombre = "Pedro";
            animal1.edad = 15;

            Animal animal2 = new Animal("Juan", 2);

            Console.WriteLine($"{animal1.nombre} tiene {animal1.edad} años y ahora va hablar:");
            animal1.Hablar();

            Console.WriteLine($"{animal2.nombre} tiene {animal2.edad} años");
            animal2.Hablar();

            Perro perro1 = new Perro(name: "Mamawebo", age: 3, color: Color.Blanco);
            Perro perro2 = new("Pelao", age: 6, Color.Azul);

            List<Perro> perros = new List<Perro>() 
            { 
                perro1,
                perro2,
            };

            perros.ForEach(perro => {

                Console.WriteLine($"El perro se llama {perro.nombre} tiene {perro.edad} años, es de color:");
                Console.BackgroundColor = (ConsoleColor)perro.Color;
                Console.ForegroundColor = (ConsoleColor)perro.Color;
                Console.WriteLine("asdasdasd");
                Console.ResetColor();
                Console.WriteLine("Y va a hablar:");
                perro.Hablar();


            });
            


        }

        public static void compras(){

            double total;
            int colores;
            double descuento;
            double tdescuento;


            Console.WriteLine("Recibo walmart, ingresa tu total");
            total = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Tu total es {total}, tenemos promo, elige un color para posibles descuentos: 0.Amazul 1.RosaMelo 2.Mayonesa 3.Otro");
            colores = Int32.Parse(Console.ReadLine());


            switch (colores)
            {
                case 0:
                    Console.WriteLine ($"Elegiste Amazul, tienes un 20% de descuento.");
                    descuento = total * 0.20; 
                    tdescuento = total - descuento;
                    Console.WriteLine ($"Tu descuento es de {descuento} y tu total con descuento es {tdescuento}");
                    break;

                case 1:
                    Console.WriteLine ($"Elegiste RosaMelo, tienes un 15% de descuento.");
                    descuento = total * 0.15; 
                    tdescuento = total - descuento;
                    Console.WriteLine ($"Tu descuento es de {descuento} y tu total con descuento es {tdescuento}");
                    break;

                case 2:
                    Console.WriteLine ($"Elegiste Mayonesa, tienes un 50% de descuento.");
                    descuento = total * 0.50; 
                    tdescuento = total - descuento;
                    Console.WriteLine ($"Tu descuento es de {descuento} y tu total con descuento es {tdescuento}");
                    break;

                case 3:
                    Console.WriteLine ($"Elegiste Otro, no tienes descuento.Tas pendejo y tu total con descuento es {total}");
                    break;

                default:
                    Console.WriteLine("no sabes leer pa");
                    break;

            }


            

        }


        public static void saludos(){

            string n;
            string a;
            string e;

            Console.WriteLine("wenos dias, dame tu nombre");
            n = Console.ReadLine();

            Console.WriteLine("dame tu apellido");
            a = Console.ReadLine();

            Console.WriteLine("dame tu edad");
            e = Console.ReadLine();
        
            int l = n.Count() / 2;
            string mitad = n.Substring(l, 1);



            Console.WriteLine ($"sabandija tu nombre es {mitad.ToUpper()}, tu apellido es {a.ToUpper().First()} y tienes {e} años");


        }


        public static void Calculadora2(){
            double x;
            double y;
            string z;
            double r;
            int exit = 0;

            

            while (exit == 0) 
            {

                Console.WriteLine("olap soy una calculadora dame 2 numeros perro");
                Console.WriteLine("Dame el primer numerooo");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("dame el segundo numero");
                y = int.Parse(Console.ReadLine());

                Console.WriteLine("Elije tu operacion perro + - / *");
                z = Console.ReadLine();


                if(z == "+")
                {
                    r = x + y;
                    Console.WriteLine($"mamaguevo tu resultado es {r}");

                } 
                else if (z == "-")
                {
                    r = x - y;
                    Console.WriteLine($"mamaguevo tu resultado es {r}");

                }   
                else if (z == "/")
                {
                    r = x / y;
                    Console.WriteLine($"mamaguevo tu resultado es {r}");

                }
                else if (z == "*")
                {
                    r = x * y;
                    Console.WriteLine($"mamaguevo tu resultado es {r}");
                
                } 
            
                Console.WriteLine("kalkuladora pro 0.Seguir operaciones 1.salir a la verga");
                exit = Int32.Parse(Console.ReadLine());


            } 
            



        }

        private static int numero1()
        {
            return 1;
        }
        private static int numero1(int numero)
        {
            return numero + 1;
        }
        public static void Calculadora() 
        {

            double j;
            double b, c;
            string opc;

            int opc2 = 0;

            Console.WriteLine("**Calculadora**");

            while (opc2 == 0)
            {

                Console.WriteLine("Escribe el primer numero verijon:");
                j = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Escribe el segundo numero verijon:");
                b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Escribe la operacion a realizar verijon (+ - / *):");
                opc = Console.ReadLine();

                switch (opc)
                {

                    case "+":
                        c = j + b;
                        Console.WriteLine($"La suma de {j} + {b} = {c}");
                        break;

                    case "-":
                        c = j - b;
                        Console.WriteLine($"La suma de {j} - {b} = {c}");
                        break;

                    case "*":
                        c = j * b;
                        Console.WriteLine($"La suma de {j} * {b} = {c}");
                        break;

                    case "/":
                        c = j / b;
                        Console.WriteLine($"La suma de {j} / {b} = {c}");
                        break;

                    default:
                        Console.WriteLine("Eres un pendejo");
                        break;

                }

                Console.WriteLine("Quieres hacer otra operacion? 0.- Si 1.- No");
                opc2 = Int32.Parse(Console.ReadLine());
            }


        }
    
    }

    class Animal 
    {
        public string nombre { get; set; }
        public int edad { get; set; }

        public Animal()
        {

        }

        public Animal(string nom, int years)
        {
            this.nombre = nom;
            this.edad = years;
        }

        public virtual void Hablar() 
        { 
            Console.WriteLine("hola"); 
        }

    }

    enum Color 
    { 
        Blanco = ConsoleColor.White,
        Negro = ConsoleColor.Black,
        Rojo = ConsoleColor.Red,
        Azul = ConsoleColor.Blue,
    
    }

    class Perro : Animal 
    {
        public Color Color { get; set; }

        public Perro(string name, int age, Color color)
        {
            this.nombre = name;
            this.edad = age;
            this.Color = color;

        }

        public override void Hablar()
        {
            Console.WriteLine("Guau");
        }


    }

}