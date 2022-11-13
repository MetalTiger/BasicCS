// See https://aka.ms/new-console-template for more information

namespace BasicCS
{
    
    class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World!");
            //Calculadora();
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

            double a;
            double b, c;
            string opc;

            int opc2 = 0;

            Console.WriteLine("**Calculadora**");

            while (opc2 == 0)
            {

                Console.WriteLine("Escribe el primer numero verijon:");
                a = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Escribe el segundo numero verijon:");
                b = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Escribe la operacion a realizar verijon (+ - / *):");
                opc = Console.ReadLine();

                switch (opc)
                {

                    case "+":
                        c = a + b;
                        Console.WriteLine($"La suma de {a} + {b} = {c}");
                        break;

                    case "-":
                        c = a - b;
                        Console.WriteLine($"La suma de {a} - {b} = {c}");
                        break;

                    case "*":
                        c = a * b;
                        Console.WriteLine($"La suma de {a} * {b} = {c}");
                        break;

                    case "/":
                        c = a / b;
                        Console.WriteLine($"La suma de {a} / {b} = {c}");
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