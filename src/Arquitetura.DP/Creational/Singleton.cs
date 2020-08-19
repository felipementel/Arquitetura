using System;
using System.Collections.Generic;

namespace Arquitetura.DP.Creational
{
    internal sealed class LoadBalancer
    {
        // Static members are 'eagerly initialized', that is, 
        // immediately when class is loaded for the first time.
        // .NET guarantees thread safety for static initialization
        private static readonly LoadBalancer Instance = new LoadBalancer();

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server> 
        { 
         new Server{ Name = "ServerI", IP = "120.14.220.18" },
         new Server{ Name = "ServerII", IP = "120.14.220.19" },
         new Server{ Name = "ServerIII", IP = "120.14.220.20" },
         new Server{ Name = "ServerIV", IP = "120.14.220.21" },
         new Server{ Name = "ServerV", IP = "120.14.220.22" },
        };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return Instance;
        }

        // Load balancer
        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }

    internal class Server
    {
        public string Name { get; set; }

        public string IP { get; set; }
    }

    public class Singleton
    {
        public static void Execucao()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Mesma instância\n");
            }

            var balancer = LoadBalancer.GetLoadBalancer();
            for (var i = 0; i < 15; i++)
            {
                var serverName = balancer.NextServer.Name;
                Console.WriteLine("Disparando request para: " + serverName);
            }
        }
    }
}