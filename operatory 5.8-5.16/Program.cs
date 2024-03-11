using System.Text;
Console.OutputEncoding = Encoding.UTF8;
//Задача 5.8.
/*string temp = Console.ReadLine();   
double sum=0;
for(int i = 0; i < temp.Length; i++)
{
    sum+=char.GetNumericValue(temp[i]);
    
}
Console.WriteLine(sum);*/

//Задача 5.9.
/*string temp = Console.ReadLine();   

for(int i = temp.Length-1; i>=0 ; i--)
{
    Console.Write(temp[i]);
    
}*/

//Задача 5.10
/*for(int i=90;i>=5;i--)
{
    if(i%2!=0&&i%3==0&&i%5!=0)Console.Write(i+"\t");
} */

//Задача 5.11
/*while (true)
{
    Console.WriteLine("----Меню----\n[+]-Додати\n[-]-Відняти\n[*]-Помножити\n[/]-Ділити\n[0]-Вихід\n");
    string temp=Console.ReadLine();
    switch (temp)
    {
        case "+":
            Console.Write("Введіть число 1:");
            double num1 =int.Parse(Console.ReadLine());
            Console.Write("Введіть число 2:");
            double num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1+num2}");
            break;
        case "-":
            Console.Write("Введіть число 1:");
             num1 =int.Parse(Console.ReadLine());
            Console.Write("Введіть число 2:");
             num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1-num2}");
            break;
            case "*":
            Console.Write("Введіть число 1:");
            num1 =int.Parse(Console.ReadLine());
            Console.Write("Введіть число 2:");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1*num2}");
            break;
            case "/":
            Console.Write("Введіть число 1:");
            num1 =int.Parse(Console.ReadLine());
            Console.Write("Введіть число 2:");
            num2 =int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат:{num1/num2:f02}");
            break;
            case "0": 
            return;
            default:
            break;
    }
}*/

//Задача 5.12.
//Знайти найбільший спільний дільник двох натуральних чисел, використавши алгоритм Евкліда.
//Алгоритм Евкліда полягає в наступному: від більшого числа віднімається менше до тих пір, поки вони не стануть рівними;
//отримане в результаті число і буде найбільшим спільним дільником.

/*Console.WriteLine("Ведіть перше число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ведіть друге число");
int num2 = int.Parse(Console.ReadLine());
int temp;
if (num1 < num2)
{
    temp = num2;
    num2 = num1;
    num1 = temp;
}
temp=0;
while (num1 > num2)
{
    num1 = num1 -num2;
    temp++;
    if(num1 == num2)
    {
        Console.WriteLine("найбільший спільний дільник:{0}", temp);
        return;
    }
}
Console.WriteLine("Спільних дільників не знайденно");*/

//Задача 5.13.
//Написати програму, яка виводить на екран лінію з символів.
//Число символів та сам символ, і яка буде лінія вертикальна, або горизонтальна - вказує користувач.

/*void PrintVertical(int n, char sign)
{
    for(int  i = 0; i < n; i++)
    {
        Console.WriteLine(sign);
    }
}
void PrintHorizontal(int n, char sign)
{
    for(int  i = 0; i < n; i++)
    {
        Console.Write(sign);
    }
}

Console.WriteLine("Ведіть кількість символів");
int count = int.Parse(Console.ReadLine());
Console.WriteLine("Ведіть символ");
char sign = char.Parse(Console.ReadLine());
Console.WriteLine("Оберіть дію\n[1]-Вертикально\n[2]-Горизонтально");
int temp = int.Parse(Console.ReadLine());
switch (temp)
{
    case 1:
        PrintVertical(count, sign); break;
    case 2: PrintHorizontal(count, sign); break;
    default:break;
}*/

//Задача 5.14.
//Написати програму, яка виводить на консоль фігури, зображені нижче. Примітка. Розміри фігур вказує користувач.

/*void Figure1(int sizea, int sizeb)
{
    for(int i = 0; i < sizeb; i++)
    {
        for(int j = 0; j < sizea; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
    }
}
void Figure2(int sizea, int sizeb)
{
    
    for(int i = 0; i < sizeb; i++)
    {
        if(i==0||i==sizeb-1){
        for(int j = 0; j < sizea; j++)
        {
            Console.Write("*");
        }
        }
        else
        {   Console.Write("*");
            for(int j = 1; j < sizea-1; j++)
            {
            Console.Write(" ");
            }
            Console.Write("*");

        }
        Console.Write("\n");
    }
}
void Figure3(int sizea, int sizeb)
{
    for(int i = 0; i < sizeb; i++)
    {
        for(int j = 0; j < sizea; j++)
        {
            Console.Write("*");
        }
        Console.Write("\n");
        sizea--;
    }
}
while(true){
Console.WriteLine("Ведіть кількість символів в рядку");
int sizea = int.Parse(Console.ReadLine());
Console.WriteLine("Ведіть кількість рядків");
int sizeb = int.Parse(Console.ReadLine());
Console.WriteLine("Оберіть дію\n[1]-фігура 1\n[2]-Фігура 2\n[3]-Фігура 3\n[4]-Вихід");
int temp = int.Parse(Console.ReadLine());
switch (temp)
{
    case 1:Figure1(sizea,sizeb); break;
    case 2:Figure2(sizea,sizeb); break;
    case 3:Figure3(sizea,sizeb); break; 
    case 4:return;          
    default:break;
}
}*/

//Задача 5.15
//Написати програму, що генерує та виводить на консоль 5 випадкових чисел, кратних 7-ми та некратних 5-ти одночасно з діапазону [50,150]

/*int temp=0;
Random rand = new Random(1439054);
while (temp < 5)
{
    int num= rand.Next(50,151);
    if (num % 7 == 0 && num % 5 != 0)
    {
        Console.WriteLine(num);
        temp++;
    }
}*/

//Задача 5.16.
//Написати програму, що передбачає вгадування користувачем числа, загаданого комп’ютером.
//Після кожної спроби вгадати число комп’ютер повідомляє чи загадане значення більше (>) чи менше (<) від запропонованого користувачем.
//Після вгадування на екран виводиться кількість спроб.
//Припустимо, що компютер має право загадувати число у діапазоні [1,10000].Примітка. Потрібне вміння генерувати випадкові числа за допомогою класу Random.

/*Random random = new Random(37982);
int num = random.Next(1,10001);
int attempts =0;
while (true)
{
    int input = int.Parse(Console.ReadLine());
    attempts++;
    if (input > num)
    {
        Console.WriteLine("Загадане число менше");
        
    }else if (input < num)
    {
        Console.WriteLine("Загадане число більше");
        
    }
    else
    {

        Console.WriteLine($"Ви виграли.\nЗагадане число:{num}\nКількість спроб:{attempts}");
    }
}*/
