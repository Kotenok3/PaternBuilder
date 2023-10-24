namespace PaternBuilder;

public class Computer
{
    public string Processor { set; get; }
    public string GraphicsCard { set; get; }
    public string RAM { set; get; }
    public int HardDrive { set; get; }

    public override string ToString()
    {
        return "Computer:"
               + String.Join(" ", new[] { Processor, GraphicsCard, RAM, HardDrive.ToString() });
    }
}