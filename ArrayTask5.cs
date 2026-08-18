int i = Convert.ToInt32 (Console.ReadLine ());
int count = 0;

while (i > 0)
{
    i=i / 10;
    count ++;
}
Console.WriteLine(count);