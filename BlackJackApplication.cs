using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackApp1
{
    public partial class BlackJackApplication : Form
    {
        public BlackJackApplication()
        {
            InitializeComponent();
        }

        //Creating a new random
        Random randomizerOne = new Random();

        //Declaring variables
        int clickCount = 0;
        int cardValueTotal, cardHouseValueTotal;
        int cardIndex1, cardIndex2, cardIndex3, cardIndex4, cardIndex5, cardHouse1, cardHouse2, cardHouse3, cardHouse4, cardHouse5;
        int cardValue1, cardValue2, cardValue3, cardValue4, cardValue5, cardHouseValue1, cardHouseValue2, cardHouseValue3, cardHouseValue4, cardHouseValue5;

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            //Message box displaying the rules of the game, how to use the interface,
            //and how to exit the game
            MessageBox.Show
                ("BASIC RULES:\n\n" +
                "The aim of blackjack is to get as close to 21 without going over, while also having a higher ranking hand than the dealer.\n\n" +
                "NB *In this version of the game Aces are always equal to 11*\n\n" +
                "STARTING THE GAME:\n\n" +
                "To start the game, click the 'play' button, this will launch the game and deal you two cards.\n\n" +
                "USING THE HIT BUTTON:\n\n" +
                "If you wish to deal another card, you can then click the 'Hit' button. You can deal yourself up to 5 cards in total this way. If you reach this 5 card maximum, the dealer will auto generate his competing hand.\n\n" +
                "USING THE STAY BUTTON:\n\n" +
                "If you are happy with your card value total, you can click the stay button. This will trigger the dealer to deal his competing hand\n\n" +
                "HOW TO WIN/DRAW/LOSE:\n\n" +
                "- If your card value total is less than or equal to 21 and higher than the dealers card value total, you will win the game.\n" +
                "- If you hit 21 you will win the game.\n" +
                "- If your card value total exceeds 21 you will bust and lose the game.\n" +
                "- If the dealer has a higher card value total than you without going over 21, you will lose the game.\n" +
                "- If you and the dealer both have the same card value total, you will draw the game.\n\n" +
                "HOW TO EXIT THE GAME:\n\n" +
                "Click on the Exit button in the bottom right hand corner.",
                "Help",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            //click event closing the application
            this.Close();
        }

        private void BtnStay_Click(object sender, EventArgs e)
        {
            //makes the dealers first card visible
            PicDealerOne.Visible = true;

            //assigning the correct card value to a randomly drawn card,
            //and displaying in the appropriate picture box
            cardHouse1 = randomizerOne.Next(1, 53);
            PicDealerOne.Image = imageList1.Images[cardHouse1];
            cardHouseValue1 = drawCard(cardHouse1);

            PicDealerTwo.Visible = true;
            cardHouse2 = randomizerOne.Next(1, 53);
            PicDealerTwo.Image = imageList1.Images[cardHouse2];
            cardHouseValue2 = drawCard(cardHouse2);

            //calculation to get the total value of the dealers cards
            cardHouseValueTotal = cardHouseValue1 + cardHouseValue2;

            //if statement for generating up to 5 total dealer cards if needed.
            if (cardHouseValueTotal < 17 && cardHouseValueTotal <= cardValueTotal)
            {
                PicDealerThree.Visible = true;
                cardHouse3 = randomizerOne.Next(1, 53);
                PicDealerThree.Image = imageList1.Images[cardHouse3];
                cardHouseValue3 = drawCard(cardHouse3);

                cardHouseValueTotal = cardHouseValueTotal + cardHouseValue3;
            }

            if (cardHouseValueTotal < 17 && cardHouseValueTotal <= cardValueTotal)
            {
                PicDealerFour.Visible = true;
                cardHouse4 = randomizerOne.Next(1, 53);
                PicDealerFour.Image = imageList1.Images[cardHouse4];
                cardHouseValue4 = drawCard(cardHouse4);

                cardHouseValueTotal = cardHouseValueTotal + cardHouseValue4;
            }

            if (cardHouseValueTotal < 17 && cardHouseValueTotal <= cardValueTotal)
            {
                PicDealerFive.Visible = true;
                cardHouse5 = randomizerOne.Next(1, 53);
                PicDealerFive.Image = imageList1.Images[cardHouse5];
                cardHouseValue5 = drawCard(cardHouse5);

                cardHouseValueTotal = cardHouseValueTotal + cardHouseValue5;
            }

            //Displaying the dealers card value total in a label
            LblHouseTotalDisplay.Text = ("House hand total is: ") + cardHouseValueTotal.ToString();

            //if statement for each win/lose/draw outcome
            if (cardHouseValueTotal > cardValueTotal && cardHouseValueTotal <= 21)
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                System.IO.Stream str = Properties.Resources.house_wins;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("Sorry, House wins", "Lose", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (cardHouseValueTotal < cardValueTotal)
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                System.IO.Stream str = Properties.Resources.congradulations;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("Congradulations, You win!", "Win!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else if (cardHouseValueTotal == cardValueTotal)
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                System.IO.Stream str = Properties.Resources.push;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("It's a push!", "Draw!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                System.IO.Stream str = Properties.Resources.congradulations;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("House busts, you win!", "Win!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

            //making the play button visable again
            BtnPlay.Visible = true;
        }

        private void BtnPlay_Click(object sender, EventArgs e)

        {
            //playing game sounds from imported .wav files
            System.IO.Stream str = Properties.Resources.GameReady;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            //Setting clickCount variable to 0
            clickCount = 0;
           
            //Setting the play button to invisible
            BtnPlay.Visible = false;

            //Setting the hit and stay buttons to visible
            BtnHit.Visible = true;
            BtnStay.Visible = true;

            //Setting player cards 3 through 5 to invisible
            PicCardThree.Visible = false;
            PicCardFour.Visible = false;
            PicCardFive.Visible = false;

            //Setting all Dealer cards to invisible
            PicDealerOne.Visible = false;
            PicDealerTwo.Visible = false;
            PicDealerThree.Visible = false;
            PicDealerFour.Visible = false;
            PicDealerFive.Visible = false;

            //Clearing the label
            LblHouseTotalDisplay.Text = "";
            
            //assigning the correct card value to a randomly drawn card,
            //and displaying in the appropriate picture box
            cardIndex1 = randomizerOne.Next(1, 53);
            PicCardOne.Image = imageList1.Images[cardIndex1];
            cardValue1 = drawCard(cardIndex1);

            cardIndex2 = randomizerOne.Next(1, 53);
            PicCardTwo.Image = imageList1.Images[cardIndex2];
            cardValue2 = drawCard(cardIndex2);

            //Adding the card value totals and displaying in a label
            cardValueTotal = cardValue1 + cardValue2;
            LbltotalDisplay.Text = ("Your hand total is: ") + cardValueTotal.ToString();

            //if statement displaying win message box, only if Blackjack is dealt.
            if (cardValueTotal == 21) {
                MessageBox.Show("Congradulations, you got blackjack!", "Blackjack!", MessageBoxButtons.OK, MessageBoxIcon.None);
                BtnPlay.Visible = true;
                BtnHit.Visible = false;
                BtnStay.Visible = false;
            }
            else if (cardValueTotal > 21) {
                cardIndex1 = randomizerOne.Next(1, 53);
                PicCardOne.Image = imageList1.Images[cardIndex1];
                cardValue1 = drawCard(cardIndex1);

                cardIndex2 = randomizerOne.Next(1, 53);
                PicCardTwo.Image = imageList1.Images[cardIndex2];
                cardValue2 = drawCard(cardIndex2);
            }
            
        }

        private int drawCard(int cardIndex)
        {
            //Switch statement in a method for assigning a card value to a card index.
            int cardValue = 0;
            switch (cardIndex)
            {
                case 1:
                    cardValue = 2;
                    break;
                case 2:
                    cardValue = 2;
                    break;
                case 3:
                    cardValue = 2;
                    break;
                case 4:
                    cardValue = 2;
                    break;
                case 5:
                    cardValue = 3;
                    break;
                case 6:
                    cardValue = 3;
                    break;
                case 7:
                    cardValue = 3;
                    break;
                case 8:
                    cardValue = 3;
                    break;
                case 9:
                    cardValue = 4;
                    break;
                case 10:
                    cardValue = 4;
                    break;
                case 11:
                    cardValue = 4;
                    break;
                case 12:
                    cardValue = 4;
                    break;
                case 13:
                    cardValue = 5;
                    break;
                case 14:
                    cardValue = 5;
                    break;
                case 15:
                    cardValue = 5;
                    break;
                case 16:
                    cardValue = 5;
                    break;
                case 17:
                    cardValue = 6;
                    break;
                case 18:
                    cardValue = 6;
                    break;
                case 19:
                    cardValue = 6;
                    break;
                case 20:
                    cardValue = 6;
                    break;
                case 21:
                    cardValue = 7;
                    break;
                case 22:
                    cardValue = 7;
                    break;
                case 23:
                    cardValue = 7;
                    break;
                case 24:
                    cardValue = 7;
                    break;
                case 25:
                    cardValue = 8;
                    break;
                case 26:
                    cardValue = 8;
                    break;
                case 27:
                    cardValue = 8;
                    break;
                case 28:
                    cardValue = 8;
                    break;
                case 29:
                    cardValue = 9;
                    break;
                case 30:
                    cardValue = 9;
                    break;
                case 31:
                    cardValue = 9;
                    break;
                case 32:
                    cardValue = 9;
                    break;
                case 33:
                    cardValue = 10;
                    break;
                case 34:
                    cardValue = 10;
                    break;
                case 35:
                    cardValue = 10;
                    break;
                case 36:
                    cardValue = 10;
                    break;
                case 37:
                    cardValue = 11;
                    break;
                case 38:
                    cardValue = 11;
                    break;
                case 39:
                    cardValue = 11;
                    break;
                case 40:
                    cardValue = 11;
                    break;
                case 41:
                    cardValue = 10;
                    break;
                case 42:
                    cardValue = 10;
                    break;
                case 43:
                    cardValue = 10;
                    break;
                case 44:
                    cardValue = 10;
                    break;
                case 45:
                    cardValue = 10;
                    break;
                case 46:
                    cardValue = 10;
                    break;
                case 47:
                    cardValue = 10;
                    break;
                case 48:
                    cardValue = 10;
                    break;
                case 49:
                    cardValue = 10;
                    break;
                case 50:
                    cardValue = 10;
                    break;
                case 51:
                    cardValue = 10;
                    break;
                case 52:
                    cardValue = 10;
                    break;
            }

            //Returning card value
            return cardValue;
        }

        private void BtnHit_Click(object sender, EventArgs e)
        {
            //Displaying the third card upon clicking the hit button for the first time
            if (clickCount == 0)
            {
                //making a new picture box visible
                PicCardThree.Visible = true;
                //clearing the label
                LbltotalDisplay.Text = "";
                //generating new random card
                cardIndex3 = randomizerOne.Next(1, 53);
                //assigning a value to card index
                PicCardThree.Image = imageList1.Images[cardIndex3];
                cardValue3 = drawCard(cardIndex3);
                // calculating the card value total
                cardValueTotal = cardValueTotal + cardValue3;
                //displaying the card value total in a label
                LbltotalDisplay.Text = ("Your hand total is: ") + cardValueTotal.ToString();
                //incrementing the click count variable
                clickCount++;
            }
            //Displaying the fourth card upon clicking the hit button for the second time
            else if (clickCount == 1)
            {
                PicCardFour.Visible = true;
                LbltotalDisplay.Text = "";
                cardIndex4 = randomizerOne.Next(1, 53);
                PicCardFour.Image = imageList1.Images[cardIndex4];
                cardValue4 = drawCard(cardIndex4);
                cardValueTotal = cardValueTotal + cardValue4;
                LbltotalDisplay.Text = ("Your hand total is: ") + cardValueTotal.ToString();
                clickCount++;
            }
            //Displaying the fifth card upon clicking the hit button for the third time
            else
            {
                PicCardFive.Visible = true;
                LbltotalDisplay.Text = "";
                cardIndex5 = randomizerOne.Next(1, 53);
                PicCardFive.Image = imageList1.Images[cardIndex5];
                cardValue5 = drawCard(cardIndex5);
                cardValueTotal = cardValueTotal + cardValue5;
                LbltotalDisplay.Text = ("Your hand total is: ") + cardValueTotal.ToString();
               

                {
                    //If statement for generating the dealers hand
                    if (cardValueTotal <= 21)
                    {
                        //making the first card visible
                        PicDealerOne.Visible = true;
                        //generting a random card index
                        cardHouse1 = randomizerOne.Next(1, 53);
                        //assigning the value to the card index
                        PicDealerOne.Image = imageList1.Images[cardHouse1];
                        cardHouseValue1 = drawCard(cardHouse1);

                        PicDealerTwo.Visible = true;
                        cardHouse2 = randomizerOne.Next(1, 53);
                        PicDealerTwo.Image = imageList1.Images[cardHouse2];
                        cardHouseValue2 = drawCard(cardHouse2);

                        //Calculation for getting the dealers card value total
                        cardHouseValueTotal = cardHouseValue1 + cardHouseValue2;

                        //if statement for when the dealer needs to draw more than two cards
                        if (cardHouseValueTotal < 17 && cardHouseValueTotal < cardValueTotal)
                        {
                            PicDealerThree.Visible = true;
                            cardHouse3 = randomizerOne.Next(1, 53);
                            PicDealerThree.Image = imageList1.Images[cardHouse3];
                            cardHouseValue3 = drawCard(cardHouse3);

                            cardHouseValueTotal = cardHouseValueTotal + cardHouseValue3;
                        }

                        if (cardHouseValueTotal < 17 && cardHouseValueTotal < cardValueTotal)
                        {
                            PicDealerFour.Visible = true;
                            cardHouse4 = randomizerOne.Next(1, 53);
                            PicDealerFour.Image = imageList1.Images[cardHouse4];
                            cardHouseValue4 = drawCard(cardHouse4);

                            cardHouseValueTotal = cardHouseValueTotal + cardHouseValue4;
                        }

                        if (cardHouseValueTotal < 17 && cardHouseValueTotal < cardValueTotal)
                        {
                            PicDealerFive.Visible = true;
                            cardHouse5 = randomizerOne.Next(1, 53);
                            PicDealerFive.Image = imageList1.Images[cardHouse5];
                            cardHouseValue5 = drawCard(cardHouse5);

                            cardHouseValueTotal = cardHouseValueTotal + cardHouseValue5;
                        }

                        //Calculating the dealers card value total and displaying it in  label
                        LblHouseTotalDisplay.Text = ("House hand total is: ") + cardHouseValueTotal.ToString();

                        //Calculating the win/draw/lose outcome and displaying it in a message box
                        if (cardHouseValueTotal > cardValueTotal && cardHouseValueTotal <= 21)
                        {
                            BtnHit.Visible = false;
                            BtnStay.Visible = false;
                            //playing .wav files upon a certain event
                            System.IO.Stream str = Properties.Resources.house_wins;
                            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                            snd.Play();
                            MessageBox.Show("Sorry! House wins", "Lose", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else if (cardHouseValueTotal < cardValueTotal)
                        {
                            BtnHit.Visible = false;
                            BtnStay.Visible = false;
                            //playing .wav files upon a certain event
                            System.IO.Stream str = Properties.Resources.congradulations;
                            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                            snd.Play();
                            MessageBox.Show("Congradulations, You win!", "Win!", MessageBoxButtons.OK, MessageBoxIcon.None);
                            
                        }
                        else if (cardHouseValueTotal == cardValueTotal)
                        {
                            BtnHit.Visible = false;
                            BtnStay.Visible = false;
                            //playing .wav files upon a certain event
                            System.IO.Stream str = Properties.Resources.push;
                            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                            snd.Play();
                            MessageBox.Show("It's a push!", "Draw", MessageBoxButtons.OK, MessageBoxIcon.None);
                           
                        }
                        else
                        {
                            BtnHit.Visible = false;
                            BtnStay.Visible = false;
                            //playing .wav files upon a certain event
                            System.IO.Stream str = Properties.Resources.congradulations;
                            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                            snd.Play();
                            MessageBox.Show("House busts! you win!", "Lose", MessageBoxButtons.OK, MessageBoxIcon.None);
                          
                        }
                    }

                    //making the play button visible again
                    BtnPlay.Visible = true;
                    BtnHit.Visible = false;
                    BtnStay.Visible = false;
                }
            }

            //Displaying message box and playing sound for getting blackjack
            if (cardValueTotal == 21)
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                //playing .wav files upon a certain event
                System.IO.Stream str = Properties.Resources.blackjack;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("Congradulations, you got blackjack", "Blackjack", MessageBoxButtons.OK, MessageBoxIcon.None);
                BtnPlay.Visible = true;

            }
            //Displaying message box and playing sound for busting
            else if (cardValueTotal > 21)
            {
                BtnHit.Visible = false;
                BtnStay.Visible = false;
                System.IO.Stream str = Properties.Resources.Bust;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
                MessageBox.Show("Bust, Better luck next time!", "Bust", MessageBoxButtons.OK, MessageBoxIcon.None);
                BtnPlay.Visible = true;
  
            } 
        }
    }     
}


