using Unity.VisualScripting;
using UnityEngine;


public class MusicManager : MonoBehaviour
{
    public AK.Wwise.Event PlayMusicTrack;
    public AK.Wwise.Event StopMusicTrack;

    public void StartGameMusic()
    {
        PlayMusicTrack.Post(gameObject);
    }

    public void StopGameMusic()
    {
        StopMusicTrack.Post(gameObject);

    }

}
