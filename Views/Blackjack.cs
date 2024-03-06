using CasinoForms.Controllers;
using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoForms.Views
{
    public partial class Blackjack : Form
    {
        GameManager gameManager;
        ApplicationManager appManager;
        String message = "place bet to start game";

        List<PictureBox> playerHandPictureBoxes = new List<PictureBox>();
        List<PictureBox> dealerHandPictureBoxes = new List<PictureBox>();
        List<PictureBox> splitHandPictureBoxes = new List<PictureBox>();
        public Blackjack()
        {
            InitializeComponent();
        }

        public Blackjack(GameManager gameManager, ApplicationManager appManager)
        {
            this.gameManager = gameManager;
            this.appManager = appManager;
            playerHandPictureBoxes.Add(card1);
            playerHandPictureBoxes.Add(card2);
            playerHandPictureBoxes.Add(card3);
            playerHandPictureBoxes.Add(card4);
            playerHandPictureBoxes.Add(card5);
            playerHandPictureBoxes.Add(card6);
            playerHandPictureBoxes.Add(card7);

            dealerHandPictureBoxes.Add(dealercard1);
            dealerHandPictureBoxes.Add(dealercard2);
            dealerHandPictureBoxes.Add(dealercard3);
            dealerHandPictureBoxes.Add(dealercard4);
            dealerHandPictureBoxes.Add(dealercard5);
            dealerHandPictureBoxes.Add(dealercard6);
            dealerHandPictureBoxes.Add(dealercard7);

            splitHandPictureBoxes.Add(split1);
            splitHandPictureBoxes.Add(split2);
            splitHandPictureBoxes.Add(split3);
            splitHandPictureBoxes.Add(split4);
            splitHandPictureBoxes.Add(split5);
            splitHandPictureBoxes.Add(split6);
            splitHandPictureBoxes.Add(split7);
            splitHandPictureBoxes.Add(split8);



            InitializeComponent();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalbet_Click(object sender, EventArgs e)
        {

        }


        private void updateBoard()
        {
            Message.Text = message;
            availableFunds.Text ="$" + gameManager.player.money.ToString();
            totalbet.Text = "$" + gameManager.bet.ToString();
            payout.Text = "$" + gameManager.payoutAmount.ToString();
           

        }

        private void updateHands()
        {
            
        }

        private void enableInsurance()
        {

        }

        private Image getCardImage(CardModel card)
        {
            if(card.suit=="Heart")
            {
                switch (card.number)
                {
                    case 1:
                        return Properties.Resources.cardHeartsA;
                    case 2:
                        return Properties.Resources.cardHearts2;
                    case 3:
                        return Properties.Resources.cardHearts3;
                    case 4:
                        return Properties.Resources.cardHearts4;
                    case 5:
                        return Properties.Resources.cardHearts5;
                    case 6:
                        return Properties.Resources.cardHearts6;
                    case 7:
                        return Properties.Resources.cardHearts7;
                    case 8:
                        return Properties.Resources.cardHearts8;
                    case 9:
                        return Properties.Resources.cardHearts9;
                    case 10:
                        return Properties.Resources.cardHearts10;
                    case 11:
                        return Properties.Resources.cardHeartsJ;
                    case 12:
                        return Properties.Resources.cardHeartsQ;
                    case 13:
                        return Properties.Resources.cardHeartsK;

                }

            }
            else if(card.suit=="Diamond")
            {
                switch (card.number)
                {
                    case 1:
                        return Properties.Resources.cardDiamondsA;
                        case 2:
                        return Properties.Resources.cardDiamonds2;
                        case 3:
                        return Properties.Resources.cardDiamonds3;
                        case 4:
                        return Properties.Resources.cardDiamonds4;
                        case 5:
                        return Properties.Resources.cardDiamonds5;
                        case 6:
                        return Properties.Resources.cardDiamonds6;
                        case 7:
                        return Properties.Resources.cardDiamonds7;
                        case 8:
                        return Properties.Resources.cardDiamonds8;
                        case 9:
                        return Properties.Resources.cardDiamonds9;
                        case 10:
                        return Properties.Resources.cardDiamonds10;
                        case 11:
                        return Properties.Resources.cardDiamondsJ;
                        case 12:
                        return Properties.Resources.cardDiamondsQ;
                        case 13:
                        return Properties.Resources.cardDiamondsK;
                        

                }

            }
            else if(card.suit=="Club")
            {
                switch (card.number)
                {
                    case 1:
                        return Properties.Resources.cardClubsA;
                    case 2:
                        return Properties.Resources.cardClubs2;
                        case 3:
                        return Properties.Resources.cardClubs3;
                        case 4:
                        return Properties.Resources.cardClubs4;
                        case 5:
                        return Properties.Resources.cardClubs5;
                        case 6:
                        return Properties.Resources.cardClubs6;
                        case 7:
                        return Properties.Resources.cardClubs7;
                        case 8:
                        return Properties.Resources.cardClubs8;
                        case 9:
                        return Properties.Resources.cardClubs9;
                        case 10:
                            return Properties.Resources.cardClubs10;
                        case 11:
                        return Properties.Resources.cardClubsJ;
                        case 12:
                        return Properties.Resources.cardClubsQ;
                        case 13:
                        return Properties.Resources.cardClubsK;
                }

            }
            else if(card.suit=="Spade")
            {
                switch (card.number)
                {
                    case 1:
                        return Properties.Resources.cardSpadesA;
                        case 2:
                        return Properties.Resources.cardSpades2;
                        case 3:
                        return Properties.Resources.cardSpades3;
                        case 4:
                        return Properties.Resources.cardSpades4;
                        case 5:
                        return Properties.Resources.cardSpades5;
                        case 6:
                        return Properties.Resources.cardSpades6;
                        case 7:
                        return Properties.Resources.cardSpades7;
                        case 8:
                        return Properties.Resources.cardSpades8;
                        case 9:
                        return Properties.Resources.cardSpades9;
                        case 10:
                        return Properties.Resources.cardSpades10;
                        case 11:
                        return Properties.Resources.cardSpadesJ;
                        case 12:
                        return Properties.Resources.cardSpadesQ;
                        case 13:
                        return Properties.Resources.cardSpadesK;

                }

            }
           
                return Properties.Resources.Layer_2;
            
        }

        private void HitButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StandButton_Click(object sender, EventArgs e)
        {

        }
    }
}
