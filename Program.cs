Console.Clear();
string[] array = new string[7] {"456", "7", "hello", "it", "is", "2351", "4643"};
string[] array2 = new string[array.Length];
void ArrayPerebor(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
ArrayPerebor(array, array2);
PrintArray(array2);