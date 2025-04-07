using TMPro;
using UnityEngine;

public class UIPlay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI depthText;

    private void Awake()
    {
        coinsText.text = "Coins: " + GameManager.Instance.GetCoins();
        depthText.text = "Depth: " + GameManager.Instance.GetDepth();
    }

    private void Update()
    {
        coinsText.text = "Coins: " + GameManager.Instance.GetCoins();
        depthText.text = "Depth: " + GameManager.Instance.GetDepth();
    }
}
