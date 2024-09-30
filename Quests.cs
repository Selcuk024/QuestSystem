using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestSystem
{
    internal class Quests
    {
        public Random random = new Random();

        int id;
        string questCat
        string description;
        bool isCompleted;
        public Quests(int id, string questCat, string description, bool isCompleted)
        {
            this.id = id++;
            this.questCat = questCat;
            this.description = description;
            this.isCompleted = isCompleted;
        }

        public void Reward(Player player)
        {
            isCompleted = true;
            player.AddPoint();
        }
        public bool checkCompleted()
        {
            return isCompleted;
        }
        public void completeQuest()
        {
            if (isCompleted == false)
            {
                isCompleted = true;
            }
        }
        public override string ToString()
        {
            return description;
        }

    }
}
