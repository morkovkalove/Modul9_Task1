namespace Delegates;
/*
 * Создайте свой тип исключения.
 * Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
 * Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
 * В блоке catch выведите в консольном сообщении текст исключения.
 */


class Program
{
   
    
    public static void Main(string[] args)
    {
        
    }

    static void Exeptions()
    {
        var error = new Exception[] { new ArgumentException(), new IndexOutOfRangeException(), new MyException(), new ArrayTypeMismatchException(), new DivideByZeroException()};
        foreach (var el in error)
        {
            try
            {
                Attempts();
            }
            catch (ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
                Exeptions();
            }
            
            catch (FormatException)
            {
                Console.WriteLine("Введено значение неверного формата");
                Exeptions();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Запрашиваемый номер выходит за границы допустимых номеров");
                Exeptions();
            }
            
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                Exeptions();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Exeptions();
            }
            
        }
    }

    static void Attempts()
    {
        (string name, string surname, int age, int zero, string item) blank;
        Console.WriteLine("Укажите ваше имя:");
        blank.name = Console.ReadLine();

        if (blank.name.Length < 3)
            throw new Exception("It's so short name");

        foreach (var el in blank.name)
        {
            if(!Char.IsLetter(el))
                throw new ArrayTypeMismatchException("Имя не должно иметь спец-символы или цифры.");
        }

        Console.WriteLine("Укажите вашу фамилию: ");
        blank.surname = Console.ReadLine();

        if (blank.surname.Length < 2)
            throw new Exception("It's so short surname");
        foreach (var i in blank.surname)
        {
            if(!Char.IsLetter(i))
                throw new ArrayTypeMismatchException("Фамилия не должна иметь спец-символы или цифры.");
        }

        Console.WriteLine("Укажите ваш возраст: ");
        blank.age = Convert.ToInt32(Console.ReadLine());

        if (blank.age < 18)
            throw new Exception("Вам нет 18. Извините.");

        Console.WriteLine("А ну ка посчитайте..10 / 0 = ? \nВыберите вариант ответа : 1 - Ошибка, 2 - 0, 3 - 1");
        int x = 10;
        int y = 0;
        blank.zero = Convert.ToInt32(Console.ReadLine());

        switch (blank.zero)
        {
            case 1:
                Console.WriteLine("Всё верно" + x/y);
                break;
            case 2:
                Console.WriteLine(x/y);
                break;
            case 3:
                Console.WriteLine(x/y);
                break;
        }
    }
    
}