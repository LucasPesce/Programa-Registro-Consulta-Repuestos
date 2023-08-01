using System;
using System.Linq;
using System.Windows.Forms;

namespace TP_Baquero_Lucas
{
    public partial class Form1 : Form
    {
        public struct CLIENTE
        {
            public int NumeroRepuesto;
            public string Marca;
            public string Origen;
            public string Descripcion;
            public float Precio;
        }
        public CLIENTE[] Clientes;
        const int MAX = 100;
        public int CONTADOR;

        public Form1()
        {
            InitializeComponent();
        }
        // CARGA DEL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            Clientes = new CLIENTE[MAX];
            CONTADOR = 0;

            cmbMarca.Items.Add("P");
            cmbMarca.Items.Add("F");
            cmbMarca.Items.Add("R");

            cmbMarcaConsulta.Items.Add("P");
            cmbMarcaConsulta.Items.Add("F");
            cmbMarcaConsulta.Items.Add("R");

            cmbMarcaConsulta.SelectedIndex = 0;

            opcNacional.Checked = true;

            cmbOrigen.Items.Add("N");
            cmbOrigen.Items.Add("I");

            listaConsulta.Items.Add("Número \t\t" + "Descripción \t\t\t\t\t" + "Precio");

            Limpiar();
        }
        //BOTON LIMPIAR
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //METODO LIMPIAR
        private void Limpiar()
        {
            txtNumRepuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cmbMarca.SelectedIndex = 0;
            cmbOrigen.SelectedIndex = 0;
        }
        //BOTON REGISTRAR
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (ValidarDatos())
            {
                Clientes[CONTADOR].NumeroRepuesto = int.Parse(txtNumRepuesto.Text);
                Clientes[CONTADOR].Marca = cmbMarca.Text;
                Clientes[CONTADOR].Origen = cmbOrigen.Text;
                Clientes[CONTADOR].Descripcion = txtDescripcion.Text;
                Clientes[CONTADOR].Precio = float.Parse(txtPrecio.Text);

                CONTADOR++;

                if(CONTADOR == MAX)
                {
                    MessageBox.Show("Se completo la capacidad de carga de datos",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false;
                }

                Limpiar();
            }
        }

        //METODO DE VALIDACION DE DATOS
        private bool ValidarDatos()
        {
            bool VALIDACION = false;
            if (txtNumRepuesto.Text != "" && txtDescripcion.Text != "" && txtPrecio.Text != "")
            {
                if (!BuscarNumero(int.Parse(txtNumRepuesto.Text)))
                {
                    VALIDACION = true;
                }
                else
                {
                    MessageBox.Show("El numero de repuesto ya existe", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumRepuesto.Focus();
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes","ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return VALIDACION;
        }

        //METODO DE BUSCAR NUMERO EXISTENTE
        private bool BuscarNumero(int Numero) 
        {
            bool Existe = false;
            for(int i = 0; i < CONTADOR; i++)
            {
                if(Numero == Clientes[i].NumeroRepuesto)
                {
                    Existe = true;
                    break;
                }
            }
            return Existe;
        }

        //CONFIGURACION DEL CAMPO DE TEXTO NUMERO DE REPUESTO
        private void txtNumRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        //CONFIGURACION DEL CAMPO DE TEXTO DE PRECIO
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && txtPrecio.Text.Contains('.'))
            {
                e.Handled = true;
            }

            else if (e.KeyChar == '.')  //Fuerzo el uso de la "," porque si no, al mostrarlo por la lista, no me lo reconoce cuando utilizo el "."
            {
                e.KeyChar = ',';
            }
        }

        //CONFIGURACION DEL CAMPO MARCA
        private void cmbMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] LetrasPermitidas = { 'P', 'R', 'F', 'p', 'r', 'f' };
            if(!LetrasPermitidas.Contains(char.ToUpper(e.KeyChar)) && !LetrasPermitidas.Contains(char.ToLower(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        //CONFIGURACION DEL CAMPO ORIGEN
        private void cmbOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] LetrasPermitidas = { 'N', 'I', 'n', 'i' };
            if (!LetrasPermitidas.Contains(char.ToUpper(e.KeyChar)) && !LetrasPermitidas.Contains(char.ToLower(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        //CONFIGURACION DEL CAMPO MARCA CONSULTA
        private void cmbMarcaConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] LetrasPermitidas = { 'P', 'R', 'F', 'p', 'r', 'f' };
            if (!LetrasPermitidas.Contains(char.ToUpper(e.KeyChar)) && !LetrasPermitidas.Contains(char.ToLower(e.KeyChar))
                && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (Char.IsLower(e.KeyChar))
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
        }

        //BOTON CONSULTA
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            listaConsulta.Items.Clear();
            listaConsulta.Items.Add("Número \t\t" + "Descripción \t\t\t\t\t" + "Precio");

            for (int i = 0; i < CONTADOR; i++)
            {
                if(opcNacional.Checked == true)
                {
                    switch(cmbMarcaConsulta.Text)
                    {
                        case "P":
                            if(cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "N")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto+" \t\t"+ Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                        case "F":
                            if (cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "N")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto + " \t\t" + Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                        case "R":
                            if (cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "N")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto + " \t\t" + Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                    }
                }
                else if (opcImportado.Checked == true)
                {
                    switch (cmbMarcaConsulta.Text)
                    {
                        case "P":
                            if (cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "I")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto + " \t\t" + Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                        case "F":
                            if (cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "I")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto + " \t\t" + Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                        case "R":
                            if (cmbMarcaConsulta.Text == Clientes[i].Marca && Clientes[i].Origen == "I")
                            {
                                listaConsulta.Items.Add(Clientes[i].NumeroRepuesto + " \t\t" + Clientes[i].Descripcion + " \t\t\t\t\t\t" + Clientes[i].Precio.ToString("0.00"));
                            }
                            break;
                    }
                }
            }
        }
    }
}


