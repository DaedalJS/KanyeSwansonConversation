using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace RonyeWestsonConversation
{
    class Program
    {
        
        static int QuoteCount()
        {
            bool gavenumb = false;
            int numb;
            do
            {
                gavenumb = int.TryParse(Console.ReadLine(), out numb);

                if (gavenumb == false) { Console.WriteLine("Give a Whole Number"); }

            }
            while (gavenumb == false);
            

            return numb;

        }

        static void Main(string[] args)
        {


            Console.WriteLine("You walk into a bar. it hurts. \n " +
                "looking around you find that that most everyone else is as pathetically unaware of their surroundings as you are. \n" +
                "several people are shambling by like zombies. phones in hand and eyes glued to the glowing screens, \n" +
                "one almost walks right into you before changing course without so much as a glance or apology tossed your way. \n" +
                "as you decide to go about your business again you notice Kanye West and Ron Swanson having what appears to be a lively conversation at a bus stop. \n" +
                "no one else seems to notice them. thinking this will be an interesting story to share with your 12 whole followers on twitter you decide to be rude and drop some eaves.\n");

            Console.WriteLine("how many exchanges would you like to listen in on?");

            bool gaveNeg = false;
            int convLength = QuoteCount();
            if (convLength < 0) {gaveNeg = true; convLength = Math.Abs(convLength); }

            if (gaveNeg == true) { Console.WriteLine($"Try as you might you can't unhear the {convLength} exchanges you listened in on. \n" +
                $"the scene replays in your mind as you feel a little dumber having heard it. \n"); }
            if (convLength == 0) { Console.WriteLine("overcome with the realization that you're about to be incredibly rude the guilt drives you to go about your business."); }
            else
            {
                int i;
                for (i = convLength; i > 0; i--)
                {
                    if (i %2 == 0) { Console.WriteLine("Kanye: " + QuoteGrabber.KanyeQuote() + "\n"); } else { Console.WriteLine("Ron: " + QuoteGrabber.SwansonQuote() + "\n"); }
                    System.Threading.Thread.Sleep(1000);
                }
                Console.WriteLine("finally realizing how rude you're being, you decide to leave and never mention what you've heard to anyone. \n ");

            }
            Console.WriteLine("\n press enter to quit");
            Console.ReadLine();
            

        }
    }
}
