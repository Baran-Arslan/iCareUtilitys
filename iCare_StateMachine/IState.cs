namespace iCareGames._Common.Core
{
    public interface IState
    {
        void OnEnter();
        void OnExit();
        void Tick();

    }
}