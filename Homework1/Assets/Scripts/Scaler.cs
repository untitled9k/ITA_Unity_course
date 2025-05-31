using UnityEngine;

public class Scaler : MonoBehaviour
{
    public Vector3 minScale = new Vector3(1f, 1f, 1f);
    public Vector3 maxScale = new Vector3(3f, 3f, 3f);
    public float velocity = 1f;

    private bool growing = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(growing)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, maxScale, velocity * Time.deltaTime);
            if(transform.localScale == maxScale)
            {
                growing = false;
            }
        }
        else
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, minScale, velocity * Time.deltaTime);
            if(transform.localScale == minScale)
            {
                growing = true;
            }
        }
    }
}
