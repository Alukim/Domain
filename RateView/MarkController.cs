using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MarkController
    {
        public void SendFeedback(string comment, Meal meal, string credential)
        {
            MealRepository mealRepository = new MealRepository();

            if (mealRepository.MealExist(meal))
            {
                var fejsik = new Fejsik();
                if (fejsik.Login(credential))
                {
                    fejsik.SendRate(comment, meal);
                }
            }
        }

    }
}
