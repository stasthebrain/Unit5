using UnityEngine;

namespace Asteroids
{
    internal sealed class PlayerController : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private int _hp;
        [SerializeField] private Rigidbody _bullet;
        [SerializeField] private int _bulletDamage;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private Rigidbody player;
        [SerializeField] private GameObject playerGameObject;

        private MoveForce _moveForce;
        private Health hp;
        private Fire fire;
       

        private void Start()
        {
            _moveForce = new MoveForce(player, _speed);
            hp = new Health();
            fire = new Fire();
            
        }
        private void Update()
        {
            fire.Shot(_bullet, _barrel, _force);
        }
        private void FixedUpdate()
        {
            _moveForce.Move();
        }
        private void OnCollisionEnter(Collision other)
        {
            hp.Damage(_bulletDamage, _hp, playerGameObject );
        }
    }
}