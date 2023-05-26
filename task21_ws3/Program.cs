// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

Console.Clear();

// d = √ [(x2-x1)2+ (y2-y1)2 ] , Где  (x1,y1) и (x2,y2)

int x1 = Prompt("Введите координату X1: ");
int y1 = Prompt("Введите координату Y1: ");
int x2 = Prompt("Введите координату X2: ");
int y2 = Prompt("Введите координату Y2: ");

Dist (x1, y1, x2, y2);

void Dist (int x1, int y1, int x2, int y2)
{
    double dist = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)); // d = √ [(x2-x1)2+ (y2-y1)2 ] , Где  (x1,y1) и (x2,y2)
    
    Console.WriteLine($"Растояние между точками равно: {Math.Round(dist,4)}");
}

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}