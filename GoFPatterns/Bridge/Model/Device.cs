using System;

namespace GoFPatterns.Bridge {
    public abstract class Device {
        private int channel;
        private int volume;
        private bool enabled;

        public void Disable() {
            enabled = false;
        }

        public void Enable() {
            enabled = true;
        }

        public int GetChannel() {
            return channel;
        }

        public int GetVolume() {
            return volume;
        }

        public bool IsEnabled() {
            return enabled;
        }

        public void SetChannel(int channel) {
            this.channel = channel;
            Console.WriteLine($"Changing channel to {channel}");
        }

        public void SetVolume(int percent) {
            volume = percent;
            Console.WriteLine($"Setting volume to {percent}");
        }
    }
}