using UnityEngine;

public class MenuState : IState
{
    public void OnEnter()
    {
        Time.timeScale = 0.0f;
        UIManager.Instance.SetMenu(true);
    }

    public void OnExit()
    {
        UIManager.Instance.SetMenu(false);
    }

    public void OnUpdate(float dt)
    {
    }
}
