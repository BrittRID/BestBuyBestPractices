using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyBestPractices
{
   public  interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts(); 
        //void CreateProduct(int ProductID, string name, double price, int categoryID, int OnSale, string StockLevel);
        void CreateProduct(string name, double price, int categoryID);



    }
}
