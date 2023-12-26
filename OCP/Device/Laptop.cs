namespace Devices
{
    public class Laptop : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Laptop: Model Y, RAM: 16GB, Storage: 512GB");
        }
    }
}