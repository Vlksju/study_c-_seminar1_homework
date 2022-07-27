Console.WriteLine("Программа, которая выводит минимум и максимум из двух чисел");
Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
int number2 = Convert.ToInt32(Console.ReadLine ());

if (number1 > number2) {
    Console.Write("Максимум - ");
    Console.WriteLine(number1);
    Console.Write("Минимум - ");
    Console.WriteLine(number2);
}
else {
    Console.Write("Максимум - ");
    Console.WriteLine(number2);
    Console.Write("Минимум - ");
    Console.WriteLine(number1);  
}
