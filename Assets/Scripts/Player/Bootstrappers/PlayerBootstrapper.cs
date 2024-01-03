using UnityEngine;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    public class PlayerBootstrapper : EcsEntityBootstrapper
    {
        [SerializeField] private Rigidbody _rigidbody;
        [SerializeField] private Health _health;

        private void Reset()
        {
            _rigidbody = GetComponent<Rigidbody>();
            _health = new Health {Current = 100, Max = 100};
        }

        protected override void Setup()
        {
            Add<Health>() = _health;
            Add<Ref<Rigidbody>>().Value = _rigidbody;
            Add<Player>();
            Add<Player.Input>();
        }
    }
}