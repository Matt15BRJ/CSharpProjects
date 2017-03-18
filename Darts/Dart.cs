using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public bool isDoubleRing { get; set; }
        public bool isTripleRing { get; set; }
        public bool isInnerBullsEye { get; set; }
        public int DartThrowScore { get; set; }

        public void Throw(Random random)
        {
            DartThrowScore = random.Next(0, 21);
            checkForMultiplier(random);
        }

        private void checkForMultiplier(Random random)
        {
            isDoubleRing = false;
            isTripleRing = false;
            isInnerBullsEye = false;
            int dartThrowPrecise = random.Next(1, 21);
            if (DartThrowScore == 0 && dartThrowPrecise == 1)
                isInnerBullsEye = true;
            else
                checkDoubleTripleRing(dartThrowPrecise);
        }

        private void checkDoubleTripleRing(int dartThrowPrecise)
        {
            if (dartThrowPrecise == 2)
                isDoubleRing = true;
            if (dartThrowPrecise == 3)
                isTripleRing = true;
        }
    }
}
