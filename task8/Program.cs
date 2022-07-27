Console.WriteLine("Программа, которая выводит все четные числа от 1 до N");
Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine ());

int count = 2;
while (count <= number) {
    Console.WriteLine(count);
    count = count+2;}
