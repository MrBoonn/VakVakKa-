using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Transform _playerTransForm;
    [SerializeField] private Transform _orientationTransform;
    [SerializeField] private Transform _playerVisualTransform;

    [Header("Settings")]
    [SerializeField] private float _rotationSpeed = 10f;

    private void Update()
    {
        // Kamera hangi yöne bakıyorsa, orientation o yöne bakacak
        _orientationTransform.forward = transform.forward;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 inputDirection =
            _orientationTransform.forward * v +
            _orientationTransform.right * h;

        if (inputDirection.sqrMagnitude > 0.01f)
        {
            // Y eksenini sabit tut
            Vector3 targetDir = new Vector3(inputDirection.x, 0, inputDirection.z);

            _playerVisualTransform.forward =
                Vector3.Slerp(
                    _playerVisualTransform.forward,
                    targetDir.normalized,
                    Time.deltaTime * _rotationSpeed
                );
        }
    }
}
