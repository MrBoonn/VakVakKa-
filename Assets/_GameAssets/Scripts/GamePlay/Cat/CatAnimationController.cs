using UnityEngine;

public class CatAnimationController : MonoBehaviour
{
    [SerializeField] private Animator _catAnimator;

    private CatStateController _catStateCOntroller;

    private void Awake()
    {
        _catStateCOntroller =GetComponent<CatStateController>();
    }

    private void Update()
    {
        SetCatAnimations();
    }

    private void SetCatAnimations()
    {
        var currentCatState = _catStateCOntroller.GetCurrentState();

        switch (currentCatState)
        {
            case CatState.Idle:
                _catAnimator.SetBool(Consts.CatAnimatons.IS_IDLING, true);
                _catAnimator.SetBool(Consts.CatAnimatons.IS_WALKING, false);
                _catAnimator.SetBool(Consts.CatAnimatons.IS_RUNNING, false);
                break;
            case CatState.Walking:
                _catAnimator.SetBool(Consts.CatAnimatons.IS_IDLING, false);
                _catAnimator.SetBool(Consts.CatAnimatons.IS_WALKING, true);
                _catAnimator.SetBool(Consts.CatAnimatons.IS_RUNNING, false);
                break;
            case CatState.Running:
                _catAnimator.SetBool(Consts.CatAnimatons.IS_RUNNING, true);
                break;
            case CatState.Attacking:
                _catAnimator.SetBool(Consts.CatAnimatons.IS_ATTACKING, true);
                break;
        }
    }
}
