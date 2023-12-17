int[] GetNewArray(int size)
{
    int[] newArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        newArray[i] = rnd.Next(1, 100);
    }
    return newArray;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write(arr[i] + " ");
    }
}
int[] arr = GetNewArray(10);
PrintArray(arr);
Console.WriteLine();
TurnOver(arr,0);

void TurnOver(int[] array,int i)
{
    if(i<array.Length)
    {
       Console.Write(array[array.Length-1-i] + " ");
       TurnOver(array,i+1);
    } 
}