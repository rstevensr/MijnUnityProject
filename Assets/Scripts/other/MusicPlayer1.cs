using UnityEngine;

public class MusicPlayer1 : MonoBehaviour
{
    private string currentSong = "";
    private bool isPlaying = false;
    private float volume = 1.0f;

    void Start()
    {
        SetVolume(0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Bladee - Sugar");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("Current song: " + GetCurrentSong());
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Is playing: " + IsPlaying());

        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(0.08f);
        }

    }

    void PlaySong(string song)
    {
        currentSong = song;
        isPlaying = true;
        Debug.Log("Playing song: " + currentSong);
    }

    void StopSong()
    {
        isPlaying = false;
        Debug.Log("Song stopped.");
    }

    void SetVolume(float v)
    {
        Debug.Log("Volume: " + volume);
    }

    string GetCurrentSong()
    {
        return currentSong;
    }

    bool IsPlaying()
    {
        return isPlaying;
    }
}
