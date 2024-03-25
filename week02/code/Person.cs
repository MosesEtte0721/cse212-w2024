public class Person {
    public readonly string Name;
    public int Turns { get; set; }

    internal Person(string name, int turns) {
        Name = name;
        Turns = turns;
    }

    public void ToString() {
        Console.WriteLine(Turns <= 0 ? $"({Name}:Forever)" : $"({Name}:{Turns})");
    }
}