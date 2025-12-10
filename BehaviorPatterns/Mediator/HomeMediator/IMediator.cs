namespace HomeMediator
{
    public interface IMediator
    {
        void Notify(Device device, string action);
    }
}
