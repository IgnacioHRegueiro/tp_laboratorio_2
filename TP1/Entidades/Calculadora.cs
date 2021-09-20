using System;

namespace Entidades
{
	public static class Calculadora
	{
		/// <summary>
		/// Valida el operador
		/// </summary>
		/// <param name="operador"> Operador a ser validado </param>
		/// <returns> En caso de ser validado, devuelve el operador. Caso contrario, devuelve "+" </returns>
		private static char ValidarOperando(char operador)
		{
			char retorno;

			
			switch (operador)
			{
				case '-':
					retorno = operador;
					break;
				case '*':
					retorno = operador;
					break;
				case '/':
					retorno = operador;
					break;
				default:
					retorno = '+';
					break;
			}
			return retorno;
		}
		/// <summary>
		/// Realiza la operacion
		/// </summary>
		/// <param name="num1"> Primer número a operar </param>
		/// <param name="num2"> Segundo número a operar </param>
		/// <param name="operador"> Operador a utilizar para realizar el cálculo </param>
		/// <returns> Devuelve el resultado correspondiendo al cálculo realizado </returns>
		public static double Operar(Operando num1, Operando num2, char operador)
		{
			char opr;
			double resultado = 0;
			opr = ValidarOperando(operador);

			switch (opr)
			{
				case '+':
					resultado = num1 + num2;
					break;
				case '-':
					resultado = num1 - num2;
					break;
				case '*':
					resultado = num1 * num2;
					break;
				case '/':
					resultado = num1 / num2;
					break;
			}
			return resultado;
		}
	}
}
