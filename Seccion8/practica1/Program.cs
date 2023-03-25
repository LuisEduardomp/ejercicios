using System;
public class exercise070
{
    public static void Main()
    {
        double width;
        double height;
        double perimeter, area, diagonal;

        do
        {
            Console.Write("Ingrese el ancho deseado: ");
            width = Convert.ToDouble(Console.ReadLine());

            if (width != 0)
            {

                Console.Write("Ingrese la altura deseada: ");
                height = Convert.ToDouble(Console.ReadLine());

                perimeter = width * 2 + height * 2;
                Console.WriteLine("Perímetro: {0}", perimeter);

                area = width * height;
                Console.WriteLine("Area: {0} ", area);

                diagonal = Math.Sqrt((width * width) + (height * height));
                Console.WriteLine("Diagonal: {0} ", diagonal);
            }
        }
        while (width != 0);
    }
}