using System;
using System.Collections.Generic;

namespace YouTubeAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create sample videos
            Video video1 = new Video("How to Cook Pasta", "Chef Tony", 420);
            Video video2 = new Video("Unity Game Dev Basics", "DevGirl", 900);
            Video video3 = new Video("Top 10 Skyrim Mods", "LoreMaster", 780);

            // Add comments to video1
            video1.AddComment(new Comment("Alice", "This was super helpful!"));
            video1.AddComment(new Comment("Bob", "I burned my noodles "));
            video1.AddComment(new Comment("Charlie", "Chef Tony never misses."));

            // Add comments to video2
            video2.AddComment(new Comment("Diana", "Great intro to Unity!"));
            video2.AddComment(new Comment("Eli", "Can you do a C# deep dive next?"));
            video2.AddComment(new Comment("Frank", "Loved the pacing."));

            // Add comments to video3
            video3.AddComment(new Comment("Gwen", "Mod #4 changed my life."));
            video3.AddComment(new Comment("Henry", "Where’s the link to mod #7?"));
            video3.AddComment(new Comment("Ivy", "Perfect list for new players."));

            // Add videos to list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Display video info
            foreach (Video video in videos)
            {
                Console.WriteLine($"Title: {video.Title}");
                Console.WriteLine($"Author: {video.Author}");
                Console.WriteLine($"Length: {video.Length} seconds");
                Console.WriteLine($"Comments ({video.GetCommentCount()}):");

                foreach (Comment comment in video.Comments)
                {
                    Console.WriteLine($" - {comment.CommenterName}: \"{comment.Text}\"");
                }

                Console.WriteLine(new string('-', 40));
            }
        }

        class Video
        {
            public string Title { get; }
            public string Author { get; }
            public int Length { get; }
            public List<Comment> Comments { get; }

            public Video(string title, string author, int length)
            {
                Title = title;
                Author = author;
                Length = length;
                Comments = new List<Comment>();
            }

            public void AddComment(Comment comment)
            {
                Comments.Add(comment);
            }

            public int GetCommentCount()
            {
                return Comments.Count;
            }
        }

        class Comment
        {
            public string CommenterName { get; }
            public string Text { get; }

            public Comment(string commenterName, string text)
            {
                CommenterName = commenterName;
                Text = text;
            }
        }
    }
}