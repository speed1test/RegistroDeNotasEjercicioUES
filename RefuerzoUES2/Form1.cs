using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefuerzoUES2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void brnFuncion_Click(object sender, EventArgs e)
        {
            int cant = 10;
            double[] notas = new double[cant];
            String[] nombres = new string[cant];
            string texto = String.Empty;
            try
            {
                for (int i = 0; i < cant; i++)
                {
                    nombres[i] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese un nombre: ");
                    notas[i] = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese una nota: "));
                }
                for (int i = 0; i < cant; i++) 
                {
                    texto += "Nombre: " + nombres[i] + " " +"Nota: " + notas[i] + "\n";
                }
                MessageBox.Show(texto);
            }
            catch
            {
                MessageBox.Show("Produjo un error o usted se salio del programa");
            }
        }
    }
}
