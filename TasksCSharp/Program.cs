// 1. Найти пропущенный элемент в массиве и вывести его на экран

using System.Text;

int[] a = { 1, 2, 4, 5, 6, 8, 10 };

PrintMissingElements(a);

void PrintMissingElements(int[] array)
{
    var sb = new StringBuilder("int[] b = { ");

    for (var i = 1; i < a.Length; i++)
    {
        if (a[i] - a[i - 1] > 1)
        {
            sb.Append($"{a[i] - 1}, ");
        }
    }

    sb.Remove(sb.Length - 2, 2).Append(" }");

    Console.WriteLine(sb);
}

// 2. Пройтись по всем элементам массива. Если число четное вернуть - 1, нечетное - 0

var b = GetParitiesOfElementArray(a);

Console.WriteLine($"int[] b = {{ {string.Join(", ", b)} }}");

int[] GetParitiesOfElementArray(int[] array)
{
    var result = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        result[i] = array[i] % 2 == 0 ? 1 : 0;
    }

    return result;
}

// 3. Найти первое вхождение символа в строке, заменить ее другим символом и вывести оставшуюся часть строки начиная с этого символа

string s = "Hello morld!";

string correctString = ReplaceFirstOccurrenceAndRestPrint(s, 'm', 'w');

string ReplaceFirstOccurrenceAndRestPrint(string line, char oldChar, char newChar)
{
    var index = line.IndexOf(oldChar);

    var sb = new StringBuilder(line.Substring(0, index));

    sb.Append(newChar).Append(line.Substring(index + 1, line.Length - index - 1));

    var result = sb.ToString();

    Console.WriteLine($"\"{result.Substring(index)}\"");

    return result;
}