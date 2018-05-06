using System;
using Intercom.Clients;
using Intercom.Core;

namespace usingdotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            UsersClient usersClient = new UsersClient(new Authentication("MyPersonalAccessToken"));
            Console.WriteLine("Hello World!");
        }
    }
}
