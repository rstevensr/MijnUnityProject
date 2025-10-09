using UnityEngine;

public class triggersomthing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something jenters trigger");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player enters trigger area");
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }


    }

    private void OnTriggerStay(Collider other)
    {
       // Debug.Log("Stay");
    }

    private void OnTriggerExit(Collider other)
    {
       // Debug.Log("Exit");
    }
}
