using UnityEngine;
using UnityEngine.UI;

public class UIMenu : MonoBehaviour
{
    [SerializeField] private Button playButton;

    private void Awake()
    {
        playButton.onClick.AddListener(OnPlayButtonClicked);
    }

    private void OnDestroy()
    {
        playButton.onClick.RemoveAllListeners();
    }

    private void OnPlayButtonClicked()
    {
        GameManager.Instance.SetPlayState();
    }
}
