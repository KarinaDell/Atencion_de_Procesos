﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atencion_de_procesos
{
    public partial class Form1 : Form
    {
        Procesador procesador;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            procesador = new Procesador();
            procesador.iniciarProcesador();
            txtCiclosVacios.Text = procesador.Vacio.ToString();
            txtProcesoComp.Text = procesador.Completo.ToString();
            txtProcesoPen.Text = procesador.Ultimo.ToString();
            txtCiclosPen.Text = procesador.ciclosPendientes().ToString();

        }
    }
}
