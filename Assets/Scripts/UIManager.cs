using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject gameOverPanel;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetMenu(bool value)
    {
        menuPanel.SetActive(value);
    }

    public void SetPlay(bool value)
    {
        playPanel.SetActive(value);
    }

    public void SetGameOver(bool value)
    {
        gameOverPanel.SetActive(value);
    }
}
