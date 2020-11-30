using System;

namespace Exercise2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post("New review on code", "I fucking suck at this shit");
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.DownVote();
            Console.WriteLine(post.GetPost());
        }
    }
}
