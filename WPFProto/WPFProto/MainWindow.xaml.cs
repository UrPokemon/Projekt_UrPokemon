using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProto
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        PokémonA Glurak = new PokémonA();
        PokémonB Bisafloor = new PokémonB();
        private int zug = 0;

        private string S1 = "";
        private string S2 = "";

        public MainWindow()
        {
            InitializeComponent();

            ug1.Visibility = Visibility.Hidden;
            ug2.Visibility = Visibility.Hidden;

            b.Visibility = Visibility.Hidden;
            g.Visibility = Visibility.Hidden;

            LR1.Visibility = Visibility.Hidden;
            LR2.Visibility = Visibility.Hidden;

            L1.Visibility = Visibility.Hidden;
            L2.Visibility = Visibility.Hidden;

            LB1.Visibility = Visibility.Hidden;
            LB2.Visibility = Visibility.Hidden;

            AHide();

            BHide();

            PfeilB.Visibility = Visibility.Hidden;
            PfeilG.Visibility = Visibility.Hidden;

            T2.Visibility = Visibility.Hidden;
            W.Visibility  = Visibility.Hidden;

            WE.Visibility   = Visibility.Hidden;
            end.Visibility  = Visibility.Hidden;
            Aufg.Visibility = Visibility.Hidden;

            WS1.Visibility = Visibility.Hidden;
            WS2.Visibility = Visibility.Hidden;

            ES1.Visibility = Visibility.Hidden;
            ES2.Visibility = Visibility.Hidden;

            BT.Text = "\t\tWilkommen bei unserem Pokémon Spiel.\n\nBitte entscheiden sie sich wer Spieler 1 und wer Spieler 2 sein soll.\nWenn dies geschehen ist, klicken sie auf weiter. Über dem Pokémon des Spielers,\nder aktuell an der reihe ist erscheint ein Pfeil.\nBeendet wird das Spiel sobald das Leben eines Pokémons auf 0 sinkt.\n\n(Bildmaterial der Pokémon bzw. der Hintergründe ist besitz von Nintendo)";
      
        }
        public void AHide()
        {
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;
            A4.Visibility = Visibility.Hidden;
        }

        public void BHide()
        {
            B1.Visibility = Visibility.Hidden;
            B2.Visibility = Visibility.Hidden;
            B3.Visibility = Visibility.Hidden;
            B4.Visibility = Visibility.Hidden;
        }

        public void NeuesSpiel()
        {
            T1.Text = "Wenn sie ein neues Spiel starten\n wollen klicken sie auf neues Spiel.\n Wenn nicht klicken sie auf Ende";
            PfeilB.Visibility = Visibility.Hidden;
            PfeilG.Visibility = Visibility.Hidden;

        }

        public void EndGme()
        {
            if (Bisafloor.istLeben <= 0)
            {
                W.Visibility = Visibility.Hidden;

                AHide();

                BHide();

                LB1.Width = 0;

                T1.Text = "Glurak kann nicht mehr weiterkämpfen, \rBisafloor gewinnt!";
                WE.Visibility = Visibility.Visible;
            }

            if (Glurak.istLeben <= 0)
            {
                W.Visibility = Visibility.Hidden;

                AHide();

                BHide();

                LB2.Width = 0;

                T1.Text = "Bisafloor kann nicht mehr weiterkämpfen, \rGlurak gewinnt!";
                WE.Visibility = Visibility.Visible;
            }
        }

        public void LB2Scale()
        {
            double laenge = 62;
            double prozleben = Glurak.Leben();
            LB2.Width = laenge * prozleben;
        }

        public void LB1Scale()
        {
            double laenge = 62;
            double prozleben = Bisafloor.Leben();
            if (laenge * prozleben >= 0)
            {
                LB1.Width = laenge * prozleben;
            }
            else
            {
                LB1.Width = 0;
            }
        }

        private void A1_Click_1(object sender, RoutedEventArgs e)
        {
            Glurak.Tackle();
            W.Visibility = Visibility.Visible;

            LB2Scale();
            T1.Text = "Glurak setzt " + Glurak.nameT + " ein! \r" + /*schaden + " Schaden verursacht! \r" +*/  "Bisafloors Leben sinkt auf " + Glurak.istLeben;

            AHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void A2_Click_1(object sender, RoutedEventArgs e)
        {
            //double altLeben = Bisafloor.istLeben;
            W.Visibility = Visibility.Visible;

            Glurak.Flammenwurf();

            LB2Scale();
            T1.Text = "Glurak setzt " + Glurak.nameF + " ein! \r" + /*schaden + " Schaden verursacht! \r" +*/ "Bisafloors Leben sinkt auf " + Glurak.istLeben;

            AHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void A3_Click_1(object sender, RoutedEventArgs e)
        {
            //double altLeben = Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Bisafloor.Genesung();
            //double schaden = Glurak.Genesung();

            LB1Scale();
            T1.Text = "Glurak setzt " + Glurak.nameG + " ein! \r " + /*schaden + " HP wurden geheilt! \r" +*/ "Gluraks Leben steigt auf " + Bisafloor.istLeben;

            AHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void A4_Click_1(object sender, RoutedEventArgs e)
        {
            W.Visibility = Visibility.Visible;
            Glurak.Brüller();
            if (Bisafloor.schaden - Glurak.brull > 0)
            {
                Bisafloor.schaden = Bisafloor.schaden - Glurak.brull;
            }
            else
            {
                Bisafloor.schaden = 0;
            }

            T1.Text = "Glurak setzt " + Glurak.nameB + " ein! \r " + "Glurak schüchtert ein!";

            AHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 1;
            EndGme();
        }

        private void B1_Click_1(object sender, RoutedEventArgs e)
        {
            //double altleben = Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Bisafloor.Tackle();
            if (Bisafloor.schaden - Glurak.brull > 0)
            {
                Bisafloor.schaden = Bisafloor.schaden - Glurak.brull;
            }
            else
            {
                Bisafloor.schaden = 0;
            }
           
            Bisafloor.istLeben = Bisafloor.istLeben - Bisafloor.schaden;

            LB1Scale();
            T1.Text = "Bisafloor setzt " + Bisafloor.nameT + " ein! \r" + /*schaden + " Schaden verursacht! \r" +*/ "Gluraks Leben sinkt auf " + Bisafloor.istLeben;

            BHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }

        private void B2_Click_1(object sender, RoutedEventArgs e)
        {
            //double altleben=Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Bisafloor.Rasierblatt();
            if (Bisafloor.schaden - Glurak.brull > 0)
            {
                Bisafloor.schaden = Bisafloor.schaden - Glurak.brull;
            }
            else
            {
                Bisafloor.schaden = 0;
            }

            Bisafloor.istLeben = Bisafloor.istLeben - Bisafloor.schaden;

            LB1Scale();
            T1.Text = "Bisafloor setzt " + Bisafloor.nameR + " ein! \r" + /*schaden + " Schaden verursacht! \r" + */"Gluraks Leben sinkt auf " + Bisafloor.istLeben;

            BHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            //double altleben = Bisafloor.istLeben;
            W.Visibility = Visibility.Visible;
            Glurak.Genesung();
            
            LB2Scale();
            T1.Text = "Bisafloor setzt " + Bisafloor.nameG + " ein! \r" + /*schaden + " Schaden verursacht! \r" + */"Bisafloors Leben steigt auf " + Glurak.istLeben;

            BHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }


        private void B4_Click_1(object sender, RoutedEventArgs e)
        {
            W.Visibility = Visibility.Visible;
            Bisafloor.Focus();
            T1.Text = "Bisafloor setzt " + Bisafloor.nameFo + " ein! \r" + "Bisafloor focusiert den Gegner! mit " + Bisafloor.zusatz;

            BHide();
            Aufg.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }


        private void W1_Click_1(object sender, RoutedEventArgs e)
        {
            if (zug ==2)
            {
                T1.Text = "";

                AHide();

                PfeilB.Visibility = Visibility.Hidden;
                PfeilG.Visibility = Visibility.Visible;

                W.Visibility    = Visibility.Hidden;
                Aufg.Visibility = Visibility.Visible;

            }
            else if(zug ==1)
            {
                T1.Text = "";

                BHide();

                W.Visibility = Visibility.Hidden;
                Aufg.Visibility = Visibility.Visible;
                PfeilG.Visibility = Visibility.Hidden;
                PfeilB.Visibility = Visibility.Visible;

            }
        }
        
        private void A1_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Glurak.staerkeT + "\r Genauigkeit: " + Glurak.accuT;
        }

        private void A2_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Glurak.staerkeF + "\r Genauigkeit: " + Glurak.accuF;
        }

        private void A3_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Glurak.staerkeG + "\r Genauigkeit: " + Glurak.accuG;
        }

        private void A4_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:        Random" + "\r Genauigkeit: " + Glurak.accuB;
        }

        private void B1_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Bisafloor.staerkeT + "\r Genauigkeit: " + Bisafloor.accuT;
        }

        private void B2_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Bisafloor.staerkeR + "\r Genauigkeit: " + Bisafloor.accuR;
        }

        private void B3_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:          " + Bisafloor.staerkeG + "\r Genauigkeit: " + Bisafloor.accuG;
        }

        private void B4_Hover(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Visible;
            T2.Text = " Stärke:        Random" + "\r Genauigkeit: " + Bisafloor.accuFo;
        }

        private void A1_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }
        
        private void WB_Click_1(object sender, RoutedEventArgs e)
        {
            T1.Text = "Bitte Namnen von Spieler 1 eingeben";
            WB.Visibility = Visibility.Hidden;
            WS1.Visibility = Visibility.Visible;
            ES1.Visibility = Visibility.Visible;
        }

        private void WS1_Click_1(object sender, RoutedEventArgs e)
        {
            T1.Text = "Name von Spieler 2 eingeben";
            S1 = ES1.Text;
            if (S1.Length >= 3)
            {
                WS1.Visibility = Visibility.Hidden;
                WS2.Visibility = Visibility.Visible;
                ES1.Visibility = Visibility.Hidden;
                ES2.Visibility = Visibility.Visible;
            }
            else
            {

                T1.Text = "Name muss mind. 3Zeichen lang sein";
            }

        }

        private void WE_Click_1(object sender, RoutedEventArgs e)
        {
            zug = 0;
            WB.Content = "Neues Spiel";
            WB.Visibility = Visibility.Visible;
            end.Visibility = Visibility.Visible;
            WE.Visibility = Visibility.Hidden;
            Glurak = new PokémonA();
            Bisafloor = new PokémonB();
            NeuesSpiel();
        }


        private void end_Click_1(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Aufg_Click_1(object sender, RoutedEventArgs e)
        {
            if (zug == 1)
            {
                BHide();
                T1.Text = "Spieler 2 hat aufgegeben.\nSpieler 1 gewinnt.";
                WE.Visibility = Visibility.Visible;
                Aufg.Visibility = Visibility.Hidden;
            }
            else
            {
                AHide();
                T1.Text = S1 + " hat aufgegeben.\n" + S2 + " gewinnt.";
                WE.Visibility = Visibility.Visible;
                Aufg.Visibility = Visibility.Hidden;
            }
        }

        private void WS2_Click_1(object sender, RoutedEventArgs e)
        {
            T1.Text = "";
            S2 = ES2.Text;
            if (S2.Length >= 3)
            {
                //Resetten der Namenseingabe
                ES1.Text = "";
                ES2.Text = "";

                WS2.Visibility = Visibility.Hidden;
                ES2.Visibility = Visibility.Hidden;

                Random Rnd = new Random();
                int RndNr3 = Rnd.Next(0, 2);

                LB1Scale();
                LB2Scale();
                end.Visibility = Visibility.Hidden;
                g.Visibility   = Visibility.Visible;
                b.Visibility   = Visibility.Visible;
                ug1.Visibility = Visibility.Visible;
                ug2.Visibility = Visibility.Visible;
                L1.Visibility  = Visibility.Visible;
                L2.Visibility  = Visibility.Visible;
                LB1.Visibility = Visibility.Visible;
                LB2.Visibility = Visibility.Visible;
                BT.Visibility  = Visibility.Hidden;
                LR1.Visibility = Visibility.Visible;
                LR2.Visibility = Visibility.Visible;
                WS2.Visibility = Visibility.Hidden;

                if (RndNr3 < 1)
                {
                    T1.Text = S1 + " beginnt!";

                    W.Visibility = Visibility.Visible;
                    zug = 2;
                    PfeilG.Visibility = Visibility.Visible;

                }
                else
                {
                    W.Visibility = Visibility.Visible;

                    T1.Text = S2 + " beginnt!";
                    zug = 1;
                    PfeilB.Visibility = Visibility.Visible;
                }
            }
            else
            {
                T1.Text = "Name muss mind. 3Zeichen lang sein";
            }

        }



    }
}
