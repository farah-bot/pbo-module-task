﻿using System;
using System.Runtime;
using System.Runtime.CompilerServices;


class Program
{
    static void Main(string[] args)
    { 
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new corei5();

        Laptop laptop2 = new Ideapad();
        laptop2.vga = new amd();
        laptop2.processor = new ryzen();

        Predator predator = new Predator();

        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();
        predator.BermainGame();

        laptop1.Ngoding();

        ACER acer = new Predator();
        acer.BermainGame(); 


        Console.WriteLine("\n\nSpesifikasi laptop1 : ");
        Console.WriteLine("Merk vga : " + laptop1.vga + "\nMerk processor : " + laptop1.processor + "\nTipe processor : " + laptop1.tipe);

    }
}

class Processor
{
    public string merk;
    public string tipe;

}

class Intel : Processor
{
    public Intel()
    {
        base.merk = "Intel";
    }
}

class AMD : Processor
{
    public AMD()
    {
        base.merk = "AMD";
    }
}

class corei3 : Intel
{
    public corei3()
    {
        base.tipe = "Corei3";
    }
}

class corei5 : Intel
{
    public corei5()
    {
        base.tipe = "Corei5";
    }
}

class corei7 : Intel
{
    public corei7()
    {
        base.tipe = "Corei7";
    }
}

class ryzen : AMD
{
    public ryzen()
    {
        base.tipe = "Ryzen";
    }
}

class athlon : AMD
{
    public athlon()
    {
        base.tipe = "Athlon";
    }
}

class VGA
{
    public string merk;
}

class Nvidia : VGA
{
    public Nvidia()
    {
        base.merk = "Nvidia";
    }
}

class amd : VGA
{
    public amd()
    {
        base.merk = "AMD";
    }
}

class Laptop
{
    public string merk;
    public string tipe;
    public VGA vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    

    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        base.merk = "ASUS";
    }
}

class ACER : Laptop
{
    public ACER()
    {
        base.merk = "ACER";
    }
}

class lenovo : Laptop
{
    public lenovo()
    {
        base.merk = "Lenovo";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        base.tipe = "ROG";
    }
}

class Vivobook : ASUS
{
    public Vivobook()
    {
        base.tipe = "Vivobook";
    }

    public void Ngoding()
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}

class Swift : ACER
{
    public Swift()
    {
        base.tipe = "Swift";
    }
}

class Predator : ACER
{
    public Predator()
    {
        base.tipe = "Predator";
    }

    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Ideapad : lenovo
{
    public Ideapad()
    {
        base.tipe = "Ideapad";
    }
}

class Legion : lenovo
{
    public Legion()
    {
        base.tipe = "Legion";
    }
}