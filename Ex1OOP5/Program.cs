using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1OOP5
{
    class Medicine
    {
        private string mecCode;//mã thuốc
        private string mecName;//tên thuốc
        private string manuName;//tên nhà sx
        private string unitPrice;//giá 
        private string quantityOnHand;//số lượng hiện có
        private string manuDate;//ngày sản xuất
        private string expDate;//ngày hết hạn
        private string batchNumber;//số lô

        public Medicine(string mecCod="",string mecNam="",string manuNam="",string unitPric="",
                        string quantityOnHan="",string manuDat="",string expDat="",string batchNum="")
        {
            mecCode = mecCod;
            mecName = mecNam;
            manuName = manuNam;
            unitPrice = unitPric;
            quantityOnHand = quantityOnHan;
            manuDate = manuDat;
            expDate = expDat;
            batchNumber = batchNum;
        }

        public void Accept()//nhập dữ liệu
        {
            Console.WriteLine("Medicine Code:");
            mecCode = Console.ReadLine();
            Console.WriteLine("Medicine Name:");
            mecName = Console.ReadLine();
            Console.WriteLine("Manufacturer Name:");
            manuName = Console.ReadLine();
            Console.WriteLine("Unit Price:");
            unitPrice = Console.ReadLine();
            Console.WriteLine("Quantity On Hand:");
            quantityOnHand = Console.ReadLine();
            Console.WriteLine("Manufactored Date:");
            manuDate = Console.ReadLine();
            Console.WriteLine("Expiry Date:");
            expDate = Console.ReadLine();
            Console.WriteLine("Batch Number:");
            batchNumber = Console.ReadLine();
        }
        public void Print()//in
        {
            Console.WriteLine("Medicine Code:{0}\nManufacturer Name:{1}\nUnit Price:{2}\nQuantity On Hand:{3}" +
                "\nManufactored Date:{4}\nExpiry Date:{5}\nBatch Number:{6}",MecCode,manuName,unitPrice,quantityOnHand,manuDate,expDate,batchNumber);
        }
        public void Print(int s)
        {
            Console.WriteLine("Quantity On Hand:"+quantityOnHand);
        }
        public void Print(int s,int s1)
        {
            Console.WriteLine("Expiry Date:{0}\nManufactored Date:{1}", expDate,manuDate);
        }
        public string MecCode { get => mecCode; set => mecCode = value; }
        public string QuantityOnHand { get => quantityOnHand; set => quantityOnHand = value; }
    }
    class Sale
    {
        Medicine mec=new Medicine();       
        private string quantitySold;
        private string PlannedSales;
        private string actualSales;
        private string Region;

        public string QuantitySold { get => quantitySold; set => quantitySold = value; }

        public Sale(string mecCode="",string quantity="",string planned="",string actual="",string reg="")        
        {
            mec.MecCode = mecCode;            
            quantitySold = quantity;
            PlannedSales = planned;
            actualSales = actual;
            Region = reg;
        }
        public void Accept()
        {
            Console.WriteLine("Medicine Code:");
            mec.MecCode = Console.ReadLine();
            Console.WriteLine("Quantity Sold:");
            quantitySold = Console.ReadLine();
            Console.WriteLine("Planned Sales:");
            PlannedSales = Console.ReadLine();
            Console.WriteLine("Actual Sales:");
            actualSales = Console.ReadLine();
            Console.WriteLine("Region:");
            Region = Console.ReadLine();           
        }
        public string getMecCode()
        {
            return mec.MecCode;
        }
        public void Display()
        {
            Console.WriteLine("Medicine Code:{0}\nQuantity Sold:{1}\nPlanned Sales:{2}\nActual Sales:{3}" +
               "\nRegion:{4}", mec.MecCode, quantitySold, PlannedSales, actualSales, Region);
        }
        public void Display(int s)
        {
            Console.WriteLine("Actual Sales: " + actualSales + "><Planned Sales: " + PlannedSales);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Medicine> list = new List<Medicine>();
            for(int i=1;i<=3;i++)
            {
                Medicine mec = new Medicine();
                mec.Accept();
                list.Add(mec);
            }
            string[] mecString = new string[3];
            string[] quantity = new string[3];
            int j = 0;
            foreach(Medicine mec in list)
            {
                mecString[j] = mec.MecCode;
                quantity[j] = mec.QuantityOnHand;
                j++;
            }            
            //List<Sale> list1 = new List<Sale>();
            for (int i = 1; i <= 3; i++)
            {
                Sale sl = new Sale();
                sl.Accept();
                string s = sl.getMecCode();
                for(int k=0;k<3;k++)
                {
                    if(s==mecString[k])
                    {
                        if(Convert.ToInt32(quantity[k])>=Convert.ToInt32(sl.QuantitySold))
                        {
                            Console.WriteLine("Ban duoc thuoc");
                        }
                        else
                        {
                            Console.WriteLine("Het hang");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Don thuoc khong phu hop");
                    }
                }
       
            }
        }
    }
}
