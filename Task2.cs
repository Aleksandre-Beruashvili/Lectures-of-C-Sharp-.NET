
// //calculator and ATM app

// Console.Write("num1:");
// double num1 = double.Parse(Console.ReadLine());

// Console.Write("op:");
// string op = Console.ReadLine();

// Console.Write("num2:");
// double num2 = double.Parse(Console.ReadLine());

// double res = 0;

// if (op == "+")
// {
//     res = num1 + num2;
// }
// else if (op == "-")
// {
//     res = num1-num2;

// }
// else if (op == "*")
// {
//     res = num1*num2;

// }else if (op == "/")
// {
//     res = num1/num2;

// }

// Console.Write("Result:" + res);





// //ATM ********************





// Console.OutputEncoding = System.Text.Encoding.UTF8;

// decimal client_bal = 10000m;
// decimal atm_bal = 5000m;
// decimal withdrawal_amt;
// decimal fee_margin = 1000m;
// decimal fee;

// Console.WriteLine($"თქვენს ბალანსზე არსებული თანხა: {client_bal}");

// Console.Write("შეიყვანეთ მისაღები თანხა: ");
// withdrawal_amt = decimal.Parse(Console.ReadLine());

// if (withdrawal_amt <= 0)
// {
//     Console.WriteLine("მინუს ნიშნით გამოტანა რას ნიშნავს?! შენ შეგაქვს აქეთ?!-1");
// }
// else if (withdrawal_amt > client_bal)
// {
//     Console.WriteLine("მეტი იშრომე!");
// }
// else if (withdrawal_amt > atm_bal)
// {
//     Console.WriteLine($"ბანკომატში არ არის საკმარისი თანხა, შეგიძლიათ გამოიტანოთ მაქსიმუმ {atm_bal} ლარი");
// }
// else if (withdrawal_amt > fee_margin)
// {
//     fee = withdrawal_amt * 0.02m;
//     client_bal = client_bal - (withdrawal_amt + fee);
//     Console.WriteLine($"მიიღეთ თანხა!");
//     Console.WriteLine($"თანხა ანგარიშზე: {client_bal} საკომისიო : {fee}");
// }
// else if (withdrawal_amt <= fee_margin)
// {
//     client_bal = client_bal - withdrawal_amt;
//     Console.WriteLine($"მიიღეთ თანხა!");
//     Console.WriteLine($"თანხა ანგარიშზე: {client_bal}");
// }


// If-else ამოცანები


// 1. შემოწმება, რიცხვი დადებითია თუ უარყოფითი
// დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა რიცხვი
// დადებითი, უარყოფითი, ან ნულოვანი.


// internal class Program
// {
//     private static void Main()
//     {
//         Console.Write("Type natural number here:");

//         int number = int.Parse(Console.ReadLine());

//         if (number == 0)
//         {
//             Console.WriteLine("The number is zero");
//         }
//         else if (number > 0)
//         {
//             Console.WriteLine("The number is positive");
//         }
//         else if (number < 0)
//         {
//             Console.WriteLine("The number is negative");
//         }
         
//     }
// }




// 2. შემოწმება, რიცხვი ლუწია თუ კენტი
// დაწერეთ პროგრამა, რომელიც იღებს მთელ რიცხვს და ამოწმებს, არის თუ არა ის ლუწი ან
// კენტი.

// internal class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.Write("Type natural number here:");
//         int number = int.Parse(Console.ReadLine());

//         if (0 == number % 2)
//         {
//             Console.WriteLine("Number is even");
//         }
//         else
//         {
//             Console.WriteLine("Number is odd");
//         }
//     }
// }
// 3. შეფასების კატეგორიზაცია
// დაწერეთ პროგრამა, რომელიც იღებს სტუდენტის ქულას (0-დან 100-მდე) და ბეჭდავს
// შესაბამის ნიშანს შემდეგი სკალის მიხედვით:
// ● 90-100: A
// ● 80-89: B
// ● 70-79: C
// ● 60-69: D
// ● 0-59: F

// internal class Program
// {
//     static string get_ctg_name(int score)
//     {
//         string ctg_name;
//          if (score >= 90)
//         {
//             ctg_name = "A";
//         }
//         else if (score >= 80)
//         {
//             ctg_name = "B";
//         }
//         else if (score >= 70)
//         {
//             ctg_name = "C";
//         }
//         else if (score >= 60)
//         {
//             ctg_name = "D";
//         }
//         else
//         {
//             ctg_name = "F";
//         }
//         return ctg_name;
//     }
    
//     public static void Main(string[] args)
//     {
//         Console.Write("Type score:");
//         int score = int.Parse(Console.ReadLine());
//         string category = get_ctg_name(score);
//         Console.WriteLine($"The category for the score is: {category}");
//     }
// }

// 4. ნაკიანი წლის შემოწმება
// დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა წელი ნაკიანი. წელი ნაკიანია თუ:
// ● იყოფა 4-ზე, მაგრამ
// ● არ იყოფა 100-ზე, თუ ის ასევე არ იყოფა 400-ზე.

// internal class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Type Year:");
//         int year = int.Parse(Console.ReadLine());

//         if (year % 4 == 0 && year % 100 != 0 && year % 400 != 0)
//         {
//             Console.WriteLine("It is 'Leap Year'");
//         }
//         else
//         {
//             Console.WriteLine("It is not 'Leap Year'");
//         }

//     }
// }
// 5. პაროლის შემოწმება
// დაწერეთ პროგრამა, რომელიც იღებს მომხმარებლის შეყვანილ პაროლს და ამოწმებს,
// ემთხვევა თუ არა ის წინასწარ განსაზღვრულ პაროლს (მაგალითად, "secret123"). თუ ემთხვევა,
// დაბეჭდეთ "Access Granted", თუ არ ემთხვევა, დაბეჭდეთ "Access Forbidden".


// internal class Program
// {
//     public static void Main()
//     {
//         Console.Write("Input pass:");
//         string cons_pass = Console.ReadLine();
//         if (cons_pass == "secret123")
//         {
//             Console.WriteLine("Access Granted");
//         }
//         else
//         {
//             Console.WriteLine("Access Forbidden");
//         }
//     }
// }


// 6. სამი რიცხვიდან ყველაზე დიდის პოვნა
// დაწერეთ პროგრამა, რომელიც იღებს სამ რიცხვს და ბეჭდავს მათგან ყველაზე დიდს.

// internal class Program
// {
//     public static void Main()
//     {
//         Console.Write("Input three number. First:");
//         int num1 = int.Parse(Console.ReadLine());

//         Console.Write("Second:");
//         int num2 = int.Parse(Console.ReadLine());

//         Console.Write("Third:");
//         int num3 = int.Parse(Console.ReadLine());

//         if (num1 > num2 && num1 > num3)
//         {
//             Console.WriteLine(num1);
//         }
//         else if (num2 > num3)
//         {
//             Console.WriteLine(num2);
//         }
//         else 
//         {
//             Console.WriteLine(num3);
//         }
//     }
// }

// 7. მარტივი კალკულატორი
// დაწერეთ პროგრამა, რომელიც მომხმარებლის შეყვანის საფუძველზე ასრულებს მარტივ
// არითმეტიკულ ოპერაციებს (დამატება, გამოკლება, გამრავლება ან გაყოფა) ორ რიცხვზე.
// 8. არჩევნების უფლებამოსილება
// დაწერეთ პროგრამა, რომელიც ამოწმებს, არის თუ არა პირი არჩევნებში ხმის მიცემისთვის
// უფლებამოსილი. პირი უნდა იყოს 18 წლის ან უფროსი.
// 9. დღის მისალმება საათის მიხედვით
// დაწერეთ პროგრამა, რომელიც იღებს მიმდინარე დროს (საათების მიხედვით) და
// განსაზღვრავს შესაფერის მისალმებას:
// ● დილა (5:00 - 11:59) (Good Morning)
// ● შუადღე (12:00 - 16:59) (Good Afternoon)
// ● საღამო (17:00 - 20:59) (Good Evening)
// ● ღამე (21:00 - 4:59) (Good Night)
// 10. შოპინგის ფასდაკლების კალკულატორი
// დაწერეთ პროგრამა, რომელიც ითვლის ჯამურ თანხას ფასდაკლების შემდეგ, შემდეგი
// წესებით:
// ● თუ შესყიდვის საერთო თანხა ნაკლებია $100-ზე, არ არის ფასდაკლება.
// ● თუ შესყიდვის საერთო თანხა არის $100 და $500 შორის, გამოიყენეთ 10%
// ფასდაკლება.
// ● თუ შესყიდვის საერთო თანხა $500-ზე მეტია, გამოიყენეთ 20% ფასდაკლება.
// 11. ასაკობრივი და ქვეყნის შეზღუდვების მიხედვით პროდუქტის შეძენა
// დაწერეთ პროგრამა, რომელიც ამოწმებს, შეუძლია თუ არა მომხმარებელს პროდუქტის შეძენა
// ასაკის და ქვეყნის მიხედვით. პროდუქტის შეზღუდვები ასეთია:
// ● აშშ-ში მომხმარებელი უნდა იყოს 21 წლის ან უფროსი.
// ● სხვა ქვეყნებში, მომხმარებელი უნდა იყოს 18 წლის ან უფროსი. თუ
// მომხმარებელი უფლებამოსილია შეძენისათვის, დაბეჭდეთ "შეძენა
// ნებადართულია", წინააღმდეგ შემთხვევაში "შეძენა აკრძალულია".
// 12. სესხის უფლებამოსილება
// დაწერეთ პროგრამა, რომელიც განსაზღვრავს, არის თუ არა პირი სესხის მისაღებად
// უფლებამოსილი. პირობებია:
// ● პირი უნდა იყოს 18 წლის ან უფროსი.
// ● პირს უნდა ჰქონდეს მინიმუმ $25,000 წლიური შემოსავალი.
// ● თუ პირს შემოსავალი ნაკლები აქვს $25,000-ზე, ის შეიძლება იყოს
// უფლებამოსილი თანამონაწილის (თავდების) ყოლის შემთხვევაში.
// If-else ამოცანები