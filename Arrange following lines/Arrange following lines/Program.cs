﻿using System;

class Program

{

    public static void Main(string[] args)

    {

        Product p = new Product();



        Console.WriteLine("Enter the product name");

        p._productName = Console.ReadLine();



        Console.WriteLine("Enter the product id");

        p._id = Convert.ToInt64(Console.ReadLine());



        Console.WriteLine("Enter the supplier name");

        p._supplierName = Console.ReadLine();



        Console.WriteLine("Product Name is " + p._productName);

        Console.WriteLine("Product Id is " + p._id);

        Console.WriteLine("Supplier Name is " + p._supplierName);

    }

}

public class Product



{

    public string _productName;

    public string _supplierName;

    public long _id;

}