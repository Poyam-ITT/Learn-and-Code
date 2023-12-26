namespace Devices
{
    class DeviceFactoryApp
    {
        static void Main()
        {
            IDeviceFactory smartphoneFactory = new SmartphoneFactory();
            IDeviceFactory laptopFactory = new LaptopFactory();

            IDevice smartphone = smartphoneFactory.CreateDevice();
            IDevice laptop = laptopFactory.CreateDevice();

            smartphone.DisplayDetails();
            laptop.DisplayDetails();
        }
    }
}