using System.Data.SqlTypes;
using System.Numerics;

/*
* Name: Felix Jordan
*Course: CSCI 1250, Section 001
*Assignment: Lab 04, The Group Trip
*Date: Oct 7, 2026
*Description: Rebuilds trip calculator with methods and arrays so it reports on a whole group instead of a single person
*/


//following code recieves inputs and calculates the cost of the trip

const double TAXRATE = .18;
const int PIZZASLICES = 8;


Console.Write("Input Road Trip length in miles ");
int roadTripLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Miles per Gallon ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Price per Gallon ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine()); 

Console.Write("How many pizzas are being ordered? " );
double amountOfPizza = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the price of each pizza? " );
double pricePerPizza = Convert.ToDouble(Console.ReadLine());



Console.Write("  ");


double pizzaCost = amountOfPizza * pricePerPizza;
double tripTotal = fuelCost(roadTripLength, milesPerGallon, pricePerGallon) + pizzaCost;


Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("Fuel Cost: " + fuelCost(roadTripLength, milesPerGallon, pricePerGallon));
Console.WriteLine("Pizza Cost: "+ pizzaCost);
Console.WriteLine("Trip Total: "+ (fuelCost(roadTripLength, milesPerGallon, pricePerGallon) + pizzaCost));


Console.Write("  ");


// following code seperates each persons wage/hours worked into arrays

Console.WriteLine("=== Part 2: The Group ===");


string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double[] hoursWorked = {22, 15, 30, 18 };
double[] hourlyRates = {13.50, 16.00, 11.20 , 14.80};
double costPerPerson = tripTotal / names.Length;

Console.WriteLine("People going: " + names.Length);
Console.WriteLine("Slices each: " + (amountOfPizza * PIZZASLICES) / names.Length);
Console.WriteLine("Cost per person: " + costPerPerson);


// following code uses a loop over an array to calculate how much each person works/makes. theoretically!

Console.WriteLine("=== Part 3: Who Works How Long ===");


for (int i = 0; i < names.Length; i++)
{
    double[] takeHomePays = {(hoursWorked[i] * hourlyRates[i]) - (hoursWorked[i] * hourlyRates[i] * TAXRATE)};

   Console.WriteLine(names[i] + " takes home " +  takeHomePays[i] + " for " + hoursWorked[i] + " hours " );

}
 


// this method calculates fuel cost
static double fuelCost(double roadTripLength, double milesPerGallon, double pricePerGallon)
{
    
    double gallonsNeeded = roadTripLength / milesPerGallon; 
    return gallonsNeeded * pricePerGallon;
}


// this method calculates take home pay 
static double takeHomePay(double hours, double hourlyRate, double TAXRATE)
{

    double grossPay = hours * hourlyRate;
    double taxWithheld = grossPay * TAXRATE;
    return grossPay - taxWithheld;
}


// this method calculates hours needed 
static double hoursToCover(double amountOwed, double takeHomePayPerHour)
{
   return amountOwed / takeHomePayPerHour;
}







// //Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
// //Console.WriteLine("Fuel cost: " + fuelCost.ToString("C")); 

// // This code calculates needs for the pizza party

// Console.WriteLine("=== Part 2: Pizza Party ===");

// double totalSlices = pizzaSlices * amountOfPizza;
// double slicesPerPerson = totalSlices / peopleComingToParty;


// Console.WriteLine("Total Slices: " + totalSlices);
// Console.WriteLine("Slices per Person: " + slicesPerPerson);
// Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));




// // This code calculates paycheck

// Console.WriteLine("=== Part 3: Paycheck ===");



// Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
// Console. WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
// Console. WriteLine("Take Home Pay: " + takeHomePay.ToString("C"));




// // This code calculates the trip summary

//  /*
// double tripTotal = fuelCost + pizzaCost;
// double costPerPerson = tripTotal / peopleComingToParty;
// double takeHomePayPerHour = takeHomePay / hoursWorked;
// double hoursNeeded = costPerPerson / takeHomePayPerHour;
// */



