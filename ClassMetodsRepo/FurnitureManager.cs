using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetodsRepo
{
    class FurnitureManager
    {

        public void Add()
        {

        }

        public void Delete()
        {
            Console.WriteLine("Ürün Silindi.");
        }

        public void Update()
        {
            Console.WriteLine("Ürün Güncellendi.");
        }

        public void FurnitureList(Furniture[] furnitures)
        {
            Console.WriteLine("\n\nListe Ekranı");
            foreach (var furniture in furnitures)
            {
                
                Console.WriteLine("Ürün Çeşit: " + furniture.FurnitureType);
                Console.WriteLine("Ürün Malzemesi: " + furniture.FurnitureMaterial);
                Console.WriteLine("Ürün Renk: " + furniture.Color);
                Console.WriteLine("Ürün Fiyat: " + furniture.Price);
                Console.WriteLine("Ürün Stok: " + furniture.FurnitureStock);

                Console.WriteLine("--------------------------\n");
            }

        }
        

        public void FurnitureAddPanel()
        {
            string[] AddPanel = { "Ürün Çeşit: ", "Ürün Malzemesi: ", "Ürün Renk: ", "Ürün Fiyat: ", "Ürün Stok: " };

            Furniture furniture1 = new Furniture();
            Furniture furniture2 = new Furniture();
            Furniture furniture3 = new Furniture();
            Furniture furniture4 = new Furniture();

            Console.WriteLine("------------------");
            Furniture[] furnitures= {furniture1, furniture2};
            foreach (var item in furnitures)
            {
                Console.Write(AddPanel[0]);
                item.FurnitureType = Console.ReadLine();
                Console.Write(AddPanel[1]);
                item.FurnitureMaterial = Console.ReadLine();
                Console.Write(AddPanel[2]);
                item.Color = Console.ReadLine();
                Console.Write(AddPanel[3]);
                item.Price = int.Parse(Console.ReadLine());
                Console.Write(AddPanel[4]);
                item.FurnitureStock = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------");

            }
            FurnitureList(furnitures);
        }

        public void FurnitureDeletePanel()
        {
            
        }

        public void FurnitureUpdatePanel()
        {
            
        }

    }
}
