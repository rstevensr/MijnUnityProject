using UnityEngine;

public class Boo1 : MonoBehaviour
{
    public Transform Target;
    public float speed = 50f;

    void Start()
    {

    }

    void Update()
    {
      transform.RotateAround(Target.position, Vector3.up, speed *  Time.deltaTime);
    }
}
