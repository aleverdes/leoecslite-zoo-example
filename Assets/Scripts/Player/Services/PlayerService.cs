namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public interface IPlayerService
    {
        void DebugAction();
    }
    
    public class PlayerService : IPlayerService
    {
        public void DebugAction()
        {
            UnityEngine.Debug.Log("PlayerService.DebugAction");
        }
    }
}