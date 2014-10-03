
using System;

namespace Practica2
{
	public class Productos
	{
		float cantidad_prod1, cantidad_prod2, cantidad_prod3, Precio_prod1, Precio_prod2, Precio_prod3;
		String desc_prod1, desc_prod2, desc_prod3;
		public Productos()
		{
		}
			public void capturar_datos1()
			{
			/*Aqui pide los datos del primer producto*/
			Console.WriteLine("Dame la cantidad de productos #1");
			this.cantidad_prod1 = float.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #1");
			this.desc_prod1 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #1");
			this.Precio_prod1 = float.Parse(Console.ReadLine());
			}
			public void capturar_datos2()
			{
			/*Aqui pide los datos del segundo producto*/
			Console.WriteLine("Dame la cantidad de productos #2");
			this.cantidad_prod2 = float.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #2");
			this.desc_prod2 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #2");
		    this.Precio_prod2 = float.Parse(Console.ReadLine());
			}
			public void capturar_datos3()
			{
			/*Aqui pide los datos del tercer producto*/
			Console.WriteLine("Dame la cantidad de productos #3");
			this.cantidad_prod3 = float.Parse(Console.ReadLine());
			Console.WriteLine("Dame la descripcion del producto #3");
			this.desc_prod3 = Console.ReadLine();
			Console.WriteLine("Dame el precio unitario del producto #3");
			this.Precio_prod3 = float.Parse(Console.ReadLine());
			}
			public void tabla_productos1()
			{
			/*Aqui da la lista de los productos*/
		    Console.WriteLine("Esta es la cantidad de productos: " +"           "+ this.cantidad_prod1 +"         "+
			                  this.cantidad_prod2 +"         "+ this.cantidad_prod3);
			}
			public void tabla_productos2()
			{
			/*Aqui da la lista de los productos*/
			Console.WriteLine("Esta es la descripcion de los productos: " +"   "+ this.desc_prod1 +"   "+
			                  this.desc_prod2 +"   "+ this.desc_prod3);
			}
			public void tabla_productos3()
			{
			/*Aqui da la lista de los productos*/
			Console.WriteLine("Estos son los precios de los productos: " +"      $"+ this.Precio_prod1 +"      $"+
			                 this.Precio_prod2 +"      $"+ this.Precio_prod3);
			}
			public void tabla_operaciones()
			{
			/*Aqui nos da el subtotal*/
		   float subtotal = this.cantidad_prod1 * this.Precio_prod1 + this.cantidad_prod2 * this.Precio_prod2 
		    + this.cantidad_prod3 * this.Precio_prod3;
			Console.WriteLine("El subtotal es: "+subtotal);
			/*Aqui nos da el iva*/
		    double iva = subtotal * 0.16;
			Console.WriteLine("Este es el I.V.A: "+iva);
		    /*Aqui nos da el total de la operacion*/
			double total = subtotal + iva;
			Console.WriteLine("Este es el total: "+total);
			}	
		}
	}

