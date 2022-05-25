// See https://aka.ms/new-console-template for more information
using DAL;


string name;
string surname;

string fullname;
string SaId;
int ParkSpot;


DateTime BirthDay;
DateTime StartDate;
DateTime EndDate;




Console.WriteLine("Please enter name");
name = Console.ReadLine();
Console.WriteLine("Please enter Surname");
surname = Console.ReadLine();
Console.WriteLine("Please enter Fullname");
fullname = Console.ReadLine();

Console.WriteLine("Please enter Department Name");
string depName = Console.ReadLine();
Console.WriteLine("Please enter Description");
string description = Console.ReadLine();
Console.WriteLine("Please enter SA Identification");
SaId = Console.ReadLine();
Console.WriteLine("Please enter Parking Spot");
ParkSpot = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Do you celebrate your birthday");
string Celebrate = Console.ReadLine().ToUpper();



BirthDay = DateTime.Now;

StartDate = DateTime.Now;

EndDate = DateTime.Now;
//this is a connection string which is used to store the details.
string connect = "Server=(localdb)\\MSSQLLocalDB;Trusted_Connection=True;Initial Catalog=AppFactoryCentral1" ;

    //access the function from the access layer
    Access.Connect(name,  surname,  fullname,  SaId, depName,  description, ParkSpot, Celebrate ,  BirthDay,StartDate ,EndDate, connect);

