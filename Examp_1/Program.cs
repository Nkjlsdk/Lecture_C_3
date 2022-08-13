// метод 1 / Вид
void Method1()//ничего не принемает, поэтому ()
{
    Console.WriteLine("Автор ____"); //Ничего не возвращает
}
//Выше создали метод 1 имя: Method1

Method1(); //Вызов метода

// метод 2 Вид 2
//void Method2(string msg) //что-то принимает, но ничего не возвращает. string - тип данных, msg - аргумент
//{
  //  Console.WriteLine(msg);
//}
//Method2("Текст сообщения");// или можно вызвать ИМЕННОВАННЫЙ АРГУМЕНТ Method2(msg: "Текст сообщеня"), где msg имя аргумента

//или с несколькими аргументами:
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21(msg:"Текст", count: 4); //4 сколько раз повторить метод, именнованные аргументы не обязательно использовать по порядку

//Вид 3 ничего не принимают, что-то возвращают
// Обязательное указание типа данных, которое мы ожидаем на выход
int Method3()//Аргументы никакие не принимает
{
    return DateTime.Now.Year;//return обязательно
}
int year = Method3();
Console.WriteLine(year);

// Метод 4  Вид 4
string Method4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result+Text;
        i++;
    }
    return result;
}

string res = Method4(10, "asdf");
Console.WriteLine(res);