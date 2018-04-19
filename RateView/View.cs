using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class View
    {

        public void RateMeal(string comment, Meal meal)
        {
            AuthenticationHandler a = new AuthenticationHandler();
            string token = string.Empty;

            try
            {
                string credential = a.GetUser(token);
                var markController = new MarkController();
                markController.SendFeedback(comment, meal, credential);
            }
            catch (Exception)
            {
                //ELO
            }
        }
    }
}
