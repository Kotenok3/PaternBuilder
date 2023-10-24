namespace PaternBuilder;

public class Computer
{
    public string Processor { set; get; }
    public string GraphicsCard { set; get; }
    public string RAM { set; get; }
    public int HardDrive { set; get; }

    public override string ToString()
    {
        return "Computer:" +
               "Processor:" + (Processor ?? "doesn't have") +
               "GraphicsCard:" + (GraphicsCard ?? "doesn't have") +
               "RAM:" + (RAM ?? "doesn't have") +
               "HardDrive:" + HardDrive;
    }
}