using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class View
    {
        public async Task<Token> Login(string username, string password)
        {
            var authenticationController = new AuthenticationController();
            var token = await authenticationController.Authenticate(username, password);
            return token;
        }


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
