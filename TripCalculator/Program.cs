using System.Data.SqlTypes;
using System.Numerics;

/*
* Name: Felix Jordan
*Course: CSCI 1250, Section 001
*Assignment: Lab 02, Trip Calculator
*Date: Sept 23, 2026
*Description: Calculates the fuel, food, and work hours behind one road trip.
*/

//This code calculates the gallons needed & fuel costs

Console.Write("Input Road Trip length in miles ");
int roadTripLength = Convert.ToInt32(Console.ReadLine());

Console.Write("Input Miles per Gallon ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("Input Price per Gallon ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = roadTripLength / milesPerGallon; 

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed:" + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost:" + fuelCost.ToString("C")); 

// This code calculates needs for the pizza party

const int PIZZASLICES = 8;

Console.Write("How many people are coming to the party? ");
double peopleComingToParty = Convert.ToDouble(Console.ReadLine());

Console.Write("How many pizzas are being ordered? " );
double amountOfPizza = Convert.ToDouble(Console.ReadLine());

Console.Write("What is the price of each pizza? " );
double pricePerPizza = Convert.ToDouble(Console.ReadLine());

double totalSlices = PIZZASLICES * amountOfPizza;
double slicesPerPerson = totalSlices / peopleComingToParty;
double pizzaCost = amountOfPizza * pricePerPizza;

Console.WriteLine("Total Slices: " + totalSlices);
Console.WriteLine("Slices per Person: " + slicesPerPerson);
Console.WriteLine("Pizza Cost: " + pizzaCost.ToString("C"));

// This code calculates paycheck

const double TAXRATE = .18;

Console.Write("Hours worked this week: ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Hourly pay rate: ");
double payRate = Convert.ToDouble(Console.ReadLine());

double grossPay = hoursWorked * payRate;
double taxWithheld = grossPay * TAXRATE;
double takeHomePay = grossPay - taxWithheld;

Console.WriteLine("Gross pay: " + grossPay.ToString("C"));
Console. WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
Console. WriteLine("Take Home Pay: " + takeHomePay.ToString("C"));


