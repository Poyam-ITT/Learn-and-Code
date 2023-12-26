namespace Devices
{
    public class Smartphone : IDevice
    {
        public void DisplayDetails()
        {
            Console.WriteLine("Smartphone: Model X, RAM: 8GB, Storage: 128GB");
        }
    }
}