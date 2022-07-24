string s = "Этот массив содержит элементы с arr ay[0] по array[4]. Элементы массива инициализируются, до значения по умолчанию для типа элемента. Для целых чисел это 0.";
string[] array = s.Split(" ");
int count = 0;
// создание результирующего массива
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}
string[] res = new string[count];
//заполнение нового массива
int pos = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length <= 3)
    {
        res[pos] = array[j];
        pos++;
    }
}
// вывод
for (int i = 0; i < res.Length; i++)
{
    Console.Write(res[i] + " ");
}


