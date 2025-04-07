using UnityEngine;

public class FanMovement : MonoBehaviour
{ 
    private float direction = 1.0f;
    private void Start()
    {
        direction = Random.Range(0.0f, 1.0f) >= 0.5f ? 1.0f : -1.0f;
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0.0f, direction * 20.0f * Time.deltaTime, 0.0f));
    }
}
