using Leopotam.EcsLite;
using UnityEngine;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public class PlayerMovementSystem : IEcsRunSystem
    {
        private EcsPool<Player.Input> _playerInputPool;
        private EcsPool<Ref<Rigidbody>> _rigidbodyPool;

        private EcsQuery<Player.Input, Ref<Rigidbody>> _query;

        private IPlayerService _playerService;
        private MovementSettings _movementSettings;
        
        public void Run(IEcsSystems systems)
        {
            foreach (var entity in _query)
            {
                ref var playerInput = ref _playerInputPool.Get(entity);
                
                var rigidbody = _rigidbodyPool.Get(entity).Value;
                
                rigidbody.velocity = new Vector3(playerInput.Horizontal, 0, playerInput.Vertical) * _movementSettings.Speed;
                
                if (rigidbody.velocity.sqrMagnitude < float.Epsilon)
                    _playerService.DebugAction();
            }
        }
    }
}