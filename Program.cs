void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите cлова: ");
string str = Console.ReadLine();
string[] words = str.Split(' ');
string[] new_words = new string[words.Length]; 
int count = 0;
for (int i = 0; i < words.Length; i++)
{
    
    if (words[i].Length <= 3)
    {
        new_words[count] = words[i];
        count++;
    }
}
Print(new_words);
