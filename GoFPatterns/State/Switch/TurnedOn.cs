using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.State {
    public class TurnedOn : State
    {
        public override void ChangeState(Switch sw)
        {
            sw.State = new TurnedOff();
        }

        public override string Describe()
        {
            return "Switch turned on";
        }
    }
}
