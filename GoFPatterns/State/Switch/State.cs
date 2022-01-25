using System;
using System.Collections.Generic;
using System.Text;

namespace GoFPatterns.State {
    public abstract class State
    {
        public abstract void ChangeState(Switch sw);
        public abstract string Describe();
    }
}
