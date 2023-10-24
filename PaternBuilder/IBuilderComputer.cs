namespace PaternBuilder;

public interface IBuilderComputer
{
    void BuildProcessor(string? processor);
    void BuildGraphicsCard(string? card);
    void BuildRAM(string? ram);
    void BuildHardDrive(int? size);

    Computer GetProduct();
}