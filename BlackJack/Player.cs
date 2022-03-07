using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Player
    {
        private double balance = 100;
        private int currentPoints = 0;
        private double currentBet = 0;
        public List<Card> visibleHand = new();
        public List<Card> invisibleHand = new(); //used when the visible hand exceeds five cards

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int CurrentPoints
        {
            get { return currentPoints; }
            set { currentPoints = value; }
        }
        public double CurrentBet
        {
            get { return currentBet; }
            set { currentBet = value; }
        }        
        public void CalculatePoints()
        {
            int temp_player_points = 0;
            bool ace_found = false;

            foreach (var card in visibleHand)
            {
                temp_player_points += (int)card.Value;

                switch ((int)card.Value)
                {
                    case 11:
                        temp_player_points -= 1;
                        break;
                    case 12:
                        temp_player_points -= 2;
                        break;
                    case 13:
                        temp_player_points -= 3;
                        break;
                    default:
                        break;
                }
                if ((int)card.Value == 1)
                {
                    ace_found = true;
                }
            }
            if (ace_found && temp_player_points + 10 < 22)
            {
                temp_player_points += 10;
            }
            CurrentPoints = temp_player_points;
        }
    }
}
