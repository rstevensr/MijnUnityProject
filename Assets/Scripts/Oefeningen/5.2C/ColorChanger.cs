using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    public bool touching = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Touching block, press R/G/B to change color");
            touching = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("No longer touching block");
           touching = false;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Collider>().isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (touching)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                GetComponent<Renderer>().material.color = Color.red;
                Debug.Log("Color changed to red!");
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                GetComponent<Renderer>().material.color = Color.green;
                Debug.Log("Color changed to green!");
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                GetComponent<Renderer>().material.color = Color.blue;
                Debug.Log("Color changed to blue!");
            }
        }
        else if (!touching)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("R key pressed, not on block");
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                Debug.Log("G key pressed, not on block");
            }
            if (Input.GetKeyDown(KeyCode.B))
            {
                Debug.Log("B key pressed, not on block");
            }
        }
    }
}
