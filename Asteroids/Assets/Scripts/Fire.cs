using UnityEngine;

public class Fire
{
    public const string fire1 = "Fire1";
    public void Shot(Rigidbody bullet, Transform gun, float force)
    {
        if (Input.GetButtonDown(fire1))
        {
            var temAmmunition = Object.Instantiate(bullet, gun.position, gun.rotation);
            temAmmunition.AddForce(gun.up * force);
        }
    }
}
