Console.WriteLine("Введите начальное число");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число");
int finish = Convert.ToInt32(Console.ReadLine());
void GetNumbers(int start,int finish)
{
    if(start <= finish)
    {
        Console.Write(start + " ");
        GetNumbers(start+1,finish);
    }
}
GetNumbers(start,finish);