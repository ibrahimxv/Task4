int i = Convert.ToInt32(Console.ReadLine());

if (i == 1)
{
    Console.WriteLine("Quvvetidir");

}
else
{
    while (i > 1)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine("Quvveti deyil");
            break;
        }

        i = i / 2;

        if (i == 1)
        {
            Console.WriteLine("Quvvetidir");
        }
    }
}