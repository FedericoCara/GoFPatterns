using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.State {
    public class Switch {

        State state;
        public State State {
            get => state;
            set => state = value;
        }
       
        public Switch()
        {
            state = new TurnedOn();
        }
       
        public void Press()
        {
            state.ChangeState(this);
           Console.WriteLine(state.Describe());
        }
    }
}
