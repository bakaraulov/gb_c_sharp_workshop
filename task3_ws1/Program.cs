Console.WriteLine("Введите № дня недели: ");
int numberDay = int.Parse(Console.ReadLine ()!);
if (numberDay == 1)
{
Console.WriteLine("Понедельник");    
}
else if (numberDay == 2)
{
Console.WriteLine("Вторник");    
}
else if (numberDay == 3)
{
Console.WriteLine("Сред");    
}
else if (numberDay == 4)
{
Console.WriteLine("Четверг");    
}
else if (numberDay == 5)
{
Console.WriteLine("Пятница");    
}
else if (numberDay == 6)
{
Console.WriteLine("Суббота");    
}
else if (numberDay == 7)
{
Console.WriteLine("Воскресенье");    
}
else 
{
Console.WriteLine("Нет такого дня недели");    
}

// if (numberDay < 1 || numberDay > 7)
// {
// Console.WriteLine("Нет такого дня недели");    
// }