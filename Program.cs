
// This method read string from user input and check String.Empty and Null
// parameter message: String user prompt message
String readStringFromUser(String message)
{
    Console.Write(message);
    var res = Console.ReadLine();
    if (res == String.Empty)
    {
        throw new Exception("Empty string");
    }
    else if (res == null)
    {
        throw new Exception("Null detected");
    }
    return res;
}

string[] aArr = new string[0];
int i = 0;
while (true)
{
    try
    {
        aArr = aArr
        .Append(readStringFromUser($"Введите строковое значение элемента массива с индексом ({i}) :"))
        .ToArray();
        i++;
    }
    catch (Exception)
    {
        break;
    }
}
String[] bArr = new String[0];
for (int j = 0; j < aArr.Length; j++)
{
    if (aArr[j].Length <= 3)
        bArr = bArr
        .Append(aArr[j])
        .ToArray();
}
String arrStr = "[";
foreach (var item in bArr)
{
    arrStr += $"\"{item}\", ";
}
arrStr = arrStr.Substring(0, arrStr.Length - 2) + "]";
Console.WriteLine($"Результат: {arrStr}");