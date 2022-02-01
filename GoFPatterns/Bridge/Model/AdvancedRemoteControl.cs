namespace GoFPatterns.Bridge {
    public class AdvancedRemoteControl : RemoteControl {
        public AdvancedRemoteControl(Device device) : base(device) {
            
        }
        public void Mute() {
            device.SetVolume(0);
        }
    }
}