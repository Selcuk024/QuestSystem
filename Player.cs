using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestSystem
{
    internal class Player
    {
        List<Quests> ActiveQuests = new List<Quests>();
        public string currentQuest;
        int points = 0;
        public bool hasAQuest = false;
        public bool chosenAQuest = false;
        public void  addQuest(Quests quest)
        {
            ActiveQuests.Add(quest);
        }
        public void AddPoint()
        {
            points++;
        }
        public void RemovePoint()
        {
            points--;
        }
        public void showActiveQuests()
        {
            for (int i = 0; i < ActiveQuests.Count; i++)
            {
                Console.WriteLine(ActiveQuests[i]);

            }
        }
    }
}
