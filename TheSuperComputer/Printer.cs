using System;
using System.Collections.Generic;
using System.Text;

namespace TheSuperComputer
{
    class Printer
    {
        private String brand;
        private String series;
        private int ppm;

        public Printer(String brand, String series, int ppm)
        {
            this.brand = brand;
            this.series = series;
            this.ppm = ppm;

        }
        public String getBrand()
        {
            return this.brand;
        }
        public String getSeries()
        {
            return this.series;
        }
        public int getPpm()
        {
            return this.ppm;
        }
        public override string ToString()
        {
            return $"Printer Brand : {this.brand} ; Printer Series : {this.series} ; Printer Paper Per Minutes : {this.ppm}";
        }
    }
}
