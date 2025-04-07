using UnityEngine;

public class GameOverState : IState
{
    public void OnEnter()
    {
        Time.timeScale = 0.0f;
        UIManager.Instance.SetGameOver(true);
    }

    public void OnExit()
    {
        GameManager.Instance.RestartGame();
        UIManager.Instance.SetGameOver(false);
    }

    public void OnUpdate(float dt)
    {
    }
}
