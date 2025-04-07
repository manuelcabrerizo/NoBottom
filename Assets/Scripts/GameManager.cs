using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private StateMachine stateMachine;

    private MenuState menuState;
    private PlayState playState;
    private GameOverState gameOverState;

    [SerializeField] private GameObject player;
    private PlayerMovement playerMovement;
    private PlayerVisualRotation playerRotation;
    private int playerScore;
    private float depthScore;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playerMovement = player.GetComponent<PlayerMovement>();
        playerRotation = player.GetComponent<PlayerVisualRotation>();

        menuState = new MenuState();
        playState = new PlayState();
        gameOverState = new GameOverState();
        stateMachine = new StateMachine();
    }

    private void Start()
    {
        SetMenuState();
    }

    private void Update()
    {
        depthScore += 0.5f * Time.deltaTime;
        stateMachine.Update(Time.deltaTime);
    }

    public void RestartGame()
    {
        playerScore = 0;
        depthScore = 0.0f;
        playerMovement.Reset();
        playerRotation.Reset();
        PipeManager.Instance.Reset();
    }

    public void SetMenuState()
    {
        stateMachine.ChangeState(menuState);
    }

    public void SetPlayState()
    {
        stateMachine.ChangeState(playState);
    }

    public void SetGameOverState()
    {
        stateMachine.ChangeState(gameOverState);
    }

    public void AddPoint()
    {
        playerScore++;
    }

    public int GetCoins()
    {
        return playerScore;
    }

    public float GetDepth()
    {
        return depthScore;
    }

}
