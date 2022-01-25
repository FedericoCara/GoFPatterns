using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.State {
    public class StandBy : State
    {
        public override void ChangeState(Switch sw)
        {
            sw.State = new TurnedOn();
        }

        public override string Describe()
        {
            return "Switch on stand by";
        }
    }
}
