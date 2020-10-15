using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assigment2_N01457183_BarbaraCam.Controllers
{
    public class J2Controller : ApiController
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m">Number of sides for Die 1</param>
        /// <param name="n">Number of sides for Die 2</param>
        /// <returns>Possible combination from Die1 and Die2 that sums 10</returns>
        /// <example>Get...api/J2/dicegame/6/8-----> There are 5 total ways to get the sum of 10</example>
        /// <example>Get...api/J2/dicegame/12/4-----> There are 4 total ways to get the sum of 10</example>
        /// <example>Get...api/J2/dicegame/3/3-----> There are 0 total ways to get the sum of 10</example>
        [HttpGet]
        [Route("api/j2/dicegame/{m}/{n}")]
        public string dicegame(int m, int n)
        {
            // Adding a bool in case the user input 0 or negative number because a die can not be negative or 0 sides
            // Isinvalid is less than zero or zero
            bool isinvalid = (m <= 0) || (n <= 0);
            bool isvalid = (m > 0) || (n > 0);
            string message = "";
            
            // In case is invalid a invalid message will be displayed
            if (isinvalid)
            {
                message = "Invalid Input";
            }
            else
            {
                // The die1 loop results will be use with the results die2 loop
                // The sums of both dices should be 10 or it will be dismissed that combination
                // die1 and die2 are variables according the user input
                int totaldice = 10;
                int totalcount = 0;

                for (int die1 = 1; die1 <= m; die1++)
                {
                    for (int die2 = 1; die2 <= n; die2++)
                    {
                        if ((die1 + die2) == totaldice)
                        {
                            totalcount++;
                        }
                    }
                }

                // a message is returned with the total amount of combinations between two dices making the result a string
             return message = message + "There are " + totalcount.ToString() + " total ways to get the sum 10";
            }

          return message;

        }
    }
}

