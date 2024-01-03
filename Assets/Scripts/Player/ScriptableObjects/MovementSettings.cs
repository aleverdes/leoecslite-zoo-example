using UnityEngine;

namespace AleVerDes.LeoEcsLiteZoo.Example
{
    [CreateAssetMenu(fileName = "MovementSettings", menuName = "Game/Movement Settings")]
    public class MovementSettings : ScriptableObject
    {
        [SerializeField] private float _speed = 2f;
        
        public float Speed => _speed;
    }
}