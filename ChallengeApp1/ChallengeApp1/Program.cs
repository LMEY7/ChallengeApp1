int number = 4566703;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] c = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, };

for (int i = 0; i<letters.Length; i++)
{
    for(int j = 0; j<digits.Length; j++)
    {
        if (letters[i] == digits[j])
        {
            c[j]++;
        }
    }
}
Console.WriteLine("Liczba do sprawdzenia" + '-' + numberAsString);
for (int i=0; i<10; i++)
{
    Console.WriteLine("Liczb" + " " + (i) + " " + "jest" + " " + c[i]);
}