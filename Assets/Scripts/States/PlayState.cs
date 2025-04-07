using UnityEngine;

public class PlayState : IState
{
    public void OnEnter()
    {
        Time.timeScale = 1.0f;
        UIManager.Instance.SetPlay(true);
        AudioManager.Instance.PlayMusic();
    }

    public void OnExit()
    {
        UIManager.Instance.SetPlay(false);
        AudioManager.Instance.StopMusic();
    }

    public void OnUpdate(float dt)
    {
    }
}
