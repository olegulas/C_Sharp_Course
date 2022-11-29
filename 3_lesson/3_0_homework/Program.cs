/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
string isPalindrome(int n)
{
    int num = n;
    int div = 0;
    int rev = 0;
    while (num > 0)
    {
        div = num % 10;
        rev = 10 * rev + div;
        num = num / 10;
    }
    
    if (rev == n) 
        return $"Digit {n} == revert({rev}) is palindrome";
    else 
        return $"Digit {n} != revert({rev}) is not palindrome";
}

Console.WriteLine(isPalindrome(23432));