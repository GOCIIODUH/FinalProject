string[] array = { "hello", "2", "world", ":-)" };
int size = array.Length;
int index = 0;
int indexNew = 0;
for (index = 0; index < size; index++)
{
    if (array[index].Length < 4) indexNew++;
}
string[] arrayItog = new string[indexNew];
index = 0;
int i = 0;
for (index = 0; index < size; index++)
{
    if (array[index].Length < 4)
    {
        arrayItog[i] = array[index];
        i++;
    }
}
Console.WriteLine("[" + string.Join(", ", arrayItog) + "]");


