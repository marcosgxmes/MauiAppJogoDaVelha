using System;
using System.Runtime.Intrinsics.X86;

namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        
        string vez = "X";
        int cont = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if(vez == "X")
            {
                btn.Text = "X";
                vez = "O";
                cont++;
            } else
            {
                btn.Text = "O";
                vez = "X";
                cont++;
            };

            

            /* VERIFICANDO SE "X" GANHOU */
            if(btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X" ||
               btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X" ||
               btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X" ||

               btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X" ||
               btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X" ||
               btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X" ||

               btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X" ||
               btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X"
               )
            {
                DisplayAlert("Parabéns!", "O jogador ( X ) venceu!", "Fechar");
                Zerar();          
            }         
            /* VERIFICANDO SE "O" GANHOU */
            else if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O" ||
                btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O" ||
                btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O" ||

                btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O" ||
                btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O" ||
                btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O" ||

                btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O" ||
                btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"
                )
            {
                DisplayAlert("Parabéns!", "O jogador ( O ) venceu!", "Fechar");
                Zerar();               
            } else if (cont == 9)
            {
                DisplayAlert("Deu velha!", "Ninguém venceu!", "Fechar");
                Zerar() ;
            }


        } // Fecha método

        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;

            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;

            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            cont = 0;
        }

    } // Fecha  Classe

} // Fecha Namespaec
