// Ejercicio 1

Console.WriteLine("Introduzca su nombre: ");
string name = Console.ReadLine();
Console.WriteLine("Introduzca su apellido: ");
string surname = Console.ReadLine();
Console.WriteLine("Introduzca su Edad: ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sabe programar?: ");
string developer = Console.ReadLine();

Console.Write("Bienvenido " + name + " " + surname);
Console.Write(" de " + age + " años");
Console.Write(" queda asentado que " + developer + " sabes programar");

//Ejercicio 2
//class Car
//{
//    public int doors;
//    public int wheels;
//    public string brand;
//    public bool validITV;
//}

//class Table
//{
//    public double weight;
//    public double length;
//    public string material;
//    public string color;
//}

//Ejercicio 3

int numero = 18;
char caracter = 'a';
Console.WriteLine(numero >= 18 && caracter == 'a');
Console.WriteLine(numero >= 19 || caracter == 'a');





