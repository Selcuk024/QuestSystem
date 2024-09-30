using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestSystem
{
    internal class Dialogues
    {
        List<string> dialogue = new List<string>() {
            "Choose a quest by filling in which kind of quest you would like, you can choose between kill quests and fetch quests, after selecting the corresponding quest you may complete them by either doing an attack move (if you have a kill quest active) or a collect move(if you have a fetching quest active) you may just type in the word 'kill' or 'collect'. You can check your active quests by typing 'active quests' any time",
            "You have selected a fetching quest, kill the enemy in order to earn your reward",
            "You have seleceted a fetching quest, collect the correct item in order to get your reward",
            "Choose which quest you would like to activate, this will be the quest you want to do at the moment"
        };

        public string helpDialogue()
        {
            return dialogue[0];
        }
        public string killDialogue()
        {
            return dialogue[1];
        }
        public string fetchDialogue()
        {
            return dialogue[2];
        }
        public string selectQuest()
        {
            return dialogue[3];
        }
    }   
}
