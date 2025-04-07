using UnityEngine;

public class CoinMovement : MonoBehaviour
{
    private void Awake()
    {
    }
    private void Update()
    {
        transform.Rotate(new Vector3(0.0f, 0.0f, 100.0f * Time.deltaTime));
    }
}
