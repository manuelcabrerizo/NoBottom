using UnityEngine;

[CreateAssetMenu(fileName = "AudioClipsData", menuName = "AudioClips/Sfx", order = 1)]

public class SfxClipsData : ScriptableObject
{
    [Header("Sound Effects")]
    public AudioClip CoinClip;
    public AudioClip DeadClip;
}
