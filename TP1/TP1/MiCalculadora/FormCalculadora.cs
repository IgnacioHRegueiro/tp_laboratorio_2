using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
	public partial class FormCalculadora : Form
	{
		public FormCalculadora()
		{
			InitializeComponent();
		}

		private void btnOperar_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrWhiteSpace(txtNumero1.Text) || String.IsNullOrWhiteSpace(txtNumero2.Text))
			{
				MessageBox.Show("Ambos números deben estar presentes para poder realizar la operación", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				double resultado = Operar(txtNumero1.Text, txtNumero2.Text, cbmOperadores.SelectedItem.ToString());
				if (resultado != Double.MinValue)
				{
					lstOperaciones.Items.Add(txtNumero1.Text + " " + cbmOperadores.SelectedItem.ToString() + " " + txtNumero2.Text + " = " + resultado);
				}
				else
				{
					lstOperaciones.Items.Add(txtNumero1.Text + " " + cbmOperadores.SelectedItem.ToString() + " " + txtNumero2.Text + " = Syntax error");
					lblBinary.Text = resultado.ToString();
				}
			}
		}

		private void btnCerrar_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes) Application.Exit();
		}

		private void btnConvertirBinario_Click(object sender, EventArgs e)
		{
			string dec = lstOperaciones.SelectedItem.ToString();
			Operando bin = new Operando();
			string resultadoBin = bin.DecimalBinario(dec);
			lblBinary.Text = resultadoBin;
			lstOperaciones.Items.Add(resultadoBin);
		}

		private void btnConvertirDecimal_Click(object sender, EventArgs e)
		{
			string binary = lstOperaciones.SelectedItem.ToString();
			Operando bin = new Operando();
			string resultado = bin.BinarioDecimal(binary);
			lblBinary.Text = resultado;
			lstOperaciones.Items.Add(resultado);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Limpiar();
		}

		private void btnLimpiar_Click(object sender, EventArgs e)
		{
			this.Limpiar();
		}

		private void Limpiar()
		{
			cbmOperadores.SelectedIndex = 0;
			btnConvertirBinario.Enabled = false;
			btnConvertirDecimal.Enabled = false;
			txtNumero1.Text = "";
			txtNumero2.Text = "";
			lblBinary.Text = "0";
			lstOperaciones.Items.Clear();

		}

		private static double Operar(string numero1, string numero2, string operando)
		{
			double resultado;
			char opr = '+';
			foreach (char c in operando)
			{
				opr = c;
			}
			Operando num1 = new Operando(numero1);
			Operando num2 = new Operando(numero2);
			resultado = Calculadora.Operar(num1, num2, opr);
			return resultado;
		}

		private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
		{
			btnConvertirBinario.Enabled = true;
			btnConvertirDecimal.Enabled = true;
		}
	}
}
