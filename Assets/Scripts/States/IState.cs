
using UnityEngine;

public interface IState
{
    public void OnEnter();
    public void OnUpdate(float dt);
    public void OnExit();
}
