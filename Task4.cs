﻿// სავარჯიშო 1: კლასი "Person"
// შექმენით კლასი სახელად Person, რომელსაც ექნება შემდეგი თვისებები (Property):
// ● Name (სახელი) - სტრინგის ტიპი
// ● Age (ასაკი) - მთელი რიცხვის ტიპი
// ასაკი ვერ იქნება 0-ზე ნაკლები ან 120-ზე მეტი. თუ ასაკი 0-ნაკლებია ასაკი უნდა გახდეს 0-ის
// ტოლი თუ 120-ზე მეტია ასაკი უნდა გახდეს 120-ის ტოლი.
// კლასს უნდა ჰქონდეს GetInfo მეთოდი რომელიც დაარბურენს ტექსტს:
// მაგალითად :
// Person person = new Person();
// person.Name = "John";
// person.Age = 25;
// Console.WriteLine(person.DisplayInfo()); // უნდა დაბეჭდოს "Name: John, Age: 25"

public class Person
{
    public string Name { get; set;}
    public int Age { get; set;}


    public string DisplayInfo()
    {
        if (Age < 0)
        {
            Age = 0;
        }
        else if (Age > 120)
        {
            Age = 120;
        }
        return $"Name: {Name}, Age: {Age}";
    }
}
internal class Program
{
    public static void Main()
    {
        Person person= new Person();
        person.Name = "john";
        person.Age = 25;
        System.Console.WriteLine(person.DisplayInfo());
    }
}





// ამოცანა 2. კლასი "Car"
// შექმენით კლასი სახელად Car, რომელსაც ექნება შემდეგი თვისებები:
// ● Brand (ბრენდი) - სტრინგის ტიპი
// ● Year (წელი) - მთელი რიცხვის ტიპი
// გააკეთეთ ვალიდაცია Year თვისებაზე: წელი არ უნდა იყოს 1886-ზე ნაკლები და მიმდინარე
// წელზე მეტი (დაგჭირდებათ DateTime-ის გამოყენება)
// თუ წელი 1886-ზე ნაკლებია წელი ავტომატურად უნდა გახდეს 1886, თუ მიმდინარე წელზე
// მეტია უნდა გახდეს მიმდინარე წელი.
// მოცანა 3: კლასი და ენამი
// შექმენით ენამი Currency, რომელსაც ექნება შემდეგი მნიშვნელობები:
// ● GEL
// 05. Class Properties
// ● USD
// ● EUR
// შექმენით კლასი Product, რომელსაც ექნება შემდეგი თვისებები (Property):
// ● Name (დასახელება) - სტრინგის ტიპი
// ● Price (ფასი) - decimal ტიპი
// ● Currency (ვალუტა) - Currency ტიპი
// ფასი არ უნდა იყოს უარყოფითი. უარყოფითი ფასის მინიჭების შემთხვევაში ფასი უნდა
// გახდეს 0.