using System;
using System.Drawing;
using System.Threading;

namespace MonteCarlo {
    public class MonteCarloAlgorithm {
        public long TotalPoints { get; private set; }

        public long NumPointsInCircle { get; private set; }

        public double EstimatedPI {
            get { return 4.0 * NumPointsInCircle / TotalPoints; }
        }

        public void Execute(long numOfPointsToExecute, Display display) {
            double x;
            double y;
            Brush color;
            Random random = new Random();

            TotalPoints = numOfPointsToExecute;
            for (long i = 0 ; i < numOfPointsToExecute ; i++) {
                x = random.NextDouble() * 2 - 1; // <0..1> * 2 - 1  ===>  <-1..1> 
                y = random.NextDouble() * 2 - 1; // <0..1> * 2 - 1  ===>  <-1..1> 

                // Check if point is in the circle. 
                if (x * x + y * y <= 1) {
                    NumPointsInCircle++;
                    color = Brushes.Green;
                } else {
                    color = Brushes.Red;
                }

                display.AddPoint(ref x, ref y, ref color);
            }
        }
        public void Clear() {
            TotalPoints = NumPointsInCircle = 0;
        }
    }
}
