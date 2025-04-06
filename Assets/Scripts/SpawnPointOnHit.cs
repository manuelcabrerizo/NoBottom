using UnityEngine;

public class SpawnPointOnHit : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    private void OnTriggerEnter(Collider other)
    {
        if (Utils.CheckCollisionLayer(other.gameObject, layer))
        {
            PipeManager.Instance.SpawnPipe(new Vector3(0.0f, transform.position.y - 158.0f, 0.0f));
        }
    }
}
