using System.Runtime.ConstrainedExecution;
using MaskTransitions;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuControllerUI : MonoBehaviour
{
    [SerializeField] private Button _playButton;
    [SerializeField] private Button _quitButton;

    private void Awake()
    {
        _playButton.onClick.AddListener(() =>
        {
            TransitionManager.Instance.LoadLevel(Consts.SceneNames.GAME_SCENE);
            
        });

        _quitButton.onClick.AddListener(() =>
        {
            Debug.Log("Quitting The Game!");
            Application.Quit();
        });
    }
}
