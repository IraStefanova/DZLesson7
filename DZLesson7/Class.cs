
namespace DZLesson7
{
    class Product
    {
        public int id, count, price;
        public Product(int id, int count, int price)
        {
            this.id = id;
            this.count = count;
            this.price = price;
        }
        public class Food : Product
        {
            public string name;
            public Food(int id, int count, int price, string name) : base(id, count, price)
            {
                this.name = name;
            }
        }
        public class Pharmacy : Product
        {
            public string name;
            public Pharmacy(int id, int count, int price, string name) : base(id, count, price)
            {
                this.name = name;
            }
        }
        public class Technology : Product
        {
            public string name;
            public Technology(int id, int count, int price, string name) : base(id, count, price)
            {
                this.name = name;
            }
        }
    }

    class Inventory
    {
        List<Product.Food> listFood;
        List<Product.Pharmacy> listPharmacy;
        List<Product.Technology> listTechnology;
        public Inventory()
        {
            listFood = new List<Product.Food>();
            listPharmacy = new List<Product.Pharmacy>();
            listTechnology = new List<Product.Technology>();
        }
        public void Add(Product.Food obj)
        {
            listFood.Add(obj);
        }
        public void Add(Product.Pharmacy obj)
        {
            listPharmacy.Add(obj);
        }
        public void Add(Product.Technology obj)
        {
            listTechnology.Add(obj);
        }
        public void SumFood()
        {
            int sumPrice = listFood.Sum(i => i.price * i.count);
            Console.WriteLine($"Стоимость всех продуктов в категории 'еда': {sumPrice} р. \n");
        }
        public void SumPharmacy()
        {
            int sumPrice = listPharmacy.Sum(i => i.price * i.count);
            Console.WriteLine($"Стоимость всех продуктов в категории 'аптека': {sumPrice} р.\n");
        }
        public void SumTechnology()
        {
            int sumPrice = listTechnology.Sum(i => i.price * i.count);
            Console.WriteLine($"Стоимость всех продуктов в категории 'техника': {sumPrice} р.\n");
        }
        public void SumALL()
        {
            int sumPrice = listFood.Sum(i => i.price * i.count) + listPharmacy.Sum(i => i.price * i.count) + listTechnology.Sum(i => i.price * i.count);
            Console.WriteLine($"Стоимость всех продуктов: {sumPrice} р.\n");
        }
        public void PrintFood()
        {
            Console.WriteLine("Список продуктов в категории 'еда':\n");
            listFood.ForEach(i => Console.WriteLine($"{i.id} - {i.name}, кол-во: {i.count}, цена: {i.price} р."));
        }
        public void PrintPharmacy()
        {
            Console.WriteLine("\nСписок продуктов в категории 'аптека'\n");
            listPharmacy.ForEach(i => Console.WriteLine($"{i.id} - {i.name}, кол-во: {i.count}, цена: {i.price} р."));
        }
        public void PrintTechnology()
        {
            Console.WriteLine("\nСписок продуктов в категории 'техника'\n");
            listTechnology.ForEach(i => Console.WriteLine($"{i.id} - {i.name}, кол-во: {i.count}, цена: {i.price} р."));
        }



        public void AddProduct()
        {
            int kind;
            while (true)
            {
                Console.WriteLine("Выберите тип продукта: 1 - еда, 2 - аптека, 3 - техника");
                if (int.TryParse(Console.ReadLine(), out kind))
                {
                    if (kind != 1 & kind != 2 & kind != 3)
                    {
                        Console.WriteLine("Выберите категорию продукта!");
                        continue;
                    }
                    break;
                }
                continue;
            }

            if (kind == 1)
            {

                Console.WriteLine("Введите id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите кол-во:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int price = int.Parse(Console.ReadLine());
                listFood.Add(new Product.Food(id, count, price, name));
            }
            if (kind == 2)
            {

                Console.WriteLine("Введите id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите кол-во:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int price = int.Parse(Console.ReadLine());
                listPharmacy.Add(new Product.Pharmacy(id, count, price, name));
            }
            if (kind == 3)
            {

                Console.WriteLine("Введите id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите название:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите кол-во:");
                int count = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите стоимость:");
                int price = int.Parse(Console.ReadLine());
                listTechnology.Add(new Product.Technology(id, count, price, name)) ;
            }

        }
        public void RemoveProduct()
        {
            Console.WriteLine("Введите id продукта:");
            int id = int.Parse(Console.ReadLine());

            if ((listFood.RemoveAll(p => p.id == id) > 0) & (listPharmacy.RemoveAll(p => p.id == id) > 0) & (listTechnology.RemoveAll(p => p.id == id) > 0))
            {
                Console.WriteLine("Указанный продукт удален");
            }

            else
            {
                Console.WriteLine("Продукта с таким id не существует");
            }
        }
    }
}