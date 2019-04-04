using System;
using System.Linq;
using System.Net.NetworkInformation;

namespace MACIDCheck
{
    class Program
    {

        public string  getMACWithNetworkInterface()
        {
            NetworkInterface[] netWorkInterface = NetworkInterface.GetAllNetworkInterfaces();
            var ethernet = netWorkInterface.Where(network => network.NetworkInterfaceType == NetworkInterfaceType.Ethernet && network.Name.Equals("Ethernet")).FirstOrDefault();
            String sMacAddress = ethernet == null ? string.Empty : ethernet.GetPhysicalAddress().ToString();
            return sMacAddress;
               
        }

       

        static void Main(string[] args)
        {
            Program pg = new Program();
            Console.WriteLine("MACID with Network Interface : {0}",pg.getMACWithNetworkInterface());
            Console.ReadKey();

        }
    }
}
