using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Operando
	{
		private double numero;

		#region Constructor
		/// <summary>
		/// Constructor operando sin parametros
		/// </summary>
		public Operando()
		{
			this.numero = 0;
		}
		/// <summary>
		/// Constructor operando con parametros
		/// </summary>
		/// <param name="numero">Número a setear</param>
		public Operando(double numero)
		{
			this.numero = numero;
		}
		/// <summary>
		/// Constructor operando con parametros
		/// </summary>
		/// <param name="numero">Número a setear (en formato string) </param>
		public Operando(string numero)
		{
			this.Numero = numero;
		}
		#endregion

		#region Propiedades
		/// <summary>
		/// Propiedad numero, valida y asigna el operando al atributo numero
		/// </summary>
		private string Numero
		{
			set
			{
				this.numero = ValidarOperando(value);
			}
		}
		#endregion

		/// <summary>
		/// Valida el numero
		/// </summary>
		/// <param name="strNumero">Número a parsear </param>
		/// <returns> De ser validado devuelve el número, caso contrario retorna 0 </returns>
		private double ValidarOperando(string strNumero)
		{
			double num = 0;
			if (double.TryParse(strNumero, out num))
			{
				num = double.Parse(strNumero);
			}
			return num;
		}
		#region Metodos
		/// <summary>
		/// Verifica si el número es binario
		/// </summary>
		/// <param name="binario"> String binario a ser verificado </param>
		/// <returns> Devuelve true si la cantidad de 0's y 1's es igual al tamaño del string. Caso contrario, retorna false </returns>
		private bool EsBinario(string binario)
		{
			int cont = 0;
			foreach (char a in binario)
			{
				if (a == '0' || a == '1')
				{
					cont++;
				}
			}

			return cont == binario.Length;
		}
		/// <summary>
		/// Convierte un numero binario a decimal
		/// </summary>
		/// <param name="binario"> String binario a ser convertido</param>
		/// <returns> Devuelve el numero convertido a decimal. De no ser posible, retorna "Valor inválido" </returns>
		public string BinarioDecimal(string binario)
		{
			string retorno = "Valor inválido";
			if (EsBinario(binario))
			{
				int numero = Convert.ToInt32(binario, 2);
				retorno = Math.Abs(numero).ToString();
			}
			return retorno;
		}
		/// <summary>
		/// Convierte un numero de decimal a binario
		/// </summary>
		/// <param name="numero"> Numero a ser convertido </param>
		/// <returns> Devuelve el numero convertido a binario. De no ser posible, retorna "Valor inválido" </returns>
		public string DecimalBinario(double numero)
		{
			string retorno = "Valor inválido";
			if (!EsBinario(numero.ToString()) && numero>0)
			{
				string binary = Convert.ToString((int)numero, 2);
				retorno = binary;

			}
			return retorno;
		}
		/// <summary>
		/// Convierte un numero de decimal a binario 
		/// </summary>
		/// <param name="numero"> Número a ser convertido (en formato string) </param>
		/// <returns> Devuelve el numero convertido a binario. De no ser posible, retorna "Valor inválido" </returns>
		public string DecimalBinario(string numero)
		{
			string retorno;
			this.Numero = numero;
			retorno = DecimalBinario(this.numero);
			return retorno;
		}
		#endregion

		#region Sobrecarga de operadores
		/// <summary>
		/// Sobrecarga del operador +
		/// </summary>
		public static double operator +(Operando n1, Operando n2)
		{
			return n1.numero + n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador -
		/// </summary>
		public static double operator -(Operando n1, Operando n2)
		{
			return n1.numero - n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador *
		/// </summary>
		public static double operator *(Operando n1, Operando n2)
		{
			return n1.numero * n2.numero;
		}
		/// <summary>
		/// Sobrecarga del operador /
		/// </summary>
		public static double operator /(Operando n1, Operando n2)
		{
			return n2.numero != 0 ? n1.numero / n2.numero : double.MinValue;
		}
		#endregion
	}
}
