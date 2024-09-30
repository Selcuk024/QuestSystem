using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestSystem
{
    internal class KillQuest : Quests
    {
        List<string> Targets = new List<string>() {"mangler", "abomination", "margwa" };

        public KillQuest(int id, string questCat, string description, bool isCompleted) : base(id, questCat, description, isCompleted)
        {
        }
        public string getKillQuest()
        {
            int number = random.Next(Targets.Count);
            string target = Targets[number];
            return target;
        }

    }
}
