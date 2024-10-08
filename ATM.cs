



Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal client_bal = 10000m;
decimal atm_bal = 5000m;
decimal withdrawal_amt;
decimal fee_margin = 1000m;
decimal fee;

Console.WriteLine($"თქვენს ბალანსზე არსებული თანხა: {client_bal}");

Console.Write("შეიყვანეთ მისაღები თანხა: ");
withdrawal_amt = decimal.Parse(Console.ReadLine());

if (withdrawal_amt <= 0)
{
    Console.WriteLine("მინუს ნიშნით გამოტანა რას ნიშნავს?! შენ შეგაქვს აქეთ?!-1");
}
else if (withdrawal_amt > client_bal)
{
    Console.WriteLine("მეტი იშრომე!");
}
else if (withdrawal_amt > atm_bal)
{
    Console.WriteLine($"ბანკომატში არ არის საკმარისი თანხა, შეგიძლიათ გამოიტანოთ მაქსიმუმ {atm_bal} ლარი");
}
else if (withdrawal_amt > fee_margin)
{
    fee = withdrawal_amt * 0.02m;
    client_bal = client_bal - (withdrawal_amt + fee);
    Console.WriteLine($"მიიღეთ თანხა!");
    Console.WriteLine($"თანხა ანგარიშზე: {client_bal} საკომისიო : {fee}");
}
else if (withdrawal_amt <= fee_margin)
{
    client_bal = client_bal - withdrawal_amt;
    Console.WriteLine($"მიიღეთ თანხა!");
    Console.WriteLine($"თანხა ანგარიშზე: {client_bal}");
}