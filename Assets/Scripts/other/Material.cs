using UnityEngine;

public class Material : MonoBehaviour
{
    void Start()
    {
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<MeshRenderer>().material.color = Color.purple;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
