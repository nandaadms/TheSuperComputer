using System;

namespace TheSuperComputer
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor SamsungMonitor = new Monitor("1200x600", true, 32);
            Printer SonyPrinter = new Printer("SONY", "MP102", 50);
            Vga nvdiaVga = new Vga("Nvidia RTX", 2070, 2080);
            Ram AMD = new Ram("DDR4", 2666, 4000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(2000);
            intelProcessor.setCore(12);
            intelProcessor.setSeries("AMD RYZEN 7");

            Computer computer = new Computer.Builder(AMD, nvdiaVga, intelProcessor)
                .withMonitor(SamsungMonitor).withPrinter(SonyPrinter).build();

            Console.WriteLine(computer.ToString());
        }
    }
}
