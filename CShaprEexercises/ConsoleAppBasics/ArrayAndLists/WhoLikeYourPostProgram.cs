using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBasics.ArrayAndLists
{
    /// <summary>
    /// exercise 1 ArrayAndLists
    /// </summary>
    class WhoLikeYourPostProgram : IConsoleAplication
    {
        public void ShowOnConsole()
        {
            List<string> peopleWhoLikeYourPost = new List<string>();

            getPeopleWhoLikeYourPost(peopleWhoLikeYourPost);

            displayResult(peopleWhoLikeYourPost);

        }

        private static void displayResult(List<string> peopleWhoLikeYourPost)
        {
            if (peopleWhoLikeYourPost.Count == 0)
                return;
            if (peopleWhoLikeYourPost.Count == 1)
            {
                Console.WriteLine("{0} likes your post", peopleWhoLikeYourPost[0]);
                return;
            }
            if (peopleWhoLikeYourPost.Count == 2)
            {
                Console.WriteLine(
                    "{0} and {1} like your post"
                    , peopleWhoLikeYourPost[0],
                    peopleWhoLikeYourPost[1]
                    );
                return;
            }

            Console.WriteLine(
                "{0}, {1} and {2} others like your post",
                peopleWhoLikeYourPost[0],
                peopleWhoLikeYourPost[1],
                peopleWhoLikeYourPost.Count - 2
                );
        }

        private static void getPeopleWhoLikeYourPost(List<string> peopleWhoLikeYourPost)
        {
            while (true)
            {
                Console.WriteLine
                    ("please enter name, or press Enter to finish program");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                if (!peopleWhoLikeYourPost.Contains(input))
                    peopleWhoLikeYourPost.Add(input);

            }
        }
    }
}
