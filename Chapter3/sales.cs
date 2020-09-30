using System;

namespace Chapter3{
    class Sales{
        private string medicineCode,region;
        private int quantitySold, plannedSales, actualSales;
        public Sales(){
            medicineCode = region = "";
            quantitySold = plannedSales = actualSales = 0;
        }
        public Sales(string medicineCode, string region, int quantitySold, int plannedSales, int actualSales){
            this.medicineCode = medicineCode;
            this.region = region;
            this.quantitySold = quantitySold;
            this.plannedSales = plannedSales;
            this.actualSales = actualSales;
        }
        public void Accept(){
            Console.Write("Medicine Code: ");
            medicineCode = Console.ReadLine();
            Console.Write("Region: ");
            region = Console.ReadLine();
            Console.Write("Quantity Sold: ");
            quantitySold = int.Parse(Console.ReadLine());
            Console.Write("Planned Sales: ");
            plannedSales = int.Parse(Console.ReadLine());
            Console.Write("Actual Sales: ");
            actualSales = int.Parse(Console.ReadLine());
        }
        public void Display(int id){
            Console.WriteLine("Medicine Code: " + medicineCode);
            Console.WriteLine("Region: " + region);
        }
        public void Display(string id){
            Console.WriteLine("Actual Sales / Planned Sales: {0} / {1}", actualSales, plannedSales);
        }
    }
}