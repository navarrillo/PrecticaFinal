﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public gesReserva.ReservaEdicion[] listaReservas;
        private string emailLogged;

        public Form1(string email)
        {
            InitializeComponent();
            this.emailLogged = email;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            proveedores.ReservaPersRequest resRequest = new proveedores.ReservaPersRequest();
            proveedores.ReservaPersBinding resBinding = new proveedores.ReservaPersBinding();

            resRequest.ski = false;
            resRequest.material = false;
            resRequest.profesor = false;
            resRequest.alojamiento = false;

            if (checkBox1.Checked) resRequest.ski = true;
            if (checkBox2.Checked) resRequest.material = true;
            if (checkBox3.Checked) resRequest.profesor = true;
            if (checkBox4.Checked) resRequest.alojamiento = true;

            //obtenemos los dias que se va a ir
            int dias = (DateTime.Parse(dateTimePicker2.Text) - (DateTime.Parse(dateTimePicker1.Text))).Days+1;
            resRequest.unidades = Int32.Parse(textBox1.Text)*dias;

            proveedores.ReservaPersResponse response = resBinding.process(resRequest);
            string str = response.precio.ToString();
            string proveedor = response.proveedor;

            gesReserva.ReservaEdicion res = new gesReserva.ReservaEdicion();
            
            res.fechaEntrada = DateTime.Parse(dateTimePicker1.Text);
            res.fechaSalida = DateTime.Parse(dateTimePicker2.Text);
            res.emailCliente = textBox3.Text;
            res.nombreCliente = textBox4.Text;
            res.precio = response.precio;
            res.material = resRequest.material;
            res.profesor = resRequest.profesor;
            res.ski = resRequest.profesor;
            res.alojamiento = resRequest.alojamiento;
            // Abrimos nueva pantalla para mostrar los datos de la reserva
            RealizaReserva resFrm = new RealizaReserva(res,proveedor,textBox1.Text);
            resFrm.Show();
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reserva_Click(object sender, EventArgs e)
        {
            

        }

        // Hacemos la llamade para ver todas las reservas
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Reservas.Items.Clear();
            gesReserva.GestionReserva reserva = new gesReserva.GestionReserva();

            listaReservas = reserva.LeerReservaMail(this.emailLogged);

            foreach (gesReserva.ReservaEdicion res in listaReservas)
            {
                //MessageBox.Show(res.nombreCliente);
                Reservas.Items.Add("ID: "+res.id+ " - precio: "+res.precio);
            }
   
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_editarReserva_Click(object sender, EventArgs e)
        {
             String id = tb_idEditReserva.Text.ToString();

             foreach (gesReserva.ReservaEdicion res in listaReservas)
             {
                 //MessageBox.Show(res.nombreCliente);
                 if (res.id.ToString() == id)
                 {
                     //ModificarReserva formModifica = new ModificarReserva();
                     //formModifica.Show(res);
                     ModificarReserva formModifica = new ModificarReserva(res);
                     formModifica.Show();

                    // this.Hide();
                 }
                 else
                 {
                     MessageBox.Show("No existe esa id");
                 }
                 
             }

        }


    }
}
