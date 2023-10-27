
//cost tovar1;
//cost tovar2;
//cost tovar3;
//cost tovar4;
//cost tovar5;
//tovar1.year = 2022;
//tovar2.year = 2023;
//tovar3.year = 2022;
//tovar4.year = 2022; 
//tovar5.year = 2023;

//    tovar1.price = 200;
//    tovar2.price = 100;
//    tovar3.price = 250;
//    tovar4.price = 200;
//    tovar5.price = 200;
//struct cost
//{
//    public string name;
//    public string maker;
//    public int year;
//    public int count;
//    public int price;
//    public void Print()
//    {
//        if (DateTime.Now.Year-) 
//        {
//            Console.WriteLine($"Год производства:{year}; Цена товара:{price};Название Товара{name};Производитель{maker};");
//        }

//    }

//}
using System.Threading.Channels;

Cost_tovar[] tovars=new Cost_tovar[2];
for (int i = 0; i < tovars.Length; i++)
{
    Console.Write("название:");
    string name = Console.ReadLine();
    Console.Write("цена:");
    int value = int.Parse(Console.ReadLine());
    Console.Write("год:");
    int year=int.Parse(Console.ReadLine());
    Console.Write("кол-во:");
    int count=int.Parse(Console.ReadLine());
    double s = 0;
    tovars[i] = new Cost_tovar(name,value,year,count,s);
    
}
for(int i=0; i < tovars.Length; i++)
{
    //if (DateTime.Now.Year - tovars[i].year == 0)
    //{
    //    tovars[i].value = 0;
    //}
    if (DateTime.Now.Year == tovars[i].year)
    {
        tovars[i].s += tovars[i].value * tovars[i].count;
        Console.WriteLine($"название товара {tovars[i].name}");
        Console.WriteLine($"кол-во товара {tovars[i].count}");
        Console.WriteLine($"цена товара {tovars[i].s}");
    }
}
struct Cost_tovar
{
    public string name;
    public int value;
    public int year;
    public int count;
    public double s;

    public Cost_tovar(string name, int value, int year, int count, double s)
    {
        this.name = name;
        this.value = value;
        this.year = year;
        this.count = count;
        this.s = s;
    }
}
