using UnityEngine;

public class StateController : MonoBehaviour
{
    private PlayerState _currentPlayerState = PlayerState.Idle;

    private void Start()
    {
        ChangeState(PlayerState.Idle);
    }
    public void ChangeState(PlayerState newLayerState)
    {
        if (_currentPlayerState == newLayerState) { return; }

        _currentPlayerState = newLayerState;

    }
    public PlayerState GetCurrentState()
    {

        return _currentPlayerState;

    }
}