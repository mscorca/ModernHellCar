using UnityEngine;
using System.Collections.Generic;

public class SoundManager : MonoBehaviour
{

    private static SoundManager _instance;

    public static SoundManager Instance { get { return _instance; } }


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    public int SongIndex;
    public List<AudioClip> Songs;
    public AudioSource Player;

    private void Start()
    {
        Player = GetComponent<AudioSource>();
    }

    protected void Update()
    {
        if(!Player.isPlaying) 
        {
            Player.clip = Songs[SongIndex];
            Player.Play();
            SongIndex++;
        }
    }

}
