using System;

class Point
{
    private double x;
    private double y;

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public double Dist()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public string Fourth()
    {
        if (x == 0 && y == 0)
            return "Точка знаходиться в початку координат";
        else if (x == 0)
            return "Точка знаходиться на вісі Y";
        else if (y == 0)
            return "Точка знаходиться на вісі X";
        else if (x > 0 && y > 0)
            return "Точка знаходиться в першій чверті";
        else if (x < 0 && y > 0)
            return "Точка знаходиться в другій чверті";
        else if (x < 0 && y < 0)
            return "Точка знаходиться в третій чверті";
        else
            return "Точка знаходиться в четвертій чверті";
    }

    public void Print()
    {
        Console.WriteLine($"Координати точки: ({x}, {y})");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Point point = new Point(); // Створення об'єкту за допомогою конструктора за замовчуванням

            Console.Write("Введіть значення координати X: ");
            point.X = double.Parse(Console.ReadLine());

            Console.Write("Введіть значення координати Y: ");
            point.Y = double.Parse(Console.ReadLine());

            Console.WriteLine("Значення полів об'єкту:");
            point.Print();

            Console.WriteLine($"Відстань до початку координат: {point.Dist()}");
            Console.WriteLine($"Місцезнаходження точки: {point.Fourth()}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }
}
