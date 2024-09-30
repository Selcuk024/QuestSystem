using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestSystem
{
    internal class QuestGiver
    {
        Random random = new Random();
        public List<string> WelcomeDialogue = new List<string> {"Which quest would you like to go ahead and complete? Fetching or Killing. You can always type 'help' incase you need any help!", "Welcome wonderer would you like a Fetch quest or a Kill quest? Need help? write 'help' " };
        Quests fetchedQuest;
        public QuestGiver()
        {

        }
        public void getFetchQuest()
        {
            FetchQuest newFetch = new FetchQuest(1, "fetch quest" ,"Collect the shown items", false);
            fetchedQuest = newFetch;
        }
        public void giveQuest(Player player)
        {
            player.addQuest(fetchedQuest);
        }
        public void getKillQuest()
        {
            KillQuest newFetch = new KillQuest(1, "kill quest", "Kill the enemy", false);
            fetchedQuest = newFetch;
        }
        public string firstInteraction()
        {
            int number = random.Next(WelcomeDialogue.Count);
            return WelcomeDialogue[number];
        }
    }
}
