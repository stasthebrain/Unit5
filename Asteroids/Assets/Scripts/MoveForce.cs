using UnityEngine;


namespace Asteroids
{
    internal sealed class MoveForce
    {
        
        private const string _horizontal = "Horizontal";
        private const float fly = 1f;
        private const float plane = 0.0f;
        private readonly float _speed;
        private Rigidbody _rb;
        public float Speed { get; set; }
            
        public MoveForce(Rigidbody rb, float speed)
        {
            _rb = rb;
            _speed = speed;
        }
        public void Move()
        {
            var speed = _speed;

            Vector3 movement = new Vector3(Input.GetAxis(_horizontal), plane, fly);
            _rb.AddForce(movement * speed, ForceMode.Force);

        }
    }
}
