// 1. Basic Inheritance
// ● შექმენით კლასი Person, რომელსაც აქვს თვისებები Name და Age.
// ● შექმენით წარმოებული (მემკვიდრე) კლასი Student, რომელიც მემკვიდრეობას
// იღებს Person-სგან და ამატებს ახალ თვისებას StudentId.
// ● შექმენით მეორე წარმოებული კლასი Teacher, რომელიც მემკვიდრეობას იღებს
// Person-სგან და ამატებს ახალ თვისებას Subject.
// ● დაწერეთ DisplayInfo() მეთოდი, რომელიც დაბეჭდავს თითიეული კლასის შესახებ
// შესაბამის ინფორმაციას და გამოიძახეთ ეს მეთოდი Student და
// Teacher ობიექტებიდან.


public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Student : Person
{
    public int StudentId { get; set; }

    DisplayInfo()
    {
        System.Console.WriteLine(StudentId);
    }
}

public class Teacher : Person
{
    public string Subject { get; set; }

        DisplayInfo()
    {
        System.Console.WriteLine(Subject);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Student student = new Student();
        student.StudentId = 55;
        student.Name = "Alex";
        student.Age = 25;


        System.Console.WriteLine(student.StudentId + student.Name + student.Age);
    }
}

// 2. Method Overriding
// ● Person კლასში შექმენით ვირტუალური მეთოდი Describe(), რომელიც ბეჭდავს
// ტექსტს "I am a person.".
// ● Student და Teacher კლასებში დააოვერრაიდეთ Describe() მეთოდი, რათა
// დაბეჭდოს "I am a student." და "I am a teacher." შესაბამისად.
// ● შექმენით Student და Teacher ობიექტები და გამოიყენეთ Describe() მეთოდი.
// 3. საბაზისო კლასის კონსტრუქტორის გამოძახება
// ● დაამატეთ კონსტრუქტორი Person კლასში, რომელიც იღებს პარამეტრებს name და
// age.
// ● Student და Teacher კლასებში გამოიყენეთ base რათა გამოიძახოთ
// Person კონსტრუქტორი და გადასცეთ პარამეტრები.
// ● შექმენით Student და Teacher ობიექტები და შეამოწმეთ საბაზისო კლასის
// კონსტრუქტორის გამოძახება.
// 4. აბსტრაქტული კლასები და მეთოდები
// ● Person კლასი გახადეთ აბსტრაქტული.
// Inheritance Excercises
// ● დაამატეთ აბსტრაქტული მეთოდი GetOccupation() Person კლასში რომელიც
// დააბრუნებს string-ს.
// ● Student და Teacher კლასებში მოახდინეთ GetOccupation() მეთოდის
// იმპლემენტაცია, რათა დააბრუნოთ საქმიანობის მნიშნველობები "Student"
// Student ტიპის ობიექტებისთვის და "Teacher" Teacher ტიპის ობიექტებისთვის.
// ● გამოიძახეთ ეს მეთოდი და დაბეჭდეთ მისი დაბრუნებული მნიშნვლება Student და
// Teacher კლასების ობიექტებიდან.
// 5. თამაშის სიმულაციის მაგალითი
// შექმენით თამაშის, რომელიც მოიცავს იარაღებსა და პერსონაჟებს. შეასრულეთ შემდეგი
// ნაბიჯები:
// 1. შექმენით აბსტრაქტული კლასი Weapon, რომელსაც ექნება თვისებები:
// ○ Name (იარაღის სახელი, ტიპი string)
// ○ Damage (ზიანის რაოდენობა, ტიპი int)
// 2. აბსტრაქტული კლასში დაამატეთ აბსტრაქტული მეთოდი GiveDamage(), რომელიც
// დააბრუნებს იარაღის მიერ მიყენებულ ზიანს.
// 3. შექმენით იარაღის კონკრეტული კლასები, რომლებიც მემკვიდრეობას იღებენ
// Weapon-ისგან და მოახდინეთ მეთოდის GiveDamage() იმპლემენტაცია თითოეულ
// იარაღში:
// ○ Sword
// ○ Bow
// ○ Axe
// 4. შექმენით კლასი Character, რომელსაც ექნება შემდეგი თვისებები:
// ○ Name (პერსონაჟის სახელი, ტიპი string)
// ○ Health (სიცოცხლე, ტიპი int)
// ○ Weapons (იარაღების კოლექცია, ტიპი List<Weapon>)
// 5. Character კლასში დაამატეთ ორი მეთოდი:
// ○ Hit(Weapon weapon, Character target): ამ მეთოდით პერსონაჟი ურტყამს
// სხვა პერსონაჟს მითითებული იარაღით და იწვევს ზიანს, რომელიც
// დამოკიდებულია იარაღის ზიანზე (Damage).
// ○ TakeDamage(int damage): ამ მეთოდით პერსონაჟი იღებს ზიანს, ანუ
// სიცოცხლის რაოდენობა მცირდება გადაცემული damage მნიშვნელობით.
// დავალება:
// 1. შექმენით რამდენიმე იარაღი (Sword, Bow, Axe) და თითოეულისთვის განისაზღვრეთ
// განსხვავებული ზიანის რაოდენობა (Damage).
// 2. შექმენით ორი პერსონაჟი, თითოეულს მიანიჭეთ რამდენიმე იარაღი.
// 3. პერსონაჟებმა გამოიყენონ Hit() მეთოდი ერთმანეთზე ზიანის მისაყენებლად.
// 4. როდესაც ერთი-ერთი პერსონაჟის სიცოცხლის დონე გახდება 0 ან 0-ზე ნაკლები
// თამაში დასრულდება.