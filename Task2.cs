// ტექნიკური სავარჯიშოები
// სავარჯიშო 1: For ციკლი
// 1. დაწერე პროგრამა, რომელიც დაბეჭდავს 1-დან 100-მდე ციფრებს For ციკლის
// გამოყენებით.

// internal class Program
// {
//     public static void Main()
//     {
//         for (int i = 0; i <= 100; i++)
//         Console.WriteLine(i);
//     }
// }
// 2. დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს ყველა ლუწ
// რიცხვს 1-დან 50-მდე.

// internal class Program
// {
//     public static void Main()
//     {
//         for (int i = 0; i <= 50; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.WriteLine(i);
//             }
//         }
//     }
// }


// სავარჯიშო 2: While ციკლი

// 1. დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით დაითვლის და დაბეჭდავს
// ყველა რიცხვის ჯამს 1-დან 50-მდე.

// internal class Program
// {
//     public static void Main()
//     {
//         int i = 0;
//         int sum = 0;

//         while (i <= 50)
//         {
//             sum = sum+i;
//             i++;
//         }

//         Console.WriteLine(sum);
//     }
// }

// 2. დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით 5-ჯერ მოსთხოვს
// მომხმარებელს შეიყვანოს რიცხვი და დაბეჭდავს ამ რიცხვების ჯამს.

// using System.Globalization;

// internal class Program
// {
//     public static void Main()
//     {   
//         int i = 0;
//         int input_num;
//         int sum = 0;

//         while (i < 5)
//         {
//             i++;
//             Console.Write($"Type Number {i}: ");
//             input_num = int.Parse(Console.ReadLine());
//             sum += input_num;

//         }
//         Console.WriteLine($"Sum of ur numbers: {sum}");
//     }
// }

// სავარჯიშო 3: Do-While ციკლი

// 1. დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს 10-ზე ნაკლები
// რიცხვი და სანამ რიცხვი არ იქნება 10-ზე ნაკლები, ისევ მოითხოვს მონაცემის შეყვანას
// (Do-While ციკლის გამოყენებით).

// internal class Program
// {
//     public static void Main()
//     {
//         int input_num;

//         do
//         {
//             Console.WriteLine("Type number less then 10: ");
//             input_num = int.Parse(Console.ReadLine());  
//         }

//         while (input_num >= 10);
//         {
//             Console.WriteLine("good job!!");
//         }
        
        
//     }
// }

// 2. დაწერე პროგრამა, რომელიც 3-ჯერ დაუსვამს მომხმარებელს კითხვას "Do you want to
// continue?" და თუ პასუხი იქნება "yes", პროგრამა გააგრძელებს ციკლს.


// internal class Program
// {
//     public static void Main()
//     {
//         string answer;

//         do
//         {
//             Console.WriteLine("Do you want to continue?");
//             answer = Console.ReadLine();
//         }
//         while (answer == "yes");
        
//         Console.WriteLine("Ok! Bye"); 
//     }
// }


// სავარჯიშო 4: ჩადგმული (Nested) ციკლები
// დაწერე პროგრამა, რომელიც დაბეჭდავს ვარსკვლავების (*) სამკუთხედს შემდეგი ფორმით:
// *
// **
// ***
// ****
// *****

// internal class Program
// {
//     public static void Main()
//     {
       
       
//         for (int i = 1; i <= 5; i++)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
        
//     }

// }



// სავარჯიშო 5: ციკლი და პირობა (if)
// დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს რიცხვებს 1-დან 100-მდე,
// მაგრამ:
// ● თუ რიცხვი იყოფა 3-ზე, დაბეჭდოს "Fizz"
// ● თუ რიცხვი იყოფა 5-ზე, დაბეჭდოს "Buzz"
// ● თუ რიცხვი იყოფა 3-სა და 5-ზე ერთდროულად, დაბეჭდოს "FizzBuzz"

// internal class Program
// {
//     public static void Main()
//     {
//         for (int i = 1; i <= 100; i++)
//         {
            
//             if ((i % 3 == 0) && (i % 5 == 0))
//             {
//                 Console.WriteLine($"{i} FizzBuzz");
//             }
//             else if (i % 3 == 0)
//             {
//                 Console.WriteLine($"{i} Fizz");
//             }
//             else if (i % 5 == 0)
//             {
//                 Console.WriteLine($"{i} Buzz");
//             }
//             else
//             {
//                 Console.WriteLine(i.ToString());
//             }
//         }
//     }
// }


// პრაქტიკული ამოცანები

// სავარჯიშო 1: მომხმარებლის კალათის ჯამი
// დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს პროდუქტების ფასი. ყველა
// შეყვანის შემდეგ პროგრამამ მომხმარებელს უნდა ჰკითხოს სურს თუ არა გაგრძელება. თუ
// მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო
// ფასის შემოყვანა. ბოლოს პროგრამამ უნდა დაბეჭდოს შეყვანილი პროდუქტების საერთო
// ღირებულება.


// internal class Program
// {
//     public static void Main()
//     {
//         string answer;
//         int price;
//         int total_price = 0;
//         do
//         {
//             Console.WriteLine("Type price: ");
//             price = int.Parse(Console.ReadLine());
//             Console.WriteLine("Do you want to continue?");
//             answer = Console.ReadLine();
//             total_price = total_price + price;
//         }
//         while (answer == "yes" || answer == "y");
        

//         Console.WriteLine(total_price);
//     }
// }


// სავარჯიშო 2: საშუალო ქულის გამოთვლა
// დაწერე პროგრამა, რომელიც მოსწავლის ქულების შეყვანისას გამოთვლის საშუალო ქულას.
// პროგრამამ უნდა სთხოვოს მომხმარებელს შეიყვანოს მოსწავლის ქულები. ქულის შეყვანის
// შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება. თუ მომხმარებელი შეიყვანს
// “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ქულის შეყვანა. ბოლოს
// პროგრამამ უნდა დაბეჭდოს საშუალო ქულა (შეყვანილი ქულების საშუალო არითმეტიკული).



// internal class Program
// {
//     public static void Main()
//     {
//         string answer;
//         int score;
//         double total_score = 0;
//         int cnt_score = 0;
//         double value;
//         do
//         {
//             Console.WriteLine("Type score: ");
//             score = int.Parse(Console.ReadLine());
//             Console.WriteLine("Do you want to continue?");
//             answer = Console.ReadLine();
//             total_score = total_score + score;
//             cnt_score = cnt_score + 1;

//         }
//         while (answer == "yes" || answer == "y");
        
//         value = total_score/cnt_score;
//         Console.WriteLine(total_score);
//         Console.WriteLine(cnt_score);

//         Console.WriteLine(value);
        
//     }
// }



// სავარჯიშო 3: საბანკო ანგარიშის ტრანზაქციები
// დაწერე პროგრამა, რომელიც საბანკო ანგარიშის ტრანზაქციებს ამუშავებს. პროგრამა
// მომხმარებელს სთხოვს შეიყვანოს ტრანზაქციის ტიპი (შემოსავალი ან ხარჯი) და თანხა.
// ინფორმაციის შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება. თუ
// მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო
// ტრანზაქციის ტიპის და თანხის შეყვანა. საბოლოოდ პროგრამამ უნდა დაბეჭდოს ხარჯების
// ჯამი, შემოსავლების ჯამი და ანგარიშის ბალანსი.


// internal class Program
// {
//     public static void Main()
//     {
//         string type;
//         decimal income = 0m;
//         decimal expense = 0m;
//         string continue_answer;
//         bool ifcontinue;
//         decimal income_sum = 0m;
//         decimal expense_sum = 0m;
//         decimal balance;

//         do
//         {
//             Console.WriteLine("Is it income or expense? I/E");
//             type = Console.ReadLine();
//             if (type == "I")
//             {
//                 Console.WriteLine("Type ur income: ");
//                 income = decimal.Parse(Console.ReadLine());
//                 income_sum = income_sum + income;
//             }
//             else if (type == "E")
//             {
//                 Console.WriteLine("Type ur expense: ");
//                 expense = decimal.Parse(Console.ReadLine());
//                 expense_sum = expense_sum + expense;
//             }
            

//             Console.WriteLine("Do u want to continue?");
//             continue_answer = Console.ReadLine();
//             if (continue_answer == "y" || continue_answer == "yes")
//             {
//                 ifcontinue = true;
//             }
//             else
//             {
//                 ifcontinue = false;
//             }
//         }
//         while (ifcontinue);
//         balance = income_sum - expense_sum;
//         System.Console.WriteLine("ur Incomes: " + income_sum);
//         System.Console.WriteLine("ur Expences: " + expense_sum);
//         System.Console.WriteLine("ur Balance: " + balance);
//     }
// }

