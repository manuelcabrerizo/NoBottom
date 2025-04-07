using UnityEngine;

public class PlayerOnHit : MonoBehaviour
{
    [SerializeField] private LayerMask KillLayer;
    [SerializeField] private LayerMask coinLayer;
    [SerializeField] private SfxClipsData SfxClipsData;
    private void OnTriggerEnter(Collider other)
    {
        if (Utils.CheckCollisionLayer(other.gameObject, KillLayer))
        {
            AudioManager.Instance.PlayClip(SfxClipsData.DeadClip, AudioSourceType.SFX);
            GameManager.Instance.SetGameOverState();
        }
        if (Utils.CheckCollisionLayer(other.gameObject, coinLayer))
        {
            // TODO: play coin sound
            AudioManager.Instance.PlayClip(SfxClipsData.CoinClip, AudioSourceType.SFX);
            GameManager.Instance.AddPoint();
            Destroy(other.gameObject);
        }
    }
}
