using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment2_N01457183_BarbaraCam.Controllers
{
    public class J1Controller : ApiController
    {
          /// <summary>
            /// The amount of calories from the items choosen in the menu. It is 4 option for each item and are int inputs
            /// </summary>
            /// <param name="burger">The Type of burger for the combo</param>
            /// <param name="drink">The Type of drink for the combo</param>
            /// <param name="side">The type of side for the combo</param>
            /// <param name="dessert">The Type of dessert for the combo</param>
            /// <returns>The total calories are the sum of all the items choosen</returns>
            /// <example>Get.../api/J1/4/4/4/4--->0</example>
            /// <example>Get.../api/J1/1/2/3/4--->691</example>
            /// <example>Get.../api/J1/5/7/9/5--->The item is not in the menu</example>


            [HttpGet]
            [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
            public string Menu(int burger, int drink, int side, int dessert)
            {
                string message = "";

                // Burger calories: Cheeseburger[0] = 461, Fish Burger[1] = 431, Veggie Burger[2] = 420, No Burger[3] = 0
                // Drink calories: Soft Drink[0] = 130, Orange Juice[1] = 160, Milk[2] = 118, No Drink[3]= 0
                // Side calories: Fries[0] = 100, Baked Potato[1] = 57, Chef Salad[2] = 70, No Side[3]= 0
                // Dessert calories: Apple Pie[0] = 167,Sundae[1] = 266, Fruit Cup[2]= 75, No Dessert[3]= 0

                List<int> burgercalories = new List<int> { 461, 431, 420, 0 };
                List<int> drinkcalories = new List<int> { 130, 160, 118, 0 };
                List<int> sidecalories = new List<int> { 100, 57, 70, 0 };
                List<int> dessertcalories = new List<int> { 167, 266, 75, 0 };
                if (burger >= 1 && burger <= 4 && drink >= 1 && drink <= 4 && side >= 1 && side <= 4 && dessert >= 1 && dessert <= 4)
                {
                    // We decrease by one because the array starts at 0 
                    int totalcalories = burgercalories[burger - 1] + drinkcalories[drink - 1] + sidecalories[side - 1] + dessertcalories[dessert - 1];
                    message = message + "Your Total Calories count is " + totalcalories;

                    return message;
                }
                else
                {
                    return "This number is not in the menu";
                }
            }
        }
}
