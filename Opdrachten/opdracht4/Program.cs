using System;

namespace opdracht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De menu bestaat uit volgende items:");

            List<string> menu = new List<string>();
            
            // Eerste drankje
            product first_drink = new product();
            first_drink.productNaam = "Ice Tea";
            first_drink.productType = "Frisdrank";
            first_drink.productIngrediënten = "Ijs en thee";

            // Tweede drankje
            product second_drink = new product();
            second_drink.productNaam = "Westmalle Trippel";
            second_drink.productType = "Streekbier";
            second_drink.productIngrediënten = "Hop etc";

            // Derde drankje
            product third_drink = new product();
            third_drink.productNaam = "Cola";
            third_drink.productType = "Frisdrank";
            third_drink.productIngrediënten = "Natrium etc";

            // Vierde drankje
            product fourth_drink = new product();
            fourth_drink.productNaam = "Stella Artois";
            fourth_drink.productType = "Pils";
            fourth_drink.productIngrediënten = "Hop etc";

            // Vijfde drankje
            product fifth_drink = new product();
            fifth_drink.productNaam = "Fanta";
            fifth_drink.productType = "Frisdrank";
            fifth_drink.productIngrediënten = "Natrium etc";

            // Eerste eten
            product first_meal = new product();
            first_meal.productNaam = "Frietjes";
            first_meal.productType = "Extra";
            first_meal.productIngrediënten = "Aardappelen";

            // Tweede eten
            product second_meal = new product();
            second_meal.productNaam = "Balletjes in tomatensaus";
            second_meal.productType = "Hoofdgerecht";
            second_meal.productIngrediënten = "Balletjes en saus";

            product third_meal = new product();
            third_meal.productNaam = "Macaroni";
            third_meal.productType = "Hoofdgerecht";
            third_meal.productIngrediënten = "Pasta en saus";

            product fourth_meal = new product();
            fourth_meal.productNaam = "Spaghetti";
            fourth_meal.productType = "Hoofdgerecht";
            fourth_meal.productIngrediënten = "Pasta + saus";

            product fifth_meal = new product();
            fifth_meal.productNaam = "Tomatensoep";
            fifth_meal.productType = "Soep";
            fifth_meal.productIngrediënten = "Water en rode kleurstof";
        }
    }
}
