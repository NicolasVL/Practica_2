/*
 * Created by SharpDevelop.
 * User: Nico
 * Date: 02/10/2014
 * Time: 11:13 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Productos productos = new Productos();
			productos.capturar_datos1();
			productos.capturar_datos2();
			productos.capturar_datos3();
			productos.tabla_productos1();
			productos.tabla_productos2();
			productos.tabla_productos3();
			productos.tabla_operaciones();
			
			Console.WriteLine("GRACIAS POR USAR EL PROGRAMA.");
			
			Console.ReadKey(true);
		}
	}
}