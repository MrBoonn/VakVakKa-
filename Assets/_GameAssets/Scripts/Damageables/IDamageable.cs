using UnityEngine;

public interface IDamageable
{
    void GiveDamage(Rigidbody playerRigibody, Transform playerVisualTransform);
}
