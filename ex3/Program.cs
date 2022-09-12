namespace ex3
{
    internal class Program
    {
        
        
            static void Main(string[] args)
            {
                //Console.Write("Enter the width and height of an image");
                Console.Write("Enter the width of an image: ");

                string? widthStr = Console.ReadLine();
                int widthInt = Convert.ToInt32(widthStr);

                Console.Write("Enter the height of an image: ");

                string? heightStr = Console.ReadLine();
                int heightInt = Convert.ToInt32(heightStr);

                if (widthInt > heightInt)
                {
                    Console.Write("The image is landscape");
                }
                else
                {
                    Console.Write("The image is portrait");
                }

            }

        
    }
}