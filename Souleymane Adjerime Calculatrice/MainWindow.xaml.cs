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

namespace SOULEYMANE_ADJERIME_CALCULATRICE
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        double premierNombre = 0;
        string operateur = "";
        bool nouveauNombre = true;

        public MainWindow()
        {
            InitializeComponent();

            TB_Display.Text = "0";
        }


        // =========================
        // CHIFFRES
        // =========================

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("0");
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("1");
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("2");
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("3");
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("4");
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("5");
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("6");
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("7");
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("8");
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            AjouterChiffre("9");
        }


        // =========================
        // AJOUTER UN CHIFFRE
        // =========================

        private void AjouterChiffre(string chiffre)
        {
            // Si on vient de lancer la calculatrice
            // ou qu'on vient d'utiliser un opérateur
            if (nouveauNombre)
            {
                TB_Display.Text = chiffre;
                nouveauNombre = false;
            }
            else
            {
                // Remplace le 0 au début
                if (TB_Display.Text == "0")
                {
                    TB_Display.Text = chiffre;
                }
                else
                {
                    TB_Display.Text += chiffre;
                }
            }
        }


        // =========================
        // POINT
        // =========================

        private void BTN_Point_Click(object sender, RoutedEventArgs e)
        {
            if (nouveauNombre)
            {

                nouveauNombre = false;
            }
            else
            {

                {

                }
            }
        }

        private void BTN_C_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0";
        }


        // =========================
        // C
        // =========================

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            ChoisirOperateur("+");
        }


        // =========================
        // MOINS
        // =========================

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            ChoisirOperateur("-");
        }


        // =========================
        // MULTIPLICATION
        // =========================

        private void BTN_Multiplication_Click(object sender, RoutedEventArgs e)
        {
            ChoisirOperateur("*");
        }


        // =========================
        // DIVISION
        // =========================

        private void BTN_Division_Click(object sender, RoutedEventArgs e)
        {
            ChoisirOperateur("/");
        }


        // =========================
        // CHOISIR OPERATEUR
        // =========================

        private void ChoisirOperateur(string nouvelOperateur)
        {
            double.TryParse(TB_Display.Text, out premierNombre);

            operateur = nouvelOperateur;

            nouveauNombre = true;
        }


        // =========================
        // EGAL
        // =========================

        private void BTN_Egal_Click(object sender, RoutedEventArgs e)
        {
            double deuxiemeNombre;

            if (!double.TryParse(TB_Display.Text, out deuxiemeNombre))
            {
                return;
            }

            double resultat = 0;

            if (operateur == "+")
            {
                resultat = premierNombre + deuxiemeNombre;
            }
            else if (operateur == "-")
            {
                resultat = premierNombre - deuxiemeNombre;
            }
            else if (operateur == "*")
            {
                resultat = premierNombre * deuxiemeNombre;
            }
            else if (operateur == "/")
            {
                if (deuxiemeNombre == 0)
                {
                    TB_Display.Text = "Erreur";
                    nouveauNombre = true;
                    return;
                }

                resultat = premierNombre / deuxiemeNombre;
            }

            TB_Display.Text = resultat.ToString();

            nouveauNombre = true;
        }


    }
}
