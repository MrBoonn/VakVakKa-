using MaskTransitions;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LosePopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] private Button _tryAgainButton;
    [SerializeField] private Button _mainMenuButoon;
    [SerializeField] private TMP_Text _timerText;

    private void OnEnable()
    {
        
        _timerText.text = _timerUI.GetFinalTime();

        _tryAgainButton.onClick.AddListener(OntryAgainButtonClicked);
        _mainMenuButoon.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadLevel(Consts.SceneNames.MENU_SCENE);
        });
    }

    private void OntryAgainButtonClicked()
    {
        TransitionManager.Instance.LoadLevel(Consts.SceneNames.GAME_SCENE);
    }
}
