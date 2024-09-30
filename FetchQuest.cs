using System;
using System.Collections.Generic;

namespace QuestSystem
{
    class FetchQuest : Quests
    {
        public List<string> whatToFetch = new List<string> { "Crystals", "Coins", "Cubes", "Orbs" }; 

        public FetchQuest(int id, string questCat, string description, bool isCompleted) : base(id, questCat, description, isCompleted)
        {
        }

        public void showFetchList()
        {
            int index = random.Next(whatToFetch.Count); 
            Console.WriteLine(whatToFetch[index]);
        }
        public string fetchQuest()
        {
            int randomizer = random.Next(whatToFetch.Count);
            string item = whatToFetch[randomizer];
            return item;

        }
 
    }
}
