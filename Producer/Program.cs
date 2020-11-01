using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    class Program
    {
        private static IPEndPoint consumerEndPoint;

        static void Main(string[] args)
        {
            var consumerIP = ConfigurationManager.AppSettings.Get("consumerIP");
            var consumerPort = int.Parse(ConfigurationManager.AppSettings.Get("consumerPort"));
            consumerEndPoint = new IPEndPoint(IPAddress.Parse(consumerIP), consumerPort);
            Console.WriteLine($"consumer: {consumerEndPoint}");
        }
    }
}
