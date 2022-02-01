using System;
using System.Collections.Generic;
using System.Text;
using GoFPatterns.Shared;

namespace GoFPatterns.Bridge {
    public class BridgeDemo : IGoFPatternDemo {
        public void Run() {
            Device tv = new Tv();
            RemoteControl remote = new RemoteControl(tv);
            remote.TogglePower();

            Device radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            remote.ChannelDown();
            remote.VolumeUp();
        }
    }
}
