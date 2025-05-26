using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace ApiHttpExercise
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            string path = "https://jsonplaceholder.typicode.com/posts";

            List<Post> posts = await FatchPosts(path);
            PrintListPosts(posts);
            PrintFiveFirstTitls(posts);
            showPostById(posts);
            AskForPostDetails();
            await SendPost(path);
            await UpdatePost(path);
            await DounloadPicther();
            await GetTenPostInTheSameTime();
            await GetTenPostNotInTheSameTime();
        }


        public static HttpClient client = new HttpClient();

        public static async Task<List<Post>> FatchPosts(string path)
        {
            HttpResponseMessage response = await client.GetAsync(path);
            response.EnsureSuccessStatusCode();
            string content = await response.Content.ReadAsStringAsync();
            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(content);
            return posts;
        }
        public static void showPostById(List<Post> posts)
        {
            Console.WriteLine("enter the ID (1-100)");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int id))
            {
                if (id >= 0 && id <= 100)
                {
                    foreach (Post post in posts)
                    {
                        if (post.id == id)
                        {
                            Console.WriteLine($"Post ID: {post.id}\n" +
                                $"Title: {post.title}\n" +
                                $"Body: {post.body}");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("enter numers betwean 1 - 100");
                }
            }
            else
            {
                Console.WriteLine("enter only numbers");
            }
        }
        public static void PrintFiveFirstTitls(List<Post> posts)
        {
            int len = posts.Count();
            if (len > 5) len = 5;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(posts[i].title);
            }
        }
        public static void PrintListPosts(List<Post> posts)
        {
            foreach (Post post in posts)
            {
                Console.WriteLine(post);
            }
        }
        public class Post
        {
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }

            public override string ToString()
            {
                return $"userId: {userId}\n" +
                    $"id: {id}\n" +
                    $"title: {title}\n" +
                    $"body: {body}\n";
            }
        }
        public static async Task SendPost(string path)
        {
            var details = AskForPostDetails();
            int id = details.Id;
            string titel = details.Titel;
            string body = details.Body;

            var postObject = new
            {
                userId = id,
                titel = titel,
                body = body
            };

            string json = JsonConvert.SerializeObject(postObject);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(path , content);
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Server Response:");
            Console.WriteLine(responseBody);
        }
        public static async Task UpdatePost(string path)
        {
            var details = AskForPostDetails();
            int id = details.Id;
            string titel = details.Titel;
            string body = details.Body;

            var updateObject = new
            {
                userId = details.Id,
                titel = details.Titel,
                body = details.Body
            };

            string json = JsonConvert.SerializeObject(updateObject);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync(path + "/1", content);
            var responseBody = await response.Content.ReadAsStringAsync();
            Console.WriteLine("Server Response:");
            Console.WriteLine(responseBody);
        }
        public static (int Id, string Titel, string Body) AskForPostDetails()
        {
            Console.WriteLine("enter your id");
            string idStr = Console.ReadLine();
            if (int.TryParse(idStr, out int id))
            {
                Console.WriteLine("enter a titel for the post");
                string titel = Console.ReadLine();
                Console.WriteLine("write something for the post");
                string body = Console.ReadLine();
                if (titel != "" && body != "")
                {
                    return (id, titel, body);
                }
                else
                {
                    Console.WriteLine("a titel or body are missing");
                    return AskForPostDetails();
                }
            }
            else
            {
                Console.WriteLine("id must be a number");
                return AskForPostDetails();
            }
        }
        public static async Task DounloadPicther()
        {
            string imageUrl = "https://edgifts4u.com/wp-content/uploads/%D7%9E%D7%A0%D7%95%D7%A8%D7%AA-%D7%9C%D7%99%D7%9C%D7%94-%D7%A6%D7%94%D7%9C.jpg";
            string localPath = "downloaded_image.jpg";

            byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
            File.WriteAllBytes(localPath, imageBytes);

            Console.WriteLine($"Image saved to: {Path.GetFullPath(localPath)}");
        }
        public static async Task GetTenPostInTheSameTime()
        {
            string baseUrl = "https://jsonplaceholder.typicode.com/posts/";

            List<Task<string>> tasks = new List<Task<string>>();
            for (int i = 1; i <= 20; i++)
            {
                tasks.Add(client.GetStringAsync(baseUrl + i));
            }

            string[] results = await Task.WhenAll(tasks);

            for (int i = 0; i < results.Length; i++)
            {
                Post post = JsonConvert.DeserializeObject<Post>(results[i]);
                Console.WriteLine($"[{post.id}] {post.title}");
            }
        }
        public static async Task GetTenPostNotInTheSameTime()
        {
            string baseUrl = "https://jsonplaceholder.typicode.com/posts/";

            for (int i = 1; i <= 20; i++)
            {
                string response = await client.GetStringAsync(baseUrl + i);
                Post post = JsonConvert.DeserializeObject<Post>(response);
                Console.WriteLine($"[{post.id}] {post.title}");
            }
        }
    }
}
