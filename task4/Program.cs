Console.WriteLine("Программа, которая выводит максимум из трех чисел");
Console.WriteLine("Введите 3 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine ());
int number2 = Convert.ToInt32(Console.ReadLine ());
int number3 = Convert.ToInt32(Console.ReadLine ());

if (number1 > number2) { 
    if (number1 > number3) {  
        Console.Write("Максимум - ");
        Console.WriteLine(number1);}
else {
         Console.Write("Максимум - ");
         Console.WriteLine(number3);}
  
}
else {
    if (number2 > number3) { 
    Console.Write("Максимум - ");
    Console.WriteLine(number2);}
else {
    Console.Write("Максимум - ");
    Console.WriteLine(number3);} 
}

