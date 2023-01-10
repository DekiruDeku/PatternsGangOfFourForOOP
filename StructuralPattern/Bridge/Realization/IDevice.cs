namespace Bridge.Realization
{
    public interface IDevice
    {
        void Enable();
        
        void Disable();
        
        void SetChanel(int chanel);
        
        void SetVolume(int volume);
        
    }
}