using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.UserControls
{
    public partial class UC_CalculeSci : UserControl
    {
        private string saisie = "", ensembleur = "";
        private double resultat = 0.0;
        private string signe = "";
        private int parenthese = 0, signeResultat = 0;


        //string[] tableauOperateur = new string[23];
        //string[] tableauValeur = new string[46];
        public UC_CalculeSci()
        {
            InitializeComponent();
        }
        private void UC_CalculeSci_Load(object sender, EventArgs e)
        {

        }

        // Boution Nombre (button Number)
        private void btn0_Click(object sender, EventArgs e)
        {
            Saisie += 0;
            Ensembleur += 0;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Saisie += 1;
            Ensembleur += 1;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Saisie += 2;
            Ensembleur += 2;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Saisie += 3;
            Ensembleur += 3;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Saisie += 4;
            Ensembleur += 4;
            final(Signe, Ensembleur, Saisie);
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            Saisie += 5;
            Ensembleur += 5;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Saisie += 6;
            Ensembleur += 6;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Saisie += 7;
            Ensembleur += 7;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Saisie += 8;
            Ensembleur += 8;
            final(Signe, Ensembleur, Saisie);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Saisie += 9;
            Ensembleur += 9;
            final(Signe, Ensembleur, Saisie);
        }

        // Bouton de controlles (button of controles)
        private void btnclear_Click(object sender, EventArgs e)
        {
            Parenthese = 0;
            Saisie = "";
            Signe = "";
            Ensembleur = "";
            Resultat = 0.0;
            ChampResultat.Text = ".";
            ChanpSaisie.Text = Saisie;
        }

        private void btnPrtz_Click(object sender, EventArgs e) 
        {
            Image imageDroite;
            if(Signe != "")
            {
                imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                AlerteMessage(imageDroite);
                if (Parenthese == 0)
                {
                    Parenthese = 1;
                    Ensembleur += "(";
                }
                else
                {
                    Parenthese = 0;
                    Ensembleur += ")";
                }
                ChanpSaisie.Text = Ensembleur;
            }
            else
            {
                imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                AlerteMessage(imageDroite);
            }

        }



        private void BtnPrtg_Click(object sender, EventArgs e)
        {
            Image imageDroite;
            if (Saisie != "")
            {
                imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                AlerteMessage(imageDroite);
                if (Resultat == 0.0)
                {
                    Resultat = (double)Convert.ToDouble(Saisie);
                }
                Resultat = Resultat / 100;
                ChanpSaisie.Text = Convert.ToString(resultat);
                ChampResultat.Text = Convert.ToString(resultat);
            }
            else
            {
                ChanpSaisie.Text = "NaN";
                ChampResultat.Text = "😞";
                imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                AlerteMessage(imageDroite);
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Signe = "div";
            finalOperator(Signe, Saisie);
        }

        private void btnMlt_Click(object sender, EventArgs e)
        {
            Signe = "mul";
            finalOperator(Signe, Saisie);
        }
        private void btnMn_Click(object sender, EventArgs e)
        {
            Signe = "sus";
            finalOperator(Signe, Saisie);
        }

        private void btnPl_Click(object sender, EventArgs e)
        {
            Signe = "add";
            finalOperator(Signe, Saisie);
        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            ChanpSaisie.Text = Resultat.ToString();
            ChampResultat.Text = Resultat.ToString();
        }

        private void btnPtn_Click(object sender, EventArgs e)
        {
            Image imageDroite;
            if(Saisie != "")
            {
                 imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                 AlerteMessage(imageDroite);
                if(Resultat == 0.0)
                {
                    Resultat = 0.0 + Convert.ToDouble(Saisie);
                }
                else
                {
                    Resultat = 0.0;
                }
                 
                 Ensembleur += ",";
                 ChanpSaisie.Text = Ensembleur;
                 ChampResultat.Text = Resultat.ToString();
            }
            else
            {
                imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                AlerteMessage(imageDroite);
            }
        }

        private void btnMP_Click(object sender, EventArgs e)
        {
            Image imageDroite;
            if (Saisie != "")
            {
                imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                AlerteMessage(imageDroite);
                if (Resultat == 0.0)
                {
                    Resultat = 0.0 + Convert.ToDouble(Saisie);
                    if(SigneResultat == 0)
                    {
                        Resultat *= -1;
                    }
                }
                else
                {
                    Resultat *= -1;
                }

                ChanpSaisie.Text = Resultat.ToString();
                ChampResultat.Text = Resultat.ToString();
            }
            else
            {
                imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                AlerteMessage(imageDroite);
            }
        }
        // finale result (Resultat final)

        private void AlerteMessage(Image valeur)
        {
            try
            {
                ChanpSaisie.IconRight = valeur;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." +
                    "Check the path to the image file.");
            }
        }

        private void final(string valeur1, string valeur2, string valeur3)
        {
            switch (valeur1)
            {
                case "div":
                    ChanpSaisie.Text = valeur2;
                    Resultat = Resultat / Convert.ToDouble(valeur3);
                    ChampResultat.Text = Resultat.ToString();
                    break;
                case "mul":
                    ChanpSaisie.Text = valeur2;
                    Resultat = Resultat * Convert.ToDouble(valeur3);
                    ChampResultat.Text = Resultat.ToString();
                    break;
                case "sus":
                    ChanpSaisie.Text = valeur2;
                    Resultat = Resultat - Convert.ToDouble(valeur3);
                    ChampResultat.Text = Resultat.ToString();
                    break;
                case "add":
                    ChanpSaisie.Text = valeur2;
                    Resultat = Resultat + Convert.ToDouble(valeur3);
                    ChampResultat.Text = Resultat.ToString();
                    break;
                default:
                    ChanpSaisie.Text = valeur3;
                    break;
            }
        }

        private void finalOperator(string valeur1, string valeur2)
        {
            Image imageDroite;
            switch (valeur1)
            {
                case "div":
                    if (valeur2 != "")
                    {
                        Signe = "div";
                        if (Resultat == 0.0)
                        {
                            Resultat = (double)Convert.ToDouble(Saisie);
                        }
                        Saisie = "";
                        Ensembleur += " / ";
                        ChanpSaisie.Text = Ensembleur;
                        imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                        AlerteMessage(imageDroite);
                    }
                    else
                    {
                        ChanpSaisie.Text = "NaN";
                        ChampResultat.Text = "😞";
                        Signe = "";
                        imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                        AlerteMessage(imageDroite);
                    }
                    break;
                case "mul":
                    if (valeur2 != "")
                    {
                        Signe = "mul";
                        if (Resultat == 0.0)
                        {
                            Resultat = (double)Convert.ToDouble(Saisie);
                        }
                        Saisie = "";
                        Ensembleur += " * ";
                        ChanpSaisie.Text = Ensembleur;
                        imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                        AlerteMessage(imageDroite);
                    }
                    else
                    {
                        ChanpSaisie.Text = "NaN";
                        ChampResultat.Text = "😞";
                        Signe = "";
                        imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                        AlerteMessage(imageDroite);
                    }
                    break;
                case "sus":
                    if (valeur2 != "")
                    {
                        Signe = "sus";
                        if(Resultat == 0.0)
                        {
                            Resultat = (double)Convert.ToDouble(Saisie);
                        }
                        Saisie = "";
                        Ensembleur += " - ";
                        ChanpSaisie.Text = Ensembleur;
                        imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                        AlerteMessage(imageDroite);
                    }
                    else
                    {
                        ChanpSaisie.Text = "NaN";
                        ChampResultat.Text = "😞";
                        Signe = "";
                        imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                        AlerteMessage(imageDroite);
                    }
                    break;
                case "add":
                    if (valeur2 != "")
                    {
                        Signe = "add";
                        if (Resultat == 0.0)
                        {
                            Resultat = (double)Convert.ToDouble(Saisie);
                        }
                        Saisie = "";
                        Ensembleur += " + ";
                        ChanpSaisie.Text = Ensembleur;
                        imageDroite = Calculator.Properties.Resources.icons8_calculator_50;
                        AlerteMessage(imageDroite);
                    }
                    else
                    {
                        ChanpSaisie.Text = "NaN";
                        ChampResultat.Text = "😞";
                        Signe = "";
                        imageDroite = Calculator.Properties.Resources.icons8_spam_50px_1;
                        AlerteMessage(imageDroite);
                    }
                    break;
                default:

                    break;
            }
        }


        // Getter and Setter (Recepteur et commutateur)
        private String Saisie
        {
            get { return saisie; }
            set { saisie = value; }
        }
        private string Ensembleur
        {
            get { return ensembleur; }
            set { ensembleur = value; }
        }

        private double Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        private string Signe
        {
            get { return signe; }
            set { signe = value; }
        }

       public int SigneResultat
        {
            get { return signeResultat; }
            set { signeResultat = value; }
        }

        private int Parenthese
        {
            get { return parenthese; }
            set { parenthese = value; }
        }


    }
}
