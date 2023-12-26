namespace Devices
{
    public class LaptopFactory : IDeviceFactory
    {
        public IDevice CreateDevice()
        {
            return new Laptop();
        }
    }
}