using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatasCodewars.Katas
{
    public class CalculateBMI
    {
        public string BMI(double weight, double height)
        {
            double bmi = weight / (height * height);
            if (bmi <= 18.5)
            {
                return "Underweight";
            } else if (bmi <= 25.0)
            {
                return "Normal";
            } else if (bmi <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }
}
//Shorest:

// => (w = w / h / h) > 30 ? "Obese" : w > 25 ? "Overweight" : w > 18.5 ? "Normal" : "Underweight";

/*
  //Kata:
Write function bmi that calculates body mass index (bmi = weight / height2).

if bmi <= 18.5 return "Underweight"

if bmi <= 25.0 return "Normal"

if bmi <= 30.0 return "Overweight"

if bmi > 30 return "Obese"
*/