using Delegates;
/*
 * Создайте свой тип исключения.
 * Сделайте массив из пяти различных видов исключений, включая собственный тип исключения.
 * Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
 * В блоке catch выведите в консольном сообщении текст исключения.
 */
try
{
    Employee employee = new Employee {Name = "Bob", Experience = 1};
}

catch (MyException ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
    
}

class MyException : Exception
{
    public MyException(string message)
        : base(message) { }

    public MyException()
    {
        
    }
}

public class Employee
{
    private int experience;
    public string Name { get; set; } = "";

    public int Experience
    {
        get => experience;

        set
        {
            if(value < 3)
                throw new Exception("К сожалению ваш опыт не соответствует данной позиции.");
            else
                experience = value;
            
        }
    }
}

