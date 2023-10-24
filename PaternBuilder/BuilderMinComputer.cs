namespace PaternBuilder;

public class BuilderMinComputer : IBuilderComputer
{
    private Computer computer = new Computer();
    public void BuildProcessor(string? processor)
    {
        computer.Processor = "intel pentium";
    }

    public void BuildGraphicsCard(string? card)
    {
        computer.GraphicsCard = "inet graphic";
    }

    public void BuildRAM(string? ram)
    {
        computer.RAM = "DRR 3 4гб";
    }

    public void BuildHardDrive(int? size)
    {
        computer.HardDrive = 80;
    }

    public Computer GetProduct()
    {
        BuildProcessor("");
        BuildGraphicsCard("");
        BuildRAM("");
        BuildHardDrive(80);
        return computer;
    }
}