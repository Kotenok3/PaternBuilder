namespace PaternBuilder;

public class Director
{
    private IBuilderComputer ComputerBuilder {get; init; }
    
    public Director(IBuilderComputer computerBuilder)
    {
        ComputerBuilder = computerBuilder;
    }
    

    public Computer ConstructComputerCustom(string? processor = null, string? graphicCard = null, string? ram = null, int? sizeHardDrive = null)
    {
        ComputerBuilder.BuildProcessor(processor);
        ComputerBuilder.BuildGraphicsCard(graphicCard);
        ComputerBuilder.BuildRAM(ram);
        ComputerBuilder.BuildHardDrive(sizeHardDrive);
        return ComputerBuilder.GetProduct();
    }
}