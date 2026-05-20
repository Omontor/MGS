using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] AudioClip levelMusic;

    public AudioClip GetLevelMusic()
    {
        return levelMusic;
    }
}
