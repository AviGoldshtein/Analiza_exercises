using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.IO;   ///////////////////////

namespace HttpExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool runing = true;
            while (runing)
            {
                if (!ShowMenw()) runing = false;
            }


            //ReadMyOnwFile();








            //string url = "http://localost:5000/";
            //HttpListener listener = new HttpListener();
            //listener.Prefixes.Add(url);

            //listener.Start();
            //Console.WriteLine($"server started at: {url}");

            //while (true)
            //{
            //    HttpListenerContext context = await listener.GetContextAsync();
            //    _ = Task.Run(() => HandalRequest(context));
            //}
        }


        public static void ReadMyOnwFile()
        {
            string path = "C:\\Users\\a0548\\MyGit\\myFile.txt";
            string content = File.ReadAllText(path);
            content = content.ToUpper();
            Console.WriteLine(content);
        }

        public static bool ShowMenw()
        {
            bool continu = true;

            Console.WriteLine("\n1. to write to a file\n" +
                "2. to read from a file\n" +
                "3. to stop the program\n");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteToFile();
                    break;
                case "2":
                    ReadFromFile();
                    break;
                case "3":
                    Console.WriteLine("have a good day");
                    continu = false;
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            return continu;
        }


        public static void WriteToFile()
        {
            Console.WriteLine("enter text to write in a file");
            string text = Console.ReadLine();
            Console.WriteLine("enter the name of the file (without ending)");
            string fileName = Console.ReadLine();
            string path = $"C:\\Users\\a0548\\source\\repos\\HttpExercise\\HttpExercise\\{fileName}.txt";
            File.WriteAllText(path, text);
        }

        public static void ReadFromFile()
        {
            Console.WriteLine("enter the name of the file that you want to read from (without ending)");
            string fileName = Console.ReadLine();
            //fileName = fileName.Split('.')[0];
            string path = $"C:\\Users\\a0548\\source\\repos\\HttpExercise\\HttpExercise\\{fileName}.txt";
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("this file dosent exsist");
            }
        }


        //public static void HandalRequest(HttpListenerContext context)
        //{
        //    string method = context.Request.HttpMethod;
        //    string rawUrl = context.Request.RawUrl;

        //    Console.WriteLine($"requst: Method:: {method} Row Url:: {rawUrl}");

        //}



















        //public static HttpClient client;

        //public static async Task GetAsync()
        //{
        //    HttpClient client = new HttpClient();
        //    var response = await client.GetAsync("http://localhost:5000/api/home");
        //    string aaaaaa = response.Content.ReadAsStringAsync();
        //    HttpRequestMessage response = 
        //}

    }
}
