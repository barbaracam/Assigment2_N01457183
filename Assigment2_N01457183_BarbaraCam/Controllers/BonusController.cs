using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace Assigment2_N01457183_BarbaraCam.Controllers
{
    public class BonusController : ApiController
    {

        /// <summary>
        /// It is a J3-junior problem (2009). The user should provide with some time input and the result will change in 7 different cities
        /// </summary>
        /// <param name="time">The present time in Ottawa</param>
        /// <returns>The difference timing in different cities Ottawa, Victoria Edmonton, Winnipeg, Toronto, Halifax and ST.Johns</returns>
        ///<example>Input 1300----->
        ///            Output------> 1300 in Ottawa
        ///                          1000 in Victoria
        ///                          1100 in Edmonton
        ///                          1200 in Winnipeg
        ///                          1300 in Toronto
        ///                          1400 in Halifax
        ///                          1430 in St. Johns
        /// </example>
        /// 

              /// How did I addressed this problem?
              ///   I created two different arrays one for the cities(string) and another for the timing differences(Int).
              ///     - I didnt use a loop because the time zone is not constant for example. Halifax > +1hr Ottawa and St Johns is > 1.5 Hour
              ///     - I had problems connecting both arrays, my results are only numbers because I couldnt concat cities with hours
              ///     - I tried to concat both arrays with an index but intengers does not accept index, I converted to string but still didnt work
              ///     - I commented the second and third trial
              ///     - The last trial offers the correct results but it is not an approachable method because some arrays can be very long
        [HttpGet]
        [Route("api/bonus/GoodTimes/{time}")]
         public string GoodTimes(int time)
          {
             List<int> hours = new List<int> { 0, (-300), (-200), (-100), 0, 100, 130 };
             List<string> cities = new List<string> { "Ottawa", "Victoria", "Edmonton", "Winnipeg", "Toronto", "Halifax", "St. John's" };
             string message = "";

             foreach (int hour in hours)
                 {
                     message = message + (hour + time).ToString() + ",";
                 }
             return message;
          }
        
        /*     


        /// Tried to connect both arrays using foreach to separate the items but I was not succesful
        /// The number match but every every result match with all the cities
        


        ///Trial 2

        public string GoodTimes(int time)
         {
            List<int> hours = new List<int> { time, (-300 + time), (-200 + time), (-100 + time), 0 + time, 100 + time, 30 + time };
            List<string> cities = new List<string> { "Ottawa", "Victoria", "Edmonton", "Winnipeg", "Toronto", "Halifax", "St. John's" };
            string message = "";

            foreach (string city in cities)
            foreach (int hour in hours)
                {
                    message = message + hour.ToString() + city  + ",";
                }
               return message;
         } */

    

     /// I found a method in order to obtain the result however it will be very hard if the information in the arrays are long
     /// 
     /// 
     /// Trial 3
     /*
        public string GoodTimes(int time)
            {
             string result = "";
             result = time + " in Ottawa" + "," + (time+(-300)) + " in Victoria" + ", " + (time + (-200)) + " in Edmonton" + ", " + (time + (-100)) + " in Winnipeg" + ", " + (time + 0) + " in Toronto" + ", " + (time + 100) + " in Halifax" + ", " + (time + 130) + " in St. Johns";
             return result;
            }
     */
       
        

    }
}
