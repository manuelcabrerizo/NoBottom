using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] private Button gameOverButton;
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI depthText;

    private void Awake()
    {
        gameOverButton.onClick.AddListener(OnGameOverButtonClicked);
        coinsText.text = "Coins: " + GameManager.Instance.GetCoins();
        depthText.text = "Depth: " + GameManager.Instance.GetDepth();
    }

    private void OnDestroy()
    {
        gameOverButton.onClick.RemoveAllListeners();
    }

    private void Update()
    {
        coinsText.text = "Coins: " + GameManager.Instance.GetCoins();
        depthText.text = "Depth: " + GameManager.Instance.GetDepth();
    }

    private void OnGameOverButtonClicked()
    {
        GameManager.Instance.SetPlayState();
    }
}
