using Leopotam.EcsLite;
using UnityEngine;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public class PlayerInputSystem : IEcsRunSystem
    {
        private EcsPool<Player.Input> _playerInputPool;

        private EcsQuery<Player, Player.Input> _query;

        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _query)
            {
                ref var playerInput = ref _playerInputPool.Get(entity);
                
                playerInput.Horizontal = Input.GetAxis("Horizontal");
                playerInput.Vertical = Input.GetAxis("Vertical");
            }
        }
    }
}