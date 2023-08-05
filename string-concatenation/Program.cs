using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "I started to play the piano when I was 9 years old.";

      string middle = "I was good in math and nusic, and I for that reason, I decided to go the university to study music, but ...";

      string end = "finally, my love for math, and science was bigger, and I decided to become an Engineer in Electronics.";

      // Concatenate the string and the variables
      string story = beginning + " " + middle + " " + end + "!!!" + "\n";

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
