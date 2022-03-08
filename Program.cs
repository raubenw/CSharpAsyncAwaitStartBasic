using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace CSharpAsyncAwaitStartBasic
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("\nStarting app...");
            // Download();
            DownloadHttp();

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

        static async void Download()
        {
            // await Network.Download();
            Console.WriteLine("\nNetwork download complete");
        }

        static async void DownloadHttp()
        {
            HttpClient client = new HttpClient();
            var data = await client.GetStringAsync("https://dijisol.com");
            Console.WriteLine("\nThe home page of dijisol has been downloaded: \n{0}\n", data.ToString());
        }
    }

    class Network
    {
        static public Task Download()
        {
            return Task.Run(() =>
            {
                Thread.Sleep(5000);
            });
        }
    }
}