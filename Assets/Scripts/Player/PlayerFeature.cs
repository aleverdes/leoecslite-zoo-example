using Leopotam.EcsLite;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public class PlayerFeature : IEcsUpdateFeature, IEcsFixedUpdateFeature, IEcsInjectionFeature
    {
        public void SetupUpdateSystems(IEcsSystems systems)
        {
            systems
                .Add(new PlayerInputSystem())
                ;
        }

        public void SetupFixedUpdateSystems(IEcsSystems systems)
        {
            systems
                .Add(new PlayerMovementSystem())
                ;
        }

        public void SetupInjector(IEcsInjector injector)
        {
            injector
                .AddInjectionObject<IPlayerService>(new PlayerService())
                ;
        }
    }
}