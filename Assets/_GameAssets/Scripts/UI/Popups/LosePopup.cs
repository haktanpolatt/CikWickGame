using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LosePopup : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private TimerUI _timerUI;
    [SerializeField] private Button _tryAgainButton;
    [SerializeField] private Button _mainMenuButton;
    [SerializeField] private TMP_Text _timerText;

    private void OnEnable()
    {
        _timerText.text = _timerUI.GetFinalTime();

        _tryAgainButton.onClick.AddListener(TryAgainButtonClicked);
    }

    private void TryAgainButtonClicked()
    {
        //SceneManager.LoadScene(Consts.SceneNames.GAME_SCENE);
    }
}
