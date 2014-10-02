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
		    /*Aqui pide los datos del primer producto*/
			Console.WriteLine("Dame la cantidad de productos #1");
			int cantidad_prod1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #1");
			String desc_prod1;
			desc_prod1 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #1");
			int Precio_prod1 = int.Parse(Console.ReadLine());
			
			/*Aqui pide los datos del segundo producto*/
			Console.WriteLine("Dame la cantidad de productos #2");
			int cantidad_prod2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #2");
			String desc_prod2;
			desc_prod2 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #2");
			int Precio_prod2 = int.Parse(Console.ReadLine());
			
			/*Aqui pide los datos del tercer producto*/
			Console.WriteLine("Dame la cantidad de productos #3");
			int cantidad_prod3 = int.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #3");
			String desc_prod3;
			desc_prod3 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #3");
			int Precio_prod3 = int.Parse(Console.ReadLine());
			
			/*Aqui da la lista de los productos*/
			Console.WriteLine("Esta es la cantidad de productos: " +"           "+ cantidad_prod1 +"         "+
			                  cantidad_prod2 +"         "+ cantidad_prod3);
			
			/*Aqui da la lista de los productos*/
			Console.WriteLine("Esta es la descripcion de los productos: " +"   "+ desc_prod1 +"   "+
			                  desc_prod2 +"   "+ desc_prod3);
			
			/*Aqui da la lista de los productos*/ 
			Console.WriteLine("Estos son los precios de los productos: " +"      "+ Precio_prod1 +"      "+
			                 Precio_prod2 +"      "+ Precio_prod3);
			
			Console.ReadKey(true);
		}
	}
}