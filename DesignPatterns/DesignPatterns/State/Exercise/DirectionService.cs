using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State.Exercise
{
    class DirectionService
    {
        private ITravelMode travelMode;

        public DirectionService(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }

        public object getEta()
        {
            return this.travelMode.GetEta();
        }

        public object GetDirection()
        {
            return this.travelMode.GetDirection();
        }

        public ITravelMode GetTravelMode()
        {
            return this.travelMode;
        }

        public void SetTravelMode(ITravelMode travelMode)
        {
            this.travelMode = travelMode;
        }
    }
}
