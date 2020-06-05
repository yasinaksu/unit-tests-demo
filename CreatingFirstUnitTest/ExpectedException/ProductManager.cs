using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpectedException
{
    //gereksinimler
    //bir ürün yalnızca bir kere eklenebilmeli aynı ürün tekrar eklendiğinde ArgumentException fırlatılmalı
    public class ProductManager
    {
        private List<string> _products = new List<string>();
        
        public void Add(string product)
        {
            if (_products.Contains(product))
            {
                throw new ArgumentException(string.Format("{0} have already added.",product));
            }
            else
            {
                _products.Add(product);
            }
        }
    }
}
