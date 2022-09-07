Console.WriteLine("Введите пятизначное число");
String number = Console.ReadLine();
void CheckingNumber(string number){
    if (number[0]==number[4] && number[1]==number[3]){
        Console.WriteLine("Число  Палиндром ");
    }
    else
    Console.WriteLine("Число Не палиндром");
}
if (number!.Length == 5){
CheckingNumber((number));}
