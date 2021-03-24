using System;

namespace ClassMetodsRepo
{
    class Program
    {
        static void Main(string[] args)
        {

            CategoriesPanel();

        }

        static void CategoriesPanel()
        {

            FurnitureManager furnitureManager = new FurnitureManager();

            string[] Categories = { "Mobilya Ekle", "Mobilya Sil", "Mobilya Güncelle" };
            int i = 1;

            
            Console.WriteLine("----------------------");
            foreach (var category in Categories)
            {
                Console.WriteLine("[" + i + "]" + category);
                i++;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine("Seçim: ");
            i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    furnitureManager.FurnitureAddPanel();
                    break;
                case 2:furnitureManager.FurnitureDeletePanel();
                    break;
                case 3:furnitureManager.FurnitureUpdatePanel();
                    break;
            }

            
        }

        


    }
}
