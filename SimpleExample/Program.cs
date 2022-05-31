using System;
using SMA.AlgorithmPlatform.CSharpClient;

namespace SimpleExample {
    public static class Program {
        static void Main(string[] args) {
            var url = new Uri(args[1]);
            var algorithmInterface = AlgorithmInterfaceFactory.Create(url);

            algorithmInterface.NotifyUser("Hello World Algorithm", "Hello Algorithm World!");
        }
    }
}
