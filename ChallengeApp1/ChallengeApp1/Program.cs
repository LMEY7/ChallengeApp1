//Zadanie dodatkowe.

var name1 = "Ewa";
var woman = true;
var age1 = 33;

if(name1 == "Ewa" && age1 == 30)
{
    Console.WriteLine("Ewa, lat 33");
}
else if(woman && age1 < 30)
{
    Console.WriteLine("Kobieta, poniżej 30 lat");
}
else if(woman == true && name1 == "Ewa" && age1 == 33 && woman == true && age1 > 30 && !woman == false && age1 != 18)
{
    Console.WriteLine("Ewa lat 33 i jej koleżanka poniżej 30 lat rozmawiały z niepełnoletnim mężczyzną");
}
else
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}