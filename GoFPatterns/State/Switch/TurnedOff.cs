using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.State {
    public class TurnedOff : State
    {
        public override void ChangeState(Switch sw)
        {
            sw.State = new StandBy();
        }

        public override string Describe()
        {
            return "Switch turned off";
        }
    }
}
