using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class InputProcessing {

        JobDatabase jobDatabase = new JobDatabase(); // екземпляр JobDatabase для роботи з вакансіями
        public void Start() {
            bool exit = false;

            while (!exit) {
                Console.WriteLine("--- Меню: ---");
                Console.WriteLine("1. Допомога");
                Console.WriteLine("2. Зареєструвати вакансію");
                Console.WriteLine("3. Пошук вакансії");
                Console.WriteLine("0. Вихід");
                Console.WriteLine("Виберіть опцію: ");
                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        // Дії для опції "Допомога"
                        Help();
                        break;
                    case "2":
                        // Дії для опції "Зареєструвати вакансію"
                        RegisterVacancy(jobDatabase);
                        break;
                    case "3":
                        // Дії для опції "Пошук вакансії"
                        SearchVacancy(jobDatabase);
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
        void Help() {
            Console.WriteLine("Інструкція:");
            Console.WriteLine("Для вибору опції, введіть відповідний номер меню і натисніть Enter.");
            Console.WriteLine("1. Допомога - виводить інструкцію щодо використання програми.");
            Console.WriteLine("2. Зареєструвати вакансію - дозволяє користувачеві зареєструвати нову вакансію.");
            Console.WriteLine("3. Пошук вакансії - дозволяє користувачеві шукати вакансії за певними критеріями.");
            Console.WriteLine("0. Вихід - виходить з програми.");
            Console.WriteLine();
        }
        void RegisterVacancy(JobDatabase jobDatabase) {
            var firm = TakeFirm();
            if (firm != null)
                jobDatabase.AddFirm(firm);
            else
                return;
            var position = TakePosition();
            if (position != null)
                firm.AddVacancy(position);
            else
                return;
            Console.WriteLine("\n--- Вакансія успішно зареєстрована ---\n");
        }
        Firm? TakeFirm() {
            Console.WriteLine("Фірма вже існує?");
            while (true) {
                Console.WriteLine("1. Так");
                Console.WriteLine("2. Ні");
                Console.WriteLine("0. Вихід");
                Console.Write("Виберіть опцію: ");
                string input = Console.ReadLine();
                switch (input) {
                    case "1":
                        string name = "";
                        while (string.IsNullOrEmpty(name)) {
                            Console.Write("Введіть назву фірми: ");
                            name = Console.ReadLine();

                            if (string.IsNullOrEmpty(name)) {
                                Console.WriteLine("Назва фірми не може бути порожньою. Будь ласка, спробуйте ще раз.");
                            }
                        }
                        try {
                            return FindFirm(name);
                        }
                        catch (Exception e) { Console.WriteLine(e.Message); }
                        return null;
                    case "2":
                        return CreateFirm();
                    case "0":
                        return null;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
        Firm FindFirm(string name) {
            bool status = jobDatabase.TryGetFirm(name, out var firm);
            if (!status) {
                throw new Exception("Такої фірми не існує");
            } else
                return firm!;
        }
        Firm? CreateFirm() {
            Console.WriteLine("\n--- Створення нової фірми ---");
            string name = "";
            string contactInfo = "";

            while (string.IsNullOrEmpty(name)) {
                Console.Write("Введіть назву фірми: ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) {
                    Console.WriteLine("Назва фірми не може бути порожньою. Будь ласка, спробуйте ще раз.");
                }
            }
            while (string.IsNullOrEmpty(contactInfo)) {
                Console.Write("Введіть контактну інформацію фірми: ");
                contactInfo = Console.ReadLine();

                if (string.IsNullOrEmpty(contactInfo)) {
                    Console.WriteLine("Контактна інформація фірми не може бути порожньою. Будь ласка, спробуйте ще раз.");
                }
            }
            if (FindFirm(name) is Firm firm) {
                Console.WriteLine("Така фірма вже існує. Бажаєте використовувати її чи повернутися до головного меню?");
                bool exit = false;

                while (!exit) {
                    Console.WriteLine($"1. Використовувати фірму {firm.Name}");
                    Console.WriteLine("2. Повернутися до головного меню");
                    Console.WriteLine("Виберіть опцію: ");
                    string input = Console.ReadLine();
                    switch (input) {
                        case "1":
                            return firm;
                        case "2":
                            return null;
                        default:
                            Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                            break;
                    }
                }
            }
            Console.WriteLine("\n--- Фірма успішно створена ---\n");
            return new Firm(name, contactInfo);
        }
        Position? TakePosition() {
            Console.WriteLine("\n--- Створення нової вакансії ---\n");
            Console.WriteLine("0 - Повернутися у головне меню (вакансія не створиться)");
            string title = "";
            string description = "";
            string salary = "";

            while (string.IsNullOrEmpty(title)) {
                Console.Write("Введіть назву вакансії: ");
                title = Console.ReadLine();
                if (title == "0")
                    return null;
                if (string.IsNullOrEmpty(title)) {
                    Console.WriteLine("Назва вакансії не може бути порожньою. Будь ласка, спробуйте ще раз.");
                }
            }
            while (string.IsNullOrEmpty(description)) {
                Console.Write("Введіть опис вакансії: ");
                description = Console.ReadLine();
                if (title == "0")
                    return null;
                if (string.IsNullOrEmpty(description)) {
                    Console.WriteLine("Опис вакансії не може бути порожнім. Будь ласка, спробуйте ще раз.");
                }
            }
            while (string.IsNullOrEmpty(salary)) {
                Console.Write("Введіть зарплату для вакансії: ");
                salary = Console.ReadLine();
                if (title == "0")
                    return null;
                if (string.IsNullOrEmpty(salary)) {
                    Console.WriteLine("Зарплата для вакансії не може бути порожньою. Будь ласка, спробуйте ще раз.");
                }
            }
            bool isProvidesHousing = false;
            bool exit = false;
            while (!exit) {
                Console.WriteLine("Чи надається житло для цієї вакансії?");
                Console.WriteLine("1. Tak");
                Console.WriteLine("2. Ні");
                Console.Write("Виберіть опцію: ");
                string input = Console.ReadLine();
                switch (input) {
                    case "1":
                        isProvidesHousing = true;
                        exit = true;
                        break;
                    case "2":
                        isProvidesHousing = false;
                        exit = true;
                        break;
                    case "0":
                        return null;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
            Position newPosition = new Position(title, description, salary, isProvidesHousing);

            Console.WriteLine("\n--- Вакансія успішно створена ---\n");

            return newPosition;

        }


        void SearchVacancy(JobDatabase jobDatabase) {
        }
    }
}
