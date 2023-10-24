using PaternBuilder;

Console.WriteLine("Если хотите минимальную сборку то введите 1, иначе будет кастомная сборка");
var build = Convert.ToInt32(Console.ReadLine());
Computer computer = null;
if (build == 1)
{
    var director = new Director(new BuilderMinComputer());
    computer = director.ConstructComputerCustom();
}
else
{
    var director = new Director(new BuilderComputer());

    Console.Write("Введите процессов:");
    var proc = Console.ReadLine();

    Console.Write("Введите видеокарту:");
    var video = Console.ReadLine();

    Console.Write("Введите опертивную память:");
    var ram = Console.ReadLine();

    Console.Write("Введите объём жесткого диска:");
    var sizeHardDrive = Convert.ToInt32(Console.ReadLine());

    computer = director.ConstructComputerCustom(proc, video, ram, sizeHardDrive);
}

Console.WriteLine(computer);