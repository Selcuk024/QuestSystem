namespace QuestSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuestGiver questGiver = new QuestGiver();
            Player player = new Player();
            Dialogues dialogues = new Dialogues();
            string yesOrNo;
            do
            {

            
            while (!player.chosenAQuest)
            {
                Console.WriteLine(questGiver.firstInteraction());
                string answer = Console.ReadLine().ToLower();
                if (answer == "fetch")
                {
                    questGiver.getFetchQuest();
                    questGiver.giveQuest(player);
                        player.showActiveQuests();
                    player.chosenAQuest = true;
                }
                else if (answer == "kill")
                {
                    questGiver.getKillQuest();
                    questGiver.giveQuest(player);
                        player.showActiveQuests();
                    player.chosenAQuest = true;
                }
                else if (answer == "help")
                {
                    Console.WriteLine(dialogues.helpDialogue());
                }

            }
                Console.WriteLine("Would you like to get another quest?");
                yesOrNo = Console.ReadLine().ToLower();
                if (yesOrNo == "yes")
                {
                    player.chosenAQuest = false;
                }
            } while (yesOrNo == "yes");

            while (!player.hasAQuest)
            {
                Console.WriteLine(dialogues.selectQuest());
                string answer = Console.ReadLine().ToLower();
                if  (answer == "fetch")
                {
                    player.currentQuest = "Fetching Quest";
                    player.hasAQuest = true;
                }
                else if(answer == "kill")
                {
                    player.currentQuest = "Killing Quest";
                    player.hasAQuest = true;
                }
                else if (answer == "help")
                {
                    Console.WriteLine(dialogues.helpDialogue());
                }
            }
            if (player.currentQuest == "Fetching Quest")
            {
                Console.WriteLine(dialogues.fetchDialogue());
                string move = Console.ReadLine().ToLower();
                if (move == "collect")
                {
                    player.showActiveQuests();
                }
                
            }
        }
    }
}
