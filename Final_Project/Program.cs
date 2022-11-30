// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.
Console.Write("Введите колличество строк в массиве: ");
int n=Convert.ToInt32(Console.ReadLine());

string[] array=new string[n];
for(int i=0;i<n;i++)
{
    Console.Write("Введите страку массива:");
    string k=Convert.ToString(Console.ReadLine());
    array[i]=k;
    
}
for(int i=0;i<n;i++)
{
    Console.Write(array[i]);
    Console.Write(" ");
}
Console.WriteLine(" ");
NewArray(array,n);
void NewArray(string[] array,int n)
{
    int m=new Random().Next(0,4);
    string[] MyArray=new string[m];
        
    for(int j=0;j<MyArray.Length;j++)
        {
        int i=new Random().Next(0,n+1);
        MyArray[j]=array[i];
        Console.Write(MyArray[j]);
        Console.Write(" ");
    }
    
}