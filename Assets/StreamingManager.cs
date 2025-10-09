using UnityEngine;

public class StreamingManager : MonoBehaviour
{
    [Header("Stream Info")]
    public string streamerName = "EpicGamer";
    public string currentGame = "Minecraft";
    public bool isLive = false;
    public string category = "Gaming";
    public string language = "English";


    [Header("Stream Stats")]
    public int viewers = 0;
    public int followers = 1250;
    public float streamTimeHours = 0.0f;
    public int chatMessages = 0;
    public int subGoal = 200;
    public bool goalReached = false;

    [Header("Equipment Status")]
    public bool cameraOn = true;
    public bool microphoneOn = true;
    public int audioLevel = 75;
    public string streamQuality = "1080p";
    public int setupCost = 1500;
    public float hoursLive = 4.3f;

    [Header("Interaction")]
    public int donations = 0;
    public int subscriberCount = 150;
    public bool moderationMode = false;
    public bool emoteOnly = false;
    public bool subOnly = false;

    void Start()
    {
        Debug.Log("=== STREAMING SETUP MANAGER ===");
        Debug.Log("Streamer: " + streamerName);
        Debug.Log("Ready to stream: " + currentGame);
        Debug.Log("Controls:");
        Debug.Log("L = Go Live | O = Go Offline | V = Add Viewers");
        Debug.Log("M = Toggle Mic | C = Toggle Camera | I = Show Info");
        Debug.Log("===============================");
    }

    void Update()
    {
        // Update stream time als live
        if (isLive)
        {
            streamTimeHours += Time.deltaTime / 3600f; // Seconden naar uren
        }

        // Input handling
        if (Input.GetKeyDown(KeyCode.L))
        {
            // Go Live
            if (!isLive)
            {
                isLive = true;
                viewers = 5; // Start met wat viewers
                Debug.Log("GOING LIVE! Stream started!");
                Debug.Log("Current viewers: " + viewers);
            }
            else
            {
                Debug.Log("Already live!");
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            // Go Offline
            if (isLive)
            {
                isLive = false;
                Debug.Log("STREAM ENDED! Thanks for watching!");
                Debug.Log("Total stream time: " + streamTimeHours.ToString("F2") + " hours");
                viewers = 0;
            }
            else
            {
                Debug.Log("Not currently streaming!");
            }
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            // Add viewers (simuleer groei)
            if (isLive)
            {
                viewers += 1000000;
                chatMessages += 50000;
                followers += 1000000;
                Debug.Log("Going viral!");
                Debug.Log("Current viewers: " + viewers);
                Debug.Log("Current followers: " + followers);
                Debug.Log("Chat is getting active! Messages: " + chatMessages);
            }
            else
            {
                Debug.Log("Need to be live first!");
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle microphone
            microphoneOn = !microphoneOn;
            Debug.Log("Microphone: " + (microphoneOn ? "ON" : "MUTED"));
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            // Toggle camera
            cameraOn = !cameraOn;
            Debug.Log("Camera: " + (cameraOn ? "ON" : "OFF"));
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            // Show complete info
            Debug.Log("=== STREAM DASHBOARD ===");
            Debug.Log("Streamer: " + streamerName);
            Debug.Log("Game: " + currentGame);
            Debug.Log("Status: " + (isLive ? "LIVE" : "OFFLINE"));
            Debug.Log("Viewers: " + viewers);
            Debug.Log("Followers: " + followers);
            Debug.Log("Stream Time: " + streamTimeHours.ToString("F2") + " hours");
            Debug.Log("Chat Messages: " + chatMessages);
            Debug.Log("Camera: " + (cameraOn ? "ON" : "OFF"));
            Debug.Log("Mic: " + (microphoneOn ? "ON" : "MUTED"));
            Debug.Log("Audio Level: " + audioLevel + "%");
            Debug.Log("Quality: " + streamQuality);
            Debug.Log("Donations: $" + donations);
            Debug.Log("Subscribers: " + subscriberCount);
            Debug.Log("Moderation: " + (moderationMode ? "ENABLED" : "DISABLED"));
            Debug.Log("Category: " + category);
            Debug.Log("Language: " + language);
            Debug.Log("Subgoal: " + subGoal);
            Debug.Log("Goal reached: " + goalReached);
            Debug.Log("Setup cost: " + setupCost);
            Debug.Log("Hours live: " + hoursLive);
            Debug.Log("Emote only: " + emoteOnly);
            Debug.Log("Sub only: " + subOnly);

            Debug.Log("=======================");
        }

        // Voeg hier je eigen functionaliteit toe!
    }
}