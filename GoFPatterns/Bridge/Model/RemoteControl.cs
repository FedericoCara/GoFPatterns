using System;

namespace GoFPatterns.Bridge {
    public class RemoteControl {
        protected Device device;

        public RemoteControl(Device device) {
            this.device = device;
        }

        public void TogglePower() {
            if (device.IsEnabled()) {
                Console.WriteLine("Toggle power off");
                device.Disable();
            } else {
                Console.WriteLine("Toggle power on");
                device.Enable();
            }
        }

        public void VolumeDown() {
            device.SetVolume(device.GetVolume() - 10); 
        }

        public void VolumeUp() {
            device.SetVolume(device.GetVolume() + 10); 
        }

        public void ChannelDown() {
            device.SetChannel(device.GetChannel() - 1); 
        }

        public void ChannelUp() {
            device.SetChannel(device.GetChannel() + 1);
        }
    }
}