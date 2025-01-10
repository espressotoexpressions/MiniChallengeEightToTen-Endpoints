using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen_Endpoints.Services
{
    public class RestaurantPickerServices
    {
        public List<string> restaurantChinese = new();
        public List<string> restaurantItalian = new();
        public List<string> restaurantFilipino = new();
        public RestaurantPickerServices()
        {
            restaurantChinese = ["Golden Lotus Bistro", "Dragon’s Palace", "Jade Garden Eatery", "Emperor’s Feast", "Silk Road Dining", "Mandarin Delight", "Dynasty Noodles & Wok", "Red Lantern Café", "Oriental Harmony", "Lucky Bamboo Kitchen"]; //category1
            restaurantItalian = ["La Trattoria Bella", "Mamma Mia’s Cucina", "Vino e Pasta", "Bella Notte Ristorante", "Dolce Vita Pizzeria", "Ristorante Amore", "Casa di Nonna", "Tuscany Table", "Sapori del Sud", "Il Forno Italiano"]; //category2
            restaurantFilipino = ["Sarap Filipino Bistro", "Luzon Flavors", "Manila Sunset Kitchen", "Kusina ni Lola", "Pinoy Paradise", "Bayanihan Eats", "Timpla Tagalog", "Sining ng Lutong Bahay", "Kalinga Feast", "Filipino Fusion Café"]; //category3

        }

        public string GetRandomRestaurant(string restaurantCategory)
        {
            Random rng = new Random();
            int randomRestaurantIndex = rng.Next(10);

            switch (restaurantCategory.ToLower())
            {
                case "chinese":

                    return "Restaurant Name: " + restaurantChinese[randomRestaurantIndex];

                case "italian":
                    return "Restaurant Name:" + restaurantItalian[randomRestaurantIndex];


                case "filipino":

                    return "Restaurant Name: " + restaurantFilipino[randomRestaurantIndex];


                default:
                    return "Invalid category selected.";
            }


        }
    }

}