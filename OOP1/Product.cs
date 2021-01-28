using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }//ürün ıd numarası
        public int CategoryId { get; set; }//hangi kategoride olduğunu bildiren id 
        public string ProductName { get; set; }//ürün ismi
        public double UnitPrice { get; set; }//fiyatı
        public int UnitInStock { get; set; }//stok bilgisi


    }
}
