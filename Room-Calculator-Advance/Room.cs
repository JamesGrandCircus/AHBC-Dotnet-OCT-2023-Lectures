using System.Text;

namespace Room_Calculator_Advance;

public record Room
{
    public Room(string name, double length, double width, double height)
    {
        Id = IdCounter.GetNextId();
        Name = name;
        Length = length;
        Width = width;
        Height = height;
        Area = Length * Width;
        Perimeter = 2 * (Width + Length);
        Volume = Area * Height;
        SurfaceArea = 2 * (Length * Width + Width * Height + Length * Height);
        RoomSize = Area <= 250 ? RoomSize.small : Area >= 650 ? RoomSize.large : RoomSize.medium;
        RoomInfo = $"Id: {Id} - Room {Name} is a {RoomSize} room";
        _toStringValue = BuildToString();
    }

    private string _toStringValue;
    public int Id { get; init; }
    public string Name { get; init; }
    public double Length { get; init; }
    public double Width { get; init; }
    public double Height { get; init; }
    public double Area { get; init; }
    public double Perimeter { get; init; }
    public double Volume { get; init; }
    public double SurfaceArea { get; init; }
    public RoomSize RoomSize { get; init; }
    public string RoomInfo { get; init; }

    public override string ToString()
    {
        return _toStringValue;
    }

    private string BuildToString()
    {
        var id = $"ID: {Id}";
        var title = $"ROOM: {Name}";

        const int PADDING = -14;
        var lines = new string[]
        {
            $"{"Length:", PADDING} {Length:F2}",
            $"{"Width:", PADDING} {Width:F2}",
            $"{"Height:", PADDING} {Height:F2}",
            $"{"Area:", PADDING} {Area:F2}",
            $"{"Perimeter:", PADDING} {Perimeter:F2}",
            $"{"Volume:", PADDING} {Volume:F2}",
            $"{"Surface Area:", PADDING} {SurfaceArea:F2}",
        };

        var linesMax = lines.Max(x => x.Length);

        var sb = new StringBuilder();

        sb.AppendLine(id);
        sb.AppendLine(title);
        sb.AppendLine(new string('=', Math.Max(linesMax, title.Length) + 1));

        foreach (var line in lines)
            sb.AppendLine(line);

        return sb.ToString();
    }

    public static double GetValidCalculation(Dimension paramName)
    {
        while (true)
        {
            Console.Write($"Enter the {paramName} of the room: ");
            string input = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            if (double.TryParse(input, out double value))
            {
                return value;
            }

            ConsoleHelper.WriteLineColors($"Invalid {paramName}, please try again", ConsoleColor.Red);
            ConsoleHelper.ReadLineClear();
        }
    }

    public static string GetValidName() 
    {
        while (true) 
        {
            Console.Write("Enter the name of the room: ");
            string name = Console.ReadLine() ?? string.Empty;
            Console.Clear();
            if (name.Length > 0)
            {
                return name;
            }

            ConsoleHelper.WriteLineColors("Invalid name, please try again", ConsoleColor.Red);
            ConsoleHelper.ReadLineClear();
        }
    }
}