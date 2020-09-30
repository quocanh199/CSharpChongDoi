using System;

namespace Chapter3
{
    class Medicine
    {
        private string medicineCode, medicineName, manufacturerName;
        private int quantityOnHand, batchNumber, unitPrice;
        private DateTime manufacturerDate, expiryDate;

        public Medicine()
        {
            medicineCode = medicineName = manufacturerName =  "";
            quantityOnHand = batchNumber = unitPrice = 0;
            manufacturerDate = expiryDate = new DateTime(0, 0, 0);
        }
        public Medicine(string medicineCode, string medicineName, string manufacturerName, int unitPrice,
                        int quantityOnHand, int batchNumber, DateTime manufacturerDate, DateTime expiryDate){
            this.medicineCode = medicineCode;
            this.medicineName = medicineName;
            this.manufacturerDate = manufacturerDate;
            this.unitPrice = unitPrice;
            this.quantityOnHand = quantityOnHand;
            this.batchNumber = batchNumber;
            this.manufacturerName = manufacturerName;
            this.expiryDate = expiryDate;
        }
        public void Accept(){
            Console.Write("Medicine Code: ");
            medicineCode = Console.ReadLine();
            Console.Write("Medicine Name: ");
            medicineName = Console.ReadLine();

            Console.Write("Manufacturer Date (day/month/year): ");
            string[] date = Console.ReadLine().Split('/');
            manufacturerDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
            Console.Write("Expiry Date (day/month/year): ");
            date = Console.ReadLine().Split('/');
            expiryDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

            Console.Write("Unit Price:");
            unitPrice = int.Parse(Console.ReadLine());
            Console.Write("Quantity On Hand: ");
            quantityOnHand = int.Parse(Console.ReadLine());
            Console.Write("Batch Number: ");
            batchNumber = int.Parse(Console.ReadLine());
        }
        public void Print(int id){
            Console.WriteLine("Medicine Code: " + medicineCode);
            Console.WriteLine("Medicine Name: " + medicineName);
            Console.WriteLine("Batch Number: " + batchNumber);
            Console.WriteLine("Unit Price: " + unitPrice);
            Console.WriteLine("Manufacturer Name: " + manufacturerName);
        }
        public void Print(string id){
            Console.WriteLine("Quantity On Hand: " + quantityOnHand);
        }
        public void Print(float id){
            Console.WriteLine("Manufacturer Date: " + manufacturerDate);
            Console.WriteLine("Expiry Date: " + expiryDate);
        }
        
    }
}
