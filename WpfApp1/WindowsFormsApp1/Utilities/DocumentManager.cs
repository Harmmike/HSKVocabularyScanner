using System;
using System.Collections.Generic;
using System.IO;

namespace WindowsFormsApp1.Utilities
{
    public static class DocumentManager
    {
        private const string BASE_FILEPATHS = ".\\Data\\hskvocablist";

        public static List<string> HSKLevelOne;
        public static List<string> HSKLevelTwo;
        public static List<string> HSKLevelThree;
        public static List<string> HSKLevelFour;
        public static List<string> HSKLevelFive;
        public static List<string> HSKLevelSix;

        public static List<string> AllWords;

        static DocumentManager()
        {
            HSKLevelOne = new List<string>();
            HSKLevelTwo = new List<string>();
            HSKLevelThree = new List<string>();
            HSKLevelFour = new List<string>();
            HSKLevelFive = new List<string>();
            HSKLevelSix = new List<string>();
            AllWords = new List<string>();

            LoadVocabLists();
        }

        private static void LoadVocabLists()
        {
            Dictionary<int, List<string>> lists = new Dictionary<int, List<string>>();
            lists.Add(1, HSKLevelOne);
            lists.Add(2, HSKLevelTwo);
            lists.Add(3, HSKLevelThree);
            lists.Add(4, HSKLevelFour);
            lists.Add(5, HSKLevelFive);
            lists.Add(6, HSKLevelSix);

            for (int i = 1; i <= 3; i++)
            {
                if (!File.Exists($"{BASE_FILEPATHS}{i}.txt"))
                {
                    throw new Exception("My file not found");
                }

                string[] words = File.ReadAllLines($"{BASE_FILEPATHS}{i}.txt");

                foreach (var word in words)
                {
                    AllWords.Add(word);
                    lists[i].Add(word);
                }
            }
        }
    }
}
