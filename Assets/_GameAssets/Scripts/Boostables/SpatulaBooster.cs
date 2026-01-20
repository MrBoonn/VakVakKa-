using NUnit.Framework;
using UnityEngine;

public class SpatulaBooster : MonoBehaviour, IBoostable

{

    [Header("References")]
    [SerializeField] private Animator _spatulaAnimator;
    [Header("Settings")]
    [SerializeField] private float _jumpForce;

    private bool _isActivated;
    public void Boost(PlayerController playerController)
    {
        if (_isActivated)
        {
            return;
        } 

        PlayBoostAnimation();
        Rigidbody playerRigidBody = playerController.GetPlayerRigidBody();

        playerRigidBody.linearVelocity = new Vector3(playerRigidBody.linearVelocity.x, 0f, playerRigidBody.linearVelocity.z);
        playerRigidBody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        _isActivated = true;
        Invoke(nameof(ResetActivation) , 0.2f);
    }

    private void PlayBoostAnimation()
    {
        _spatulaAnimator.SetTrigger(Consts.OtherAnimations.IS_SPATULA_JUMPING);
    }

    private void ResetActivation()
    {
        _isActivated = false;
    }
}
