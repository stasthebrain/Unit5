using UnityEngine;

public class Health : IHealth
{
    public int Damage(int damage, int health,GameObject gameObject)
    {
        if (health > 0)
        {
            health -= damage;
        }
        if (health<=0)
        {
            Object.Destroy(gameObject);
        }
        return health;
    }
}
