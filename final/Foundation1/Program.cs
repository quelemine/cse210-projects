using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos and add comments
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Introduction to C#", "Alex Christensen", 600);
        video1.AddComment("Alice", "Great introduction!");
        video1.AddComment("Bob", "Very informative.");
        video1.AddComment("Charlie", "Helped me a lot!");

        Video video2 = new Video("Advanced C# Techniques", "Jane Smith", 1200);
        video2.AddComment("Dave", "Loved the advanced topics!");
        video2.AddComment("Eve", "More examples would be nice.");
        video2.AddComment("Frank", "Awesome presentation!");

        Video video3 = new Video("C# Best Practices", "Tom Brown", 900);
        video3.AddComment("Grace", "Very useful tips.");
        video3.AddComment("Heidi", "Excellent content.");
        video3.AddComment("Ivy", "Will implement these practices.");

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video details and comments
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}