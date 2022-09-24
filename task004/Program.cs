// Задача: программа из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам.

string[] arrayA = new string[9] {"One","two","three","four","five","six","seven","8", ".."};
string[] arrayB = new string[arrayA.Length];


void CreateArray (string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
    if(arrayA[i].Length <= 3)
        {
        arrayB[count] = arrayA[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CreateArray(arrayA, arrayB);
PrintArray(arrayA);
PrintArray(arrayB);