using System;

namespace VgaLibrary
{
    public class Vga
    {
        public string merk;
    }
    public class Nvidia : Vga
    {
        public Nvidia()
        {
            merk = "Nvidia";
        }
    }
    public class AMDVga : Vga
    {
        public AMDVga()
        {
            merk = "AMD";
        }
    }
}

namespace ProcessorLibrary
{
    public class Processor
    {
        public string merk, tipe;
    }
    public class Intel : Processor
    {
        public Intel()
        {
            merk = "Intel";
        }
    }
    public class CoreI3 : Intel
    {
        public CoreI3()
        {
            tipe = "Core i3";
        }
    }
    public class CoreI5 : Intel
    {
        public CoreI5()
        {
            tipe = "Core i5";
        }
    }
    public class CoreI7 : Intel
    {
        public CoreI7()
        {
            tipe = "Core i7";
        }
    }
    public class AMDProcessor : Processor
    {
        public AMDProcessor()
        {
            merk = "AMD";
        }
    }
    public class Ryzen : AMDProcessor
    {
        public Ryzen()
        {
            tipe = "Ryzen";
        }
    }
    public class Athlon : AMDProcessor
    {
        public Athlon()
        {
            tipe = "ATHLON";
        }
    }
}

namespace LaptopLibrary
{
    public class Laptop
    {
        public string merk, tipe;
        public VgaLibrary.Vga vga;
        public ProcessorLibrary.Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine("Laptop {0} {1} menyala", this.merk, this.tipe);
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine("Laptop {0} {1} mati", this.merk, this.tipe);
        }
    }

    public class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "Asus";
        }
    }
    public class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }
    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            merk = "Acer";
        }
    }
    public class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }
    public class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine("Laptop {0} {1} sedang memainkan game", this.merk, this.tipe);
        }
    }

    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }
    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }
    public class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}

public class Eksekusi
{
    static void Main(string[] args)
    {
        LaptopLibrary.Laptop laptop1 = new LaptopLibrary.Laptop();
        laptop1 = new LaptopLibrary.Vivobook();
        laptop1.vga = new VgaLibrary.Nvidia();
        laptop1.processor = new ProcessorLibrary.CoreI5();

        LaptopLibrary.Laptop laptop2 = new LaptopLibrary.Laptop();
        laptop2 = new LaptopLibrary.IdeaPad();
        laptop2.vga = new VgaLibrary.AMDVga();
        laptop2.processor = new ProcessorLibrary.Ryzen();

        LaptopLibrary.Predator predator = new LaptopLibrary.Predator();
        predator = new LaptopLibrary.Predator();
        predator.vga = new VgaLibrary.AMDVga();
        predator.processor = new ProcessorLibrary.CoreI7();

        Console.WriteLine("Soal 1");
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Console.WriteLine("Soal 2");
        laptop1.Ngoding();

        Console.WriteLine("Soal 3");
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe);

        Console.WriteLine("Soal 4");
        predator.BermainGame();

        Console.WriteLine("Soal 5");
        LaptopLibrary.ACER acer = new LaptopLibrary.ACER();
        acer = new LaptopLibrary.Predator();
        acer.BermainGame();
    }
}
