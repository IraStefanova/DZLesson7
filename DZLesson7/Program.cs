namespace DZLesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.Add(new Product.Food(1, 10, 50, "Ананас"));
            inventory.Add(new Product.Food(2, 35, 15, "Профитроли"));
            inventory.Add(new Product.Food(3, 50, 7, "Сельдерей"));
            inventory.Add(new Product.Pharmacy(4, 13, 6, "Терафлю"));
            inventory.Add(new Product.Pharmacy(5, 22, 3, "Пластырь"));
            inventory.Add(new Product.Pharmacy(6, 10, 2, "Градусник"));
            inventory.Add(new Product.Technology(7, 2, 1500, "Пылесос"));
            inventory.Add(new Product.Technology(8, 5, 1000, "Блендер"));
            inventory.Add(new Product.Technology(9, 4, 500, "Наушники"));
            while (true)
            {

                while (true)
                {
                    Console.WriteLine("Выберите действие, нажав цифру от 1 до 4: \n" +
                        "1 - Вывести список всех продуктов \n" +
                        "2 - Вывести стоимость всех продуктов \n" +
                        "3 - Добавить продукт \n" +
                        "4 - Удалить продукт \n");
                    string action = Console.ReadLine();
                    switch (action)
                    {
                        case "1":
                            inventory.PrintFood();
                            inventory.PrintPharmacy();
                            inventory.PrintTechnology();
                            break;

                        case "2":
                            inventory.SumFood();
                            inventory.SumPharmacy();
                            inventory.SumTechnology();
                            inventory.SumALL();
                            break;

                        case "3":
                            inventory.AddProduct();
                            break;

                        case "4":
                            inventory.RemoveProduct();
                            break;

                        default:
                            Console.WriteLine("Вы выбрали неизвестное действие");
                            break;
                    }


                    Console.WriteLine("Введите e, чтобы покинуть программу");
                    string enteredText = Console.ReadLine();
                    switch (enteredText)
                    {
                        case "e":
                            Console.WriteLine("Выход");
                            return;

                        default:
                            Console.WriteLine("Продолжаем");
                            break;
                    }
                }
            }

        }
    }
}