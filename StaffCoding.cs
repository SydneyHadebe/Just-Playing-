using System;
using System.Collections.Generic;
using System.Text;

namespace GamingLogic
{
    public class StaffCoding
    {
        public IEnumerable<string> RepeatString5Times(string repeat)
        {
            if (repeat == null)
            {
                throw new ArgumentNullException(nameof(repeat));
            }


            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    throw new ArgumentNullException("We just testing code");
                }

                yield return $"The number {repeat} and {i}";
            }
        }

    }
}
