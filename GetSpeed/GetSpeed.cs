using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSpeed
{
   public class GetSpeed
    {
        public double GetCurrentSpeed(string distance, string time)
        {
            try
            {
            double distanceCovered = double.Parse(distance.Replace('.', ','));
            double totalTime = double.Parse(time.Replace('.', ','));

            double speed = distanceCovered/totalTime;

            return speed;
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }
    }
}
