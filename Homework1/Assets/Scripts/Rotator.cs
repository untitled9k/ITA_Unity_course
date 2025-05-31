using UnityEngine;

public class Rotator : MonoBehaviour
{

    public Vector3 rotationDirection = new Vector3(0, 1, 0);
    public float rotationSpeed = 90f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationDirection * rotationSpeed * Time.deltaTime);
    }
}
