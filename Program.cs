namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			Semaphore MySemaphore;
			MySemaphore = Semaphore.Green;
			Console.WriteLine(MySemaphore);
		}
	}
	enum Semaphore
	{
		Red = 100,
		Yellow = 200,
		Green = 300
	}
}