using System.Data.SqlTypes;

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
