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


        public MainWindow()
        {
            InitializeComponent();

            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;

            B1.Visibility = Visibility.Hidden;
            B2.Visibility = Visibility.Hidden;
            B3.Visibility = Visibility.Hidden;

            PfeilB.Visibility = Visibility.Hidden;
            PfeilG.Visibility = Visibility.Hidden;

            T2.Visibility = Visibility.Hidden;
            W.Visibility = Visibility.Hidden;

            //Glurak.Tackle();
            //Bisafloor.Tackle();

            Random Rnd = new Random();
            int RndNr3 = Rnd.Next(0, 2);

            

            if (RndNr3 < 1)
            {
                T1.Text = "Spieler 1 beginnt!";

                W.Visibility = Visibility.Visible;
                zug = 2;
                PfeilG.Visibility = Visibility.Visible;
            }
            else
            {
                W.Visibility = Visibility.Visible;

                T1.Text = "Spieler 2 beginnt!";
                zug = 1;
                PfeilB.Visibility = Visibility.Visible;
            }

        }

        public void EndGme()
        {
            if (Glurak.istLeben == 0)
            {
                W.Visibility = Visibility.Hidden;

                A1.Visibility = Visibility.Hidden;
                A2.Visibility = Visibility.Hidden;
                A3.Visibility = Visibility.Hidden;

                B1.Visibility = Visibility.Hidden;
                B2.Visibility = Visibility.Hidden;
                B3.Visibility = Visibility.Hidden;

                LB2.Width = 0;

                T1.Text = "Glurak kann nicht mehr weiterkämpfen, \rBisafloor gewinnt!";
            }

            if (Bisafloor.istLeben == 0)
            {
                W.Visibility = Visibility.Hidden;

                A1.Visibility = Visibility.Hidden;
                A2.Visibility = Visibility.Hidden;
                A3.Visibility = Visibility.Hidden;

                B1.Visibility = Visibility.Hidden;
                B2.Visibility = Visibility.Hidden;
                B3.Visibility = Visibility.Hidden;

                LB1.Width = 0;

                T1.Text = "Bisafloor kann nicht mehr weiterkämpfen, \rGlurak gewinnt!";
            }
        }

        public void LB2Scale()
        {
            double laenge = 62;
            //Bisafloor.Leben();
            double prozleben = Bisafloor.Leben();
            LB2.Width = laenge * prozleben;
        }

        public void LB1Scale()
        {
            double laenge = 62;
            //Glurak.Leben();
            double prozleben = Glurak.Leben();
            LB1.Width = laenge * prozleben;
        }

        private void A1_Click_1(object sender, RoutedEventArgs e)
        {
            double altleben = Bisafloor.istLeben;
            W.Visibility = Visibility.Visible;

            Glurak.Tackle();
            //double schaden = Glurak.Tackle();

            if (altleben == Bisafloor.istLeben)
            {
                T1.Text = "Glurak setzt " + Glurak.nameT + " ein, \rdoch der Angriff ging daneben.";
            }
            else
            {
                LB2Scale();
                T1.Text = "Glurak setzt " + Glurak.nameT + " ein! \r" + /*schaden + " Schaden verursacht! \r" + */  "Bisafloors Leben sinkt auf " + Bisafloor.istLeben;
            }
            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void A2_Click_1(object sender, RoutedEventArgs e)
        {
            double altLeben = Bisafloor.istLeben;
            W.Visibility = Visibility.Visible;

            Glurak.Flammenwurf();
            //double schaden = Glurak.Flammenwurf();

            if (Bisafloor.istLeben == altLeben)
            {
                T1.Text = "Glurak setzt " + Glurak.nameF + " ein, \rdoch der Angriff ging daneben.";
            }
            else
            {
                LB2Scale();
                T1.Text = "Glurak setzt " + Glurak.nameF + " ein! \r" + /*schaden + " Schaden verursacht! \r" +*/ "Bisafloors Leben sinkt auf " + Bisafloor.istLeben;
            }

            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void A3_Click_1(object sender, RoutedEventArgs e)
        {
            double altLeben = Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Glurak.Genesung();
            //double schaden = Glurak.Genesung();

            if (altLeben == Glurak.maxLebenwert)
            {
                T1.Text = "Glurak setzt " + Glurak.nameG + " ein, doch \r das Leben ist bereits bereits Maximal.";
            }
            else if (altLeben == Glurak.istLeben)
            {
                T1.Text = "Glurak setzt " + Glurak.nameG + " ein, doch es wird \r nicht geheilt.";
            }
            else
            {
                LB1Scale();
                T1.Text = "Glurak setzt " + Glurak.nameG + " ein! \r " /*+ schaden + " Schaden geheilt! \r" */+ "Gluraks Leben steigt auf " + Glurak.istLeben;
            }

            A1.Visibility = Visibility.Hidden;
            A2.Visibility = Visibility.Hidden;
            A3.Visibility = Visibility.Hidden;

            zug = 1;

            EndGme();
        }

        private void B1_Click_1(object sender, RoutedEventArgs e)
        {
            double altleben = Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Bisafloor.Tackle();
            //double schaden = Bisafloor.Tackle();
            if (altleben == Glurak.istLeben)
            {
                T1.Text = "Bisafloor setzt " + Bisafloor.nameT + " ein, \rdoch der Angriff ging ins leere!";
            }
            else
            {
                LB1Scale();
                T1.Text = "Bisafloor setzt " + Bisafloor.nameT + " ein! \r" /*+ schaden + " Schaden verursacht! \r" */+ "Gluraks Leben sinkt auf " + Glurak.istLeben;
            }
            


            B1.Visibility = Visibility.Hidden;
            B2.Visibility = Visibility.Hidden;
            B3.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }

        private void B2_Click_1(object sender, RoutedEventArgs e)
        {
            double altleben=Glurak.istLeben;
            W.Visibility = Visibility.Visible;

            Bisafloor.Rasierblatt();
            //double schaden = Bisafloor.Rasierblatt();

            if (altleben == Glurak.istLeben)
            {
                T1.Text = "Bisafloor setzt " + Bisafloor.nameR + " ein, \rdoch der Angriff ging ins leere!"+altleben+" "+Glurak.istLeben ;
            }
            else
            {
                LB1Scale();
                T1.Text = "Bisafloor setzt " + Bisafloor.nameR + " ein! \r" /*+ schaden + " Schaden verursacht! \r" */+ "Gluraks Leben sinkt auf " + Glurak.istLeben;
            }

            B1.Visibility = Visibility.Hidden;
            B2.Visibility = Visibility.Hidden;
            B3.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }

        private void B3_Click_1(object sender, RoutedEventArgs e)
        {
            double altleben = Bisafloor.istLeben;
            W.Visibility = Visibility.Visible;
            Bisafloor.Genesung();
            
            //double schaden = Bisafloor.Genesung();

            if (altleben == Bisafloor.maxLebenwert)
            {
                T1.Text = "Bisafloor setzt " + Bisafloor.nameG + " ein, doch \r das Leben ist bereits auf dem Maximalwert.";

            }
            else if (altleben == Bisafloor.istLeben)
            {
                T1.Text = "Bisafloor setzt " + Bisafloor.nameG + " ein, doch \r es wurde nicht geheilt.";
            }
            else
            {
                LB1Scale();
                T1.Text = "Bisafloor setzt " + Bisafloor.nameG + " ein! \r" /*+ schaden + " Schaden verursacht! \r" */+ "Bisafloors Leben steigt auf " + Bisafloor.istLeben;
            }

            B1.Visibility = Visibility.Hidden;
            B2.Visibility = Visibility.Hidden;
            B3.Visibility = Visibility.Hidden;

            zug = 2;

            EndGme();
        }

        private void W1_Click_1(object sender, RoutedEventArgs e)
        {
            if (zug ==2)
            {
                T1.Text = "";

                A1.Visibility = Visibility.Visible;
                A2.Visibility = Visibility.Visible;
                A3.Visibility = Visibility.Visible;

                PfeilB.Visibility = Visibility.Hidden;
                PfeilG.Visibility = Visibility.Visible;

                W.Visibility = Visibility.Hidden;

                zug = 0;
            }
            else if(zug ==1)
            {
                T1.Text = "";

                B1.Visibility = Visibility.Visible;
                B2.Visibility = Visibility.Visible;
                B3.Visibility = Visibility.Visible;

                W.Visibility = Visibility.Hidden;

                PfeilG.Visibility = Visibility.Hidden;
                PfeilB.Visibility = Visibility.Visible;

                zug = 0;
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

        private void A1_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

        private void A2_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

        private void A3_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

        private void B1_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

        private void B2_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

        private void B3_Leave(object sender, MouseEventArgs e)
        {
            T2.Visibility = Visibility.Hidden;
        }

    }
}
