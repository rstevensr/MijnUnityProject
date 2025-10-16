using UnityEngine;

public class HealthStatus : MonoBehaviour
{
    public int health;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        health = 81;

        if (Input.GetKeyDown(KeyCode.H))
        {
            health -= 10;
            Debug.Log("Health decreased! Current health" + health);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            health += 10;
            Debug.Log("Health increased! Current health:" + health);
        }
        if (health >= 80)
        {
            Debug.Log("Excellent health!");
        }
        else if (health >= 50)
        {
            Debug.Log("Good health!");
        }
        else if (health >= 20)
        {
            Debug.Log("Warning: Low health");
        }
        else if (health <= 0)
        {
            Debug.Log("Game over!");
        }
    }

    // Update is called once per frame
    void Update()
    {

        }
    }
