using UnityEngine;
using UnityEngine.UI;
using MaskTransitions;

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
            Debug.Log("Quit Game");
            Application.Quit();
        });
    }
}
