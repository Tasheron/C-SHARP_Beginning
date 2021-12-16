int number = 123456;

string Reverse(int number){
    if(number < 10)
        return "" + number;
    int lastDigit = number % 10;
    return lastDigit + " " + Reverse(number / 10);
}

Console.Write(Reverse(number));