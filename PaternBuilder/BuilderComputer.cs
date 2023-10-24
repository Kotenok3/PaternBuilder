namespace PaternBuilder;

public class BuilderComputer : IBuilderComputer
{
    private Computer computer = new Computer();
    public void BuildProcessor(string? processor)
    {
        computer.Processor = processor;
    }

    public void BuildGraphicsCard(string? card)
    {
        computer.GraphicsCard = card;
    }

    public void BuildRAM(string? ram)
    {
        computer.RAM = ram;
    }

    public void BuildHardDrive(int? size)
    {
        computer.HardDrive = size ?? 0;
    }

    public Computer GetProduct()
    {
        return computer;
    }
}