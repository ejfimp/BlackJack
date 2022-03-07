namespace BlackJack
{
    public partial class Form1 : Form
    {
        List<Card> deck = new();
        Player dealer = new();
        Player player = new();

        public Form1()
        {
            InitializeComponent();
            balanceLabel.Text = "$" + player.Balance.ToString();
        }

        private void NewRoundButtonClick(object sender, EventArgs e)
        {
            player.Balance -= player.CurrentBet;
            NewRound();
            dealerTimer.Stop();
        }
        private void HitButtonClick(object sender, EventArgs e)
        {
            if (deck.Count != 0)
            {
                if (player.visibleHand.Count >= 5)
                {
                    playerHandListLabel.Visible = true;
                    playerHandList.Visible = true;
                    player.invisibleHand.Insert(0, player.visibleHand[0]);
                    player.visibleHand.RemoveAt(0);
                }
                player.visibleHand.Add(deck[0]);
                deck.RemoveAt(0);
                TableRefresh();
            }
            else
            {
                MessageBox.Show("No more cards in the deck, the dealer wins!");
            }
        }
        private void StayButtonClick(object sender, EventArgs e)
        {
            StopGame();
            dealerTimer.Enabled = true;
        }
        private void DealerTimer_Tick(object sender, EventArgs e)
        {
            if (deck.Count != 0)
            {
                if (dealer.visibleHand.Count >= 5)
                {
                    dealerHandListLabel.Visible = true;
                    dealerHandList.Visible = true;
                    dealer.invisibleHand.Insert(0, dealer.visibleHand[0]);
                    dealer.visibleHand.RemoveAt(0);
                }
                hiddenCard.Visible = false;
                dealer.visibleHand.Add(deck[0]);
                deck.RemoveAt(0);
                TableRefresh();
            }
            else
            {
                dealerTimer.Stop();
                MessageBox.Show("No more cards in the deck, the dealer wins!");

            }

        }
        private void BetValueClick(object sender, EventArgs e)
        {
            Button betButton = (Button)sender;
            int buttonValue = 0;
            if (betButton.Text == "All In")
            {
                player.CurrentBet = player.Balance;
            }
            else
            {
                buttonValue = Convert.ToInt32(betButton.Text.Remove(0, 1));
                player.CurrentBet += buttonValue;
            }

            if (player.CurrentBet > player.Balance)
            {
                MessageBox.Show("You can't bet more than your current balance");
                player.CurrentBet -= buttonValue;
            }

            else
            {
                currentBetLabel.Text = "$" + player.CurrentBet.ToString();
                newRoundButton.Enabled = true;
            }

        }
        private void ClearBetClick(object sender, EventArgs e)
        {
            newRoundButton.Enabled = false;
            player.CurrentBet = 0;
            currentBetLabel.Text = "$0";
        }

        private void NewDeck()
        {
            //create new deck
            deck.Clear();
            for (int i = 0; i < 4; i++)
                for (int j = 1; j < 14; j++)
                    deck.Add(new Card((Card.Suits)i, (Card.Values)j));

            //shuffle deck
            Random rnd = new();
            deck = deck.OrderBy(i => rnd.Next()).ToList();
        }
        private void NewRound()
        {            
            player.visibleHand.Clear();
            player.invisibleHand.Clear();
            dealer.visibleHand.Clear();
            dealer.invisibleHand.Clear();
            if (deck.Count < 17)
                NewDeck();

            int new_game = 0;
            bool player_turn = true;

            hiddenCard.Visible = true;
            dealerCard1.Visible = true;
            dealerCard2.Visible = false;
            dealerCard3.Visible = false;
            dealerCard4.Visible = false;
            dealerCard5.Visible = false;
            dealerHandListLabel.Visible = false;
            dealerHandList.Visible = false;
            dealer.CurrentPoints = 0;

            playerCard1.Visible = true;
            playerCard2.Visible = true;
            playerCard3.Visible = false;
            playerCard4.Visible = false;
            playerCard5.Visible = false;
            playerHandList.Visible = false;
            playerHandListLabel.Visible = false;
            player.CurrentPoints = 0;

            betButtonOne.Enabled = false;
            betButtonTwo.Enabled = false;
            betButtonThree.Enabled = false;
            betButtonFour.Enabled = false;
            betButtonFive.Enabled = false;
            betButtonSix.Enabled = false;
            betButtonSeven.Enabled = false;
            allInButton.Enabled = false;
            clearBetButton.Enabled = false;

            newRoundButton.Enabled = false;
            hitButton.Enabled = true;
            stayButton.Enabled = true;



            do
            {
                if (player_turn)
                {
                    player.visibleHand.Add(deck[0]);
                    deck.RemoveAt(0);
                    player_turn = false;
                }
                else if (!player_turn)
                {
                    dealer.visibleHand.Add(deck[0]);
                    deck.RemoveAt(0);
                    player_turn = true;
                }
                new_game++;
            }
            while (new_game < 3);

            TableRefresh();
        }
        private void TableRefresh()
        {
            SuitPictureCheck();
            ValuePanelsCheck();
            InvisibleHandsLists();

            player.CalculatePoints();
            playerTotalLabel.Text = player.CurrentPoints.ToString();
            balanceLabel.Text = "$" + player.Balance.ToString();
            dealer.CalculatePoints();
            dealerTotalLabel.Text = dealer.CurrentPoints.ToString();
            CheckWinner();
        }
        private void InvisibleHandsLists()
        {
            dealerHandList.Clear();
            playerHandList.Clear();
            foreach (var item in dealer.invisibleHand)            
                dealerHandList.Text += item.Suit.ToString() + " " + item.Value.ToString() + "\n";            
            foreach (var item in player.invisibleHand)            
                playerHandList.Text += item.Suit.ToString() + " " + item.Value.ToString() + "\n";
        }
        private void CheckWinner()
        {
            bool winnerFound = false;
            if (player.CurrentPoints == 21 && player.visibleHand.Count == 2)
            {
                StopGame();
                MessageBox.Show($"You got BlackJack, you win ${player.CurrentBet * 2.5}!", "Winner");
                player.Balance += player.CurrentBet * 1.5;
                winnerFound = true;
            }
            else if (player.CurrentPoints > 21)
            {
                StopGame();
                MessageBox.Show("Bust, you lost!", "Loser");
                winnerFound = true;
                GameOverCheck();
            }
            else if (dealer.CurrentPoints > 21)
            {
                StopGame();
                MessageBox.Show($"Dealer Bust, you won ${player.CurrentBet * 2} ", "Winner");
                player.Balance += player.CurrentBet * 2;
                winnerFound = true;
            }
            else if (dealer.CurrentPoints > 16 && dealer.CurrentPoints < 22)
            {
                if (dealer.CurrentPoints >= player.CurrentPoints)
                {
                    StopGame();
                    MessageBox.Show("You lost", "Loser");
                    winnerFound = true;
                    GameOverCheck();
                }
                else if (player.CurrentPoints > dealer.CurrentPoints)
                {
                    StopGame();
                    MessageBox.Show("You won", "Winner");
                    player.Balance += player.CurrentBet * 2;
                    winnerFound = true;
                }
            }
            if (winnerFound)
            {
                player.CurrentBet = 0;
                currentBetLabel.Text = "$0";
                BetButtonsEnable();
            }
            balanceLabel.Text = "$" + player.Balance.ToString();
        }
        private void StopGame()
        {
            stayButton.Enabled = false;
            hitButton.Enabled = false;
            dealerTimer.Stop();
        }
        private void GameOverCheck()
        {
            if (player.Balance == 0)
            {
                if (MessageBox.Show("You lost all your money!\n\nStart a new game?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    NewDeck();
                    NewRound();                    
                    player.Balance = 100;
                }
                else
                    Application.Exit();
            }
        }
        private void BetButtonsEnable()
        {
            betButtonOne.Enabled = true;
            betButtonTwo.Enabled = true;
            betButtonThree.Enabled = true;
            betButtonFour.Enabled = true;
            betButtonFive.Enabled = true;
            betButtonSix.Enabled = true;
            betButtonSeven.Enabled = true;
            allInButton.Enabled = true;
            clearBetButton.Enabled = true;
        }
        private void ValuePanelsCheck()
        {
            int i;
            switch (player.visibleHand[0].Value)
            {
                case Card.Values.A:
                    playerCardValue1.Text = player.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.J:
                    playerCardValue1.Text = player.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.Q:
                    playerCardValue1.Text = player.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.K:
                    playerCardValue1.Text = player.visibleHand[0].Value.ToString();
                    break;
                default:
                    i = (int)player.visibleHand[0].Value;
                    playerCardValue1.Text = i.ToString();
                    break;
            }
            switch (player.visibleHand[1].Value)
            {
                case Card.Values.A:
                    playerCardValue2.Text = player.visibleHand[1].Value.ToString();
                    break;
                case Card.Values.J:
                    playerCardValue2.Text = player.visibleHand[1].Value.ToString();
                    break;
                case Card.Values.Q:
                    playerCardValue2.Text = player.visibleHand[1].Value.ToString();
                    break;
                case Card.Values.K:
                    playerCardValue2.Text = player.visibleHand[1].Value.ToString();
                    break;
                default:
                    i = (int)player.visibleHand[1].Value;
                    playerCardValue2.Text = i.ToString();
                    break;
            }
            if (player.visibleHand.Count >= 3)
            {
                switch (player.visibleHand[2].Value)
                {
                    case Card.Values.A:
                        playerCardValue3.Text = player.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.J:
                        playerCardValue3.Text = player.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.Q:
                        playerCardValue3.Text = player.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.K:
                        playerCardValue3.Text = player.visibleHand[2].Value.ToString();
                        break;
                    default:
                        i = (int)player.visibleHand[2].Value;
                        playerCardValue3.Text = i.ToString();
                        break;
                }
            }
            if (player.visibleHand.Count >= 4)
            {
                switch (player.visibleHand[3].Value)
                {
                    case Card.Values.A:
                        playerCardValue4.Text = player.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.J:
                        playerCardValue4.Text = player.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.Q:
                        playerCardValue4.Text = player.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.K:
                        playerCardValue4.Text = player.visibleHand[3].Value.ToString();
                        break;
                    default:
                        i = (int)player.visibleHand[3].Value;
                        playerCardValue4.Text = i.ToString();
                        break;
                }
            }
            if (player.visibleHand.Count >= 5)
            {
                switch (player.visibleHand[4].Value)
                {
                    case Card.Values.A:
                        playerCardValue5.Text = player.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.J:
                        playerCardValue5.Text = player.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.Q:
                        playerCardValue5.Text = player.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.K:
                        playerCardValue5.Text = player.visibleHand[4].Value.ToString();
                        break;
                    default:
                        i = (int)player.visibleHand[4].Value;
                        playerCardValue5.Text = i.ToString();
                        break;
                }
            }
            switch (dealer.visibleHand[0].Value)
            {
                case Card.Values.A:
                    dealerCardValue1.Text = dealer.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.J:
                    dealerCardValue1.Text = dealer.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.Q:
                    dealerCardValue1.Text = dealer.visibleHand[0].Value.ToString();
                    break;
                case Card.Values.K:
                    dealerCardValue1.Text = dealer.visibleHand[0].Value.ToString();
                    break;
                default:
                    i = (int)dealer.visibleHand[0].Value;
                    dealerCardValue1.Text = i.ToString();
                    break;
            }
            if (dealer.visibleHand.Count >= 2)
            {
                switch (dealer.visibleHand[1].Value)
                {
                    case Card.Values.A:
                        dealerCardValue2.Text = dealer.visibleHand[1].Value.ToString();
                        break;
                    case Card.Values.J:
                        dealerCardValue2.Text = dealer.visibleHand[1].Value.ToString();
                        break;
                    case Card.Values.Q:
                        dealerCardValue2.Text = dealer.visibleHand[1].Value.ToString();
                        break;
                    case Card.Values.K:
                        dealerCardValue2.Text = dealer.visibleHand[1].Value.ToString();
                        break;
                    default:
                        i = (int)dealer.visibleHand[1].Value;
                        dealerCardValue2.Text = i.ToString();
                        break;
                }
            }
            if (dealer.visibleHand.Count >= 3)
            {
                switch (dealer.visibleHand[2].Value)
                {
                    case Card.Values.A:
                        dealerCardValue3.Text = dealer.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.J:
                        dealerCardValue3.Text = dealer.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.Q:
                        dealerCardValue3.Text = dealer.visibleHand[2].Value.ToString();
                        break;
                    case Card.Values.K:
                        dealerCardValue3.Text = dealer.visibleHand[2].Value.ToString();
                        break;
                    default:
                        i = (int)dealer.visibleHand[2].Value;
                        dealerCardValue3.Text = i.ToString();
                        break;
                }
            }
            if (dealer.visibleHand.Count >= 4)
            {
                switch (dealer.visibleHand[3].Value)
                {
                    case Card.Values.A:
                        dealerCardValue4.Text = dealer.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.J:
                        dealerCardValue4.Text = dealer.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.Q:
                        dealerCardValue4.Text = dealer.visibleHand[3].Value.ToString();
                        break;
                    case Card.Values.K:
                        dealerCardValue4.Text = dealer.visibleHand[3].Value.ToString();
                        break;
                    default:
                        i = (int)dealer.visibleHand[3].Value;
                        dealerCardValue4.Text = i.ToString();
                        break;
                }
            }
            if (dealer.visibleHand.Count >= 5)
            {
                switch (dealer.visibleHand[4].Value)
                {
                    case Card.Values.A:
                        dealerCardValue5.Text = dealer.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.J:
                        dealerCardValue5.Text = dealer.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.Q:
                        dealerCardValue5.Text = dealer.visibleHand[4].Value.ToString();
                        break;
                    case Card.Values.K:
                        dealerCardValue5.Text = dealer.visibleHand[4].Value.ToString();
                        break;
                    default:
                        i = (int)dealer.visibleHand[4].Value;
                        dealerCardValue5.Text = i.ToString();
                        break;
                }
            }
        }
        private void SuitPictureCheck()
        {
            switch (dealer.visibleHand[0].Suit)
            {
                case Card.Suits.Clubs:
                    dealerCardSuit1.Image = Properties.Resources.clubCard;
                    break;
                case Card.Suits.Diamonds:
                    dealerCardSuit1.Image = Properties.Resources.diamondCard;
                    break;
                case Card.Suits.Hearts:
                    dealerCardSuit1.Image = Properties.Resources.heartCard;
                    break;
                case Card.Suits.Spades:
                    dealerCardSuit1.Image = Properties.Resources.spadeCard;
                    break;
                default:
                    break;
            }
            if (dealer.visibleHand.Count >= 2)
            {
                switch (dealer.visibleHand[1].Suit)
                {
                    case Card.Suits.Clubs:
                        dealerCardSuit2.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        dealerCardSuit2.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        dealerCardSuit2.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        dealerCardSuit2.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                dealerCard2.Visible = true;
            }
            if (dealer.visibleHand.Count >= 3)
            {
                switch (dealer.visibleHand[2].Suit)
                {
                    case Card.Suits.Clubs:
                        dealerCardSuit3.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        dealerCardSuit3.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        dealerCardSuit3.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        dealerCardSuit3.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                dealerCard3.Visible = true;
            }
            if (dealer.visibleHand.Count >= 4)
            {
                switch (dealer.visibleHand[3].Suit)
                {
                    case Card.Suits.Clubs:
                        dealerCardSuit4.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        dealerCardSuit4.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        dealerCardSuit4.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        dealerCardSuit4.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                dealerCard4.Visible = true;
            }
            if (dealer.visibleHand.Count >= 5)
            {
                switch (dealer.visibleHand[4].Suit)
                {
                    case Card.Suits.Clubs:
                        dealerCardSuit5.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        dealerCardSuit5.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        dealerCardSuit5.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        dealerCardSuit5.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                dealerCard5.Visible = true;
            }
            switch (player.visibleHand[0].Suit)
            {
                case Card.Suits.Clubs:
                    playerCardSuit1.Image = Properties.Resources.clubCard;
                    break;
                case Card.Suits.Diamonds:
                    playerCardSuit1.Image = Properties.Resources.diamondCard;
                    break;
                case Card.Suits.Hearts:
                    playerCardSuit1.Image = Properties.Resources.heartCard;
                    break;
                case Card.Suits.Spades:
                    playerCardSuit1.Image = Properties.Resources.spadeCard;
                    break;
                default:
                    break;
            }
            switch (player.visibleHand[1].Suit)
            {
                case Card.Suits.Clubs:
                    playerCardSuit2.Image = Properties.Resources.clubCard;
                    break;
                case Card.Suits.Diamonds:
                    playerCardSuit2.Image = Properties.Resources.diamondCard;
                    break;
                case Card.Suits.Hearts:
                    playerCardSuit2.Image = Properties.Resources.heartCard;
                    break;
                case Card.Suits.Spades:
                    playerCardSuit2.Image = Properties.Resources.spadeCard;
                    break;
                default:
                    break;
            }
            if (player.visibleHand.Count >= 3)
            {
                switch (player.visibleHand[2].Suit)
                {
                    case Card.Suits.Clubs:
                        playerCardSuit3.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        playerCardSuit3.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        playerCardSuit3.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        playerCardSuit3.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                playerCard3.Visible = true;
            }
            if (player.visibleHand.Count >= 4)
            {
                switch (player.visibleHand[3].Suit)
                {
                    case Card.Suits.Clubs:
                        playerCardSuit4.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        playerCardSuit4.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        playerCardSuit4.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        playerCardSuit4.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                playerCard4.Visible = true;
            }
            if (player.visibleHand.Count >= 5)
            {
                switch (player.visibleHand[4].Suit)
                {
                    case Card.Suits.Clubs:
                        playerCardSuit5.Image = Properties.Resources.clubCard;
                        break;
                    case Card.Suits.Diamonds:
                        playerCardSuit5.Image = Properties.Resources.diamondCard;
                        break;
                    case Card.Suits.Hearts:
                        playerCardSuit5.Image = Properties.Resources.heartCard;
                        break;
                    case Card.Suits.Spades:
                        playerCardSuit5.Image = Properties.Resources.spadeCard;
                        break;
                    default:
                        break;
                }
                playerCard5.Visible = true;
            }

        }
    }
}