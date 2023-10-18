using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer  customer)
        {
            Console.WriteLine("Müşteri Girişi Sağlandı");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri Güncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Başarıyla Silindi");
        }
        public void GetAll()
        {
            Console.WriteLine("Müşteriler Listelendi");
        }
    }
}
