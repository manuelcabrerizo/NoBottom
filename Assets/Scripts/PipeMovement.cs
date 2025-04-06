using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float velocity = 20.0f;

    void Update()
    {
        Vector3 position = transform.position;
        position.y += velocity * Time.deltaTime;
        transform.position = position;
    }
}
