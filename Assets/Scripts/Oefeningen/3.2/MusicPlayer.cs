using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SetVolume(0.8f);
        IsPlaying(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PlaySong("Bladee - sugar");
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            StopSong();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            GetCurrentSong("Bladee - sugar");
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            IsPlaying(true);
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SetVolume(0.8f);
        }

    }

    void IsPlaying(bool isPlaying)
    {
        Debug.Log("Is playing: " +  isPlaying);
    }

    void SetVolume(float volume)
    {
        Debug.Log("Volume: "+ volume);
    }

   void PlaySong(string song)
    {
        Debug.Log("Playing song: "+ song);
    }

    void StopSong()
    {
        Debug.Log("Song stopped.");
    }

    void GetCurrentSong(string song)
    {
        Debug.Log("Current song: " + song);
    }

}
