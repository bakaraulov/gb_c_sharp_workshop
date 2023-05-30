// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

// d = √ [(x b - x a) 2 + (y b - y a) 2 + (z b - z a) 2]

int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int z1 = Prompt("Введите координату Z1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");
int z2 = Prompt("Введите координату Z2: ");
Console.WriteLine(" ");
Console.WriteLine($"Две точки с координатами: первая ({x1},{y1},{z1}) и вторая ({x2},{y2},{z2})");

Dist (x1, y1, x2, y2, z1, z2);

void Dist (int x1, int y1, int x2, int y2, int z1, int z2)
{
    Console.WriteLine(" ");
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine($"Растояние между двумя этими точками: {Math.Round(dist,4)}");
    Console.WriteLine(" ");
}

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}