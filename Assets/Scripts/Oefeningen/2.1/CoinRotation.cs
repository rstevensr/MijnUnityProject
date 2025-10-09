using UnityEngine;

public class CoinRotation : MonoBehaviour
{
    public float amplitude = 5f;
    public float frequency = 2.5f;

    private Vector3 startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
        Debug.Log("Positie: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
        transform.Rotate(0, 0, 75 * Time.deltaTime);
        
    }
}
