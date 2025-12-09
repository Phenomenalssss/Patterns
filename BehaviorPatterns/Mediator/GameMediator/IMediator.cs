using Players;

namespace IMediators
{
    public interface IMediator
    {
        void Notify(Player player, string action);
    }
}
