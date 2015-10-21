using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media; //for å bruke systemlyder

namespace enkeltSpill
{
    /*
    Enkelt spill inspirert av det klassiske dataspillet Pong. 
    Pong (marketed as PONG) is one of the earliest arcade video games and the very first sports arcade video game.
    It is a tennis sports game featuring simple two-dimensional graphics. While other arcade video games such as 
    Computer Space came before it, Pong was one of the first video games to reach mainstream popularity. 
    The aim is to defeat an opponent in a simulated table-tennis game by earning a higher score. 
    The game was originally manufactured by Atari Incorporated (Atari), which released it in 1972. 
    Allan Alcorn created Pong as a training exercise assigned to him by Atari co-founder Nolan Bushnell. 
    Bushnell based the idea on an electronic ping-pong game included in the Magnavox Odyssey, which later resulted 
    in a lawsuit against Atari. Surprised by the quality of Alcorn's work, Bushnell and Atari co-founder 
    Ted Dabney decided to manufacture the game. Kilde: https://en.wikipedia.org/wiki/Pong
    */
    public partial class Form1 : Form
    {   
        
        
        //Globale variabler og konstanter
        #region deklarasjoner
        int xRetning = 15; // Verdien bestemmer farten på ballen i horisontal retning
        int yRetning = 0; // Verdien bestemmer farten på ballen i vertikal retning
        int pointsLP = 0, pointsRP = 0; 
        const int barStep = 5; // Følsomheten på rekkertbevegelsen
        #endregion

        //Tegner opp spillflaten og nødvendig oppstarts konfigurasjon
        public Form1()
        {
            InitializeComponent();
            valgPanel.Location = new Point(12, 70);
            valgPanel.Size = new Size(506, 217);
            valgPanel.Hide();
            gameEngine.Start();
        }

        //Selve spill motoren som er styrt av en Timer
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            Ball.Location = new Point(Ball.Location.X + xRetning, Ball.Location.Y + yRetning);
            if (BallInGame())
                poengtavle(label1, label2, pointsLP, pointsRP);
            else
                GameOver();
        }

        //Hovedrutinen som spillmotoren bruker hver gang for å bestemme hva
        //som skal skje til enhver tid i spillet.
        //Holder ballen inne på spilleflaten, og avgjør om spillerne treffer eller bommer 
        
        private bool BallInGame()
        {
            /*
            Sjekker om spilleren treffer ballen, og endrer retningen på ballen avhengig av hvor det treffes.
            Treff på øvre og nedre 3.-del sender ballen henholdvis oppover og nedover.
            Ballen går horisontalt med treff på midtre 3.-del.
            Hver gang ballen treffer spilles en lyd.
            */
            bool inGame = true;

            if (xRetning > 0) //Ballen går mot høgre
            {
                if (Ball.Location.X + Ball.Width >= RightBar.Location.X)
                {
                    if ((Ball.Location.Y + Ball.Height > RightBar.Location.Y) &&
                        (Ball.Location.Y < RightBar.Location.Y + 0.33 * RightBar.Height))
                    {
                        yRetning = -5;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsRP++;
                    }

                    else if ((Ball.Location.Y + Ball.Height > RightBar.Location.Y + 0.33 * RightBar.Height) && (Ball.Location.Y < RightBar.Location.Y + 0.66 * RightBar.Height))
                    {
                        yRetning = 0;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsRP++;
                    }
                    else if ((Ball.Location.Y + Ball.Height > RightBar.Location.Y + 0.66 * RightBar.Height) && (Ball.Location.Y < RightBar.Location.Y + RightBar.Height))
                    {
                        yRetning = 5;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsRP++;
                    }
                    else
                        inGame = false;
                }
            }
            else //Ballen går mot venstre
            {
                if (Ball.Location.X <= LeftBar.Location.X + LeftBar.Width)
                {
                    if ((Ball.Location.Y + Ball.Height > LeftBar.Location.Y) &&
                        (Ball.Location.Y < LeftBar.Location.Y + 0.33 * LeftBar.Height))
                    {
                        yRetning = -5;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsLP++;
                    }

                    else if ((Ball.Location.Y + Ball.Height > LeftBar.Location.Y + 0.33 * LeftBar.Height) && (Ball.Location.Y < LeftBar.Location.Y + 0.66 * LeftBar.Height))
                    {
                        yRetning = 0;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsLP++;
                    }
                    else if ((Ball.Location.Y + Ball.Height > LeftBar.Location.Y + 0.66 * LeftBar.Height) && (Ball.Location.Y < LeftBar.Location.Y + LeftBar.Height))
                    {
                        yRetning = 5;
                        xRetning *= -1;
                        SystemSounds.Hand.Play();
                        pointsLP++;
                    }
                    else
                        inGame = false;
                }
            }

            //Sjekker krasj mot sideflatene
            if ((Ball.Location.Y < 0) || (Ball.Location.Y + Ball.Height > this.ClientSize.Height))
            {
                yRetning *= -1;
                SystemSounds.Hand.Play();
            }

            return inGame;
        }

        //Registrerer tastetrykk og flytter bar opp og ned.
        //Tastene w, s samt piltastene  opp og ned for å styre.
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    LeftBar.Location = new Point(LeftBar.Location.X, LeftBar.Location.Y - barStep);
                    break;
                case Keys.S:
                    LeftBar.Location = new Point(LeftBar.Location.X, LeftBar.Location.Y + barStep);
                    break;
                case Keys.Up:
                    RightBar.Location = new Point(RightBar.Location.X, RightBar.Location.Y - barStep);
                    break;
                case Keys.Down:
                    RightBar.Location = new Point(RightBar.Location.X, RightBar.Location.Y + barStep);
                    break;
            }
        }

        //Styrer poengtavlen
        private void poengtavle(Label LpPoints, Label RpPoints, int lp, int rp)
        {
            LpPoints.Text = "" + lp;
            RpPoints.Text = "" + rp;
        }

        //Kjøren når en av spillerne bommer, og spillet er slutt
        private void GameOver() 
        {
            gameEngine.Stop();
            Ball.Visible = false;
            valgPanel.Show();
        }

        //To knapper hvor spilleren kan velge om å avslutte eller starte ett nytt
        #region valgPanel

        private void btNyttSpill_Click(object sender, EventArgs e)
        {
            valgPanel.Hide();
            LeftBar.Location = new Point(12, 90);
            RightBar.Location = new Point(498, 90);
            Ball.Location = new Point(238, 132);
            Ball.Visible = true;
            poengtavle(label1, label2, pointsLP = 0, pointsRP = 0);
            gameEngine.Start();
        }

        private void btAvslutt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
