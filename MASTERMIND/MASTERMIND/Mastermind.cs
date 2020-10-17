using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MASTERMIND
{
    public partial class Mastermind : UserControl
    {
        private const int codigoSize = 4;
        private const int colores = 6;
        private const int intentosTotales = 8;
        public  int intentosActuales = 0;
        public int intentosRestantes1 = 8;





        private Random random = new Random();
        private bool gameStarted = false;
        protected internal char[] CodigoSecreto = new char[4];



        public Mastermind()
        {
      
        InitializeComponent();
        setupGame();

      
    }


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            iniciarJuego();
        }


        private void btnCheck_Click(object sender, EventArgs e)      
        {
            intentosActuales++;
            intentosRestantes1 = intentosRestantes1 - 1;

         int aciertosParciales1 = 0;
         int aciertosTotales1 = 0;

            string codigoTextoBox = codigo.Text;
            char[] CodigoIngresado = codigoTextoBox.ToCharArray();

            if(CodigoIngresado.Length > 3) { 

            for (int i = 0; i < 4; i++)
            {
                if (CodigoSecreto[i] == CodigoIngresado[i])
                {
                    aciertosTotales1++;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++) { 
                if (CodigoSecreto[i] == CodigoIngresado[j])
                {
                        aciertosParciales1++;
                }
               }
              }
            }
            else
            {
                MessageBox.Show("Dijite cuatro caracteres" , " Codigo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            mostrarPista(aciertosTotales1, aciertosParciales1);

            if(aciertosTotales1 == codigoSize)
            {
                MessageBox.Show("Completo el juego" + (intentosActuales) + " intentos!", "Ha ganado el juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                endGame();
            }


            if (intentosActuales > 7)
            {
                MessageBox.Show("Lo siento, no ha logrado decifrar el codigo en 8 intentos", "Ha perdido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                endGame();
            }

        }

        private void mostrarPista(int aciertosTotales1, int aciertosParciales1)
        {
            aciertosParciales.Text = "Aciertos parciales: " + aciertosParciales1;
            aciertosTotales.Text = "Aciertos totales: " + aciertosTotales1;
            intentoActual.Text = "Intento Actual: " + intentosActuales;
            intentosRestantes.Text = "Intentos restantes: " + intentosRestantes1;
        }

        private void iniciarJuego()
        {
           for (int i = 0; i < 4; i++) {
                bool repetido = false;
                int rnd = random.Next(1, 7);
                switch (rnd)
                {
                    case 1:  
                        for (int j = 0; j < CodigoSecreto.Length; j++){
                            if (CodigoSecreto[j] == 'A')
                            {
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'A';
                        }else{
                            i = i - 1;
                        }

                        break;
                    case 2:
                        for (int j = 0; j < CodigoSecreto.Length; j++)
                        {
                            if (CodigoSecreto[j] == 'R')
                            {
                                repetido = true;
                            }
                            
                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'R';
                        }
                        else
                        {
                            i = i - 1;
                        }

                        break;
                    case 3:
                        for (int j = 0; j < CodigoSecreto.Length; j++)
                        {
                            if (CodigoSecreto[j] == 'B')
                            {
                                repetido = true;
                            }
                           
                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'B';
                        }
                        else
                        {
                            i = i - 1;
                        }
                        break;
                    case 4:
                        for (int j = 0; j < CodigoSecreto.Length; j++)
                        {
                            if (CodigoSecreto[j] == 'N')
                            {
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'N';
                        }
                        else
                        {
                            i = i - 1;
                        }

                        break;
                    case 5:
                        for (int j = 0; j < CodigoSecreto.Length; j++)
                        {
                            if (CodigoSecreto[j] == 'V')
                            {
                                repetido = true;
                            }
                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'V';
                        }
                        else
                        {
                            i = i - 1;
                        }

                        break;
                    case 6:
                        for (int j = 0; j < CodigoSecreto.Length; j++)
                        {
                            if (CodigoSecreto[j] == 'M')
                            {
                                repetido = true;
                            }

                        }
                        if (repetido == false)
                        {
                            CodigoSecreto[i] = 'M';
                        }
                        else
                        {
                            i = i - 1; 
                        }
                        
                        break;

                }  
            }
          
            //string codigo1 = CodigoSecreto.ToString();
            //Console.WriteLine(CodigoSecreto);
         
            btnIniciar.Enabled = false;
            btnCheck.Visible = true;
            gameStarted = true;
          
            }


        private void endGame()
        {
            gameStarted = false;
            btnIniciar.Enabled = true;
            btnCheck.Visible = false;
            intentosActuales = 0; 



        }


        private void setupGame()
        {
            gameStarted = false;
            btnCheck.Visible = false;
   
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void Mastermind_Load(object sender, EventArgs e)
        {

        }
    }
}
