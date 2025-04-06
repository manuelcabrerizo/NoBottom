using UnityEngine;

public class PlayerOnHit : MonoBehaviour
{
    [SerializeField] private LayerMask KillLayer;
    [SerializeField] private LayerMask coinLayer;
    private void OnTriggerEnter(Collider other)
    {
        if (Utils.CheckCollisionLayer(other.gameObject, KillLayer))
        {
            Time.timeScale = 0.0f;
        }
        if (Utils.CheckCollisionLayer(other.gameObject, coinLayer))
        {
        }
    }
}
