namespace PR18
{
    public class PR18
    {
        public void SquareeQuation()
        {
            Console.Write("a = ");
            double a = Double.Parse(Console.ReadLine());

            Console.Write("b = ");
            double b = Double.Parse(Console.ReadLine());

            Console.Write("c = ");
            double c = Double.Parse(Console.ReadLine());

            double x = 0;
            double discriminant = 0;
            double x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Любое x");

                    }
                    else
                    {
                        Console.WriteLine("Нет решений");

                    }
                }
                else
                {
                    x = -c / b;
                    Console.WriteLine($"X = {x}");

                }

            }
            else
            {
                discriminant = b * b - 4 * a * c;


                if (discriminant < 0)
                {
                    Console.WriteLine("Нет вещественный корней");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine($"X1 = {x1}, X2 = {x2}");
                }
            }

        }
    }
}
