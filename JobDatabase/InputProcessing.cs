using JobDatabase.Advertisement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobDatabase {
    public class InputProcessing {

        JobDatabase jobDatabase = new JobDatabase(); // екземпляр JobDatabase для роботи з вакансіями
        Archive archive = new Archive();
        public void Start() {
            bool exit = false;

            while (!exit) {
                Console.WriteLine("\n** Меню: **");
                Console.WriteLine("1 - Допомога");
                Console.WriteLine("2 - Зареєструвати вакансію");
                Console.WriteLine("3 - Пошук вакансії");
                Console.WriteLine("0 - Завершии сесію");
                Console.Write("Виберіть опцію: ");
                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        // Допомога
                        Help();
                        break;
                    case "2":
                        // Зареєстрування вакансії
                        RegisterVacancy();
                        break;
                    case "3":
                        // Пошук вакансії
                        SearchVacancy();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        // Якщо неправильні дані
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
        void Help() {
            Console.WriteLine("Інструкція:");
            Console.WriteLine("Для вибору опції, введіть відповідний номер меню та натисніть Enter.");
            Console.WriteLine("1 - Допомога. Виводить інструкцію з використання програми.");
            Console.WriteLine("2 - Зареєструвати вакансію. Користувач-роботодавець має змогу зареєструвати вакансію.");
            Console.WriteLine("3 - Пошук вакансії. користувач-найманець шукає бажану вакансію.");
            Console.WriteLine("0 - Завершити сесію. Завершення програми");
            Console.WriteLine("У проміжних станах програми (не в головному меню), '0' означає перехід до попереднього кроку.");
            Console.WriteLine();
        }
        void RegisterVacancy() {
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
            Console.WriteLine("\n** Вакансію створено **\n");
        }
        Firm? TakeFirm() {
            Console.WriteLine("Чи існує фірма в базі?");
            while (true) {
                Console.WriteLine("1 - Так");
                Console.WriteLine("2 - Ні");
                Console.WriteLine("0 - Повернення до головного меню");
                Console.Write("Оберіть опцію: ");
                string input = Console.ReadLine();
                switch (input) {
                    case "1":
                        string name = "";
                        while (string.IsNullOrEmpty(name)) {
                            Console.Write("Введіть назву фірми: ");
                            name = Console.ReadLine();
                            if (string.IsNullOrEmpty(name)) {
                                Console.WriteLine("Немає назви. Спробуйте ввести назву ще раз.");
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
                        Console.WriteLine("Невідома операція.Використовуйте лише зазначені кнопки.");
                        break;
                }
            }
        }
        Firm FindFirm(string name) {
            bool status = jobDatabase.TryGetFirm(name, out var firm);
            if (!status) {
                throw new Exception("Такої фірми не існує.");
            } else
                return firm!;
        }
        Firm? CreateFirm() {
            Console.WriteLine("\nСтворення нової фірми ...");
            string name = "";
            string contactInfo = "";

            while (string.IsNullOrEmpty(name)) {
                Console.Write("Введіть назву фірми: ");
                name = Console.ReadLine();

                if (string.IsNullOrEmpty(name)) {
                    Console.WriteLine("Немає назви. Спробуйте ввести назву ще раз.");
                }
            }
            while (string.IsNullOrEmpty(contactInfo)) {
                Console.Write("Введіть контактну інформацію фірми: ");
                contactInfo = Console.ReadLine();

                if (string.IsNullOrEmpty(contactInfo)) {
                    Console.WriteLine("Немає інформації. Спробуйте додати інформацію фірми ще раз");
                }
            }
            Firm? firm = null;
            try {
                firm = FindFirm(name);
            }
            catch { }
            if (firm is Firm) {
                Console.WriteLine("Така фірма вже існує. Додати вакансію від цієї фірми?");
                bool exit = false;

                while (!exit) {
                    Console.WriteLine($"1.Додати вакансію {firm.Name}");
                    Console.WriteLine("2. Повернутися назад");
                    Console.WriteLine("Оберіть опцію: ");
                    string input = Console.ReadLine();
                    switch (input) {
                        case "1":
                            return firm;
                        case "2":
                            return null;
                        default:
                            Console.WriteLine("Некоректна операція. Спробуйте ще раз.");
                            break;
                    }
                }
            }
            Console.WriteLine("\n** Фірму створено **\n");
            return new Firm(name, contactInfo);
        }
        Position? TakePosition() {
            Console.WriteLine("\n** Створення нової вакансії **\n");
            Console.WriteLine("0 - Повернення до головного меню (вакансія не збережеться)");
            string title = "";
            string description = "";
            string salary = "";

            while (string.IsNullOrEmpty(title)) {
                Console.Write("Введіть назву вакансії: ");
                title = Console.ReadLine();
                if (title == "0")
                    return null;
                if (string.IsNullOrEmpty(title)) {
                    Console.WriteLine("Назва відсутня. Спробуйте ще раз.");
                }
            }
            while (string.IsNullOrEmpty(description)) {
                Console.Write("Введіть опис вакансії: ");
                description = Console.ReadLine();
                if (description == "0")
                    return null;
                if (string.IsNullOrEmpty(description)) {
                    Console.WriteLine("Відсутній опис. Спробуйте ще раз.");
                }
            }
            while (string.IsNullOrEmpty(salary)) {
                Console.Write("Введіть зарплату : ");
                salary = Console.ReadLine();
                if (string.IsNullOrEmpty(salary)) {
                    Console.WriteLine("Відсутні дані щодо зарплати. Спробуйте ще раз");
                }
            }
            bool isProvidesHousing = false;
            bool exit = false;
            while (!exit) {
                Console.WriteLine("Чи надається житло?");
                Console.WriteLine("1 - Taк");
                Console.WriteLine("2 - Ні");
                Console.Write("Оберіть опцію: ");
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
            exit = false;
            while (!exit) {
                Console.WriteLine("Бажаєте встановити вимоги до фахівця?");
                Console.WriteLine("1 - Taк");
                Console.WriteLine("2 - Ні");
                Console.Write("Оберіть опцію: ");
                string input = Console.ReadLine();
                switch (input) {
                    case "1":
                        newPosition.SetRequirements();
                        exit = true;
                        break;
                    case "2":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }

            Console.WriteLine("\n** Вакансію створено **\n");

            return newPosition;

        }
        void SearchVacancy() {
            int startIndex = 0;
            jobDatabase.PrintPosition(startIndex);
            startIndex += 5;
            while (true) {
                Console.WriteLine("\n** Оберіть дію **\n");
                Console.WriteLine("1 - Вивести ще 5 вакансій");
                Console.WriteLine("2 - Редагувати вакансію");
                Console.WriteLine("0 - Повернення назад");
                Console.Write("Оберіть опцію: ");
                string input = Console.ReadLine();
                switch (input) {
                    case "1":
                        jobDatabase.PrintPosition(startIndex);
                        startIndex += 5;
                        break;
                    case "2":
                        ActionsWithVacancy();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                        break;
                }
            }
        }
        void ActionsWithVacancy() {
            Console.OutputEncoding = Encoding.UTF8;
            string input = String.Empty;
            while (String.IsNullOrWhiteSpace(input)) {
                Console.Write("Ведіть номер вакансії: ");
                input = Console.ReadLine();
            }
            var position = jobDatabase.GetPosition(input);
            if (position == null) {
                Console.WriteLine("Вакансії з таким номером не існує.");
                return;
            } else {
                Console.WriteLine(position.GetDescription());
                while (true) {
                    Console.WriteLine("\n** Оберіть дію **\n");
                    Console.WriteLine("1 - Архівувати");
                    Console.WriteLine("2 - Видалити");
                    Console.WriteLine("3 - Змінити назву");
                    Console.WriteLine("4 - Змінити опис");
                    Console.WriteLine("5 - Змінити зарплату");
                    Console.WriteLine("6 - Створення файлу вакансії для друку");
                    Console.WriteLine("0 - Повернутися назад");
                    Console.Write("Ваш вибір: ");
                    input = Console.ReadLine();
                    switch (input) {
                        case "1":
                            archive.AddArchive(position);
                            position.Firm.Vacancies.Remove(position);
                            break;
                        case "2":
                            if (position.Firm.Vacancies.Remove(position)) {
                                Console.WriteLine("\n** Вакансію видалено **\n");
                            }
                            break;
                        case "3":
                            string title = "";
                            while (string.IsNullOrEmpty(title)) {
                                Console.Write("Введіть назву вакансії: ");
                                title = Console.ReadLine();
                                if (string.IsNullOrEmpty(title)) {
                                    Console.WriteLine("Назва відсутня. Спробуйте ще раз");
                                }
                            }
                            position.Title = title;
                            break;
                        case "4":
                            string description = "";
                            while (string.IsNullOrEmpty(description)) {
                                Console.Write("Введіть опис вакансії: ");
                                description = Console.ReadLine();
                                if (string.IsNullOrEmpty(description)) {
                                    Console.WriteLine("Опис відсутній. Спробуйте ще раз.");
                                }
                            }
                            position.Description = description;
                            break;
                        case "5":
                            string salary = "";
                            while (string.IsNullOrEmpty(salary)) {
                                Console.Write("Введіть зарплату для вакансії: ");
                                salary = Console.ReadLine();
                                if (string.IsNullOrEmpty(salary)) {
                                    Console.WriteLine("Відсутні дані щодо зарплати. Спробуйте ще раз.");
                                }
                            }
                            position.Salary = salary;
                            break;
                        case "6":
                            Advertisement(position);
                            break;
                        case "0":
                            // Вийти
                            return;
                        default:
                            Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                            break;
                    }
                }
            }
        }
        void Advertisement(Position position) {
            IAdvertisement advertisement = null!;
            bool exit = false;
            while (!exit) {
                Console.WriteLine("\n** оберіть формат текстового документа **\n");
                Console.WriteLine("1 - .docx документ");
                Console.WriteLine("2 - .txt документ");
                Console.WriteLine("0 - Повернутися назад");
                Console.Write("Ваш вибір: ");
                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        advertisement = new WordAdvertisement();
                        exit = true;
                        break;
                    case "2":
                        advertisement = new TxtAdvertisement();
                        exit = true;
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Невірна операція. Спробуйте ще раз.");
                        break;
                }
            }
            advertisement.GenerateAdvertisement(position);
        }
    }
}
