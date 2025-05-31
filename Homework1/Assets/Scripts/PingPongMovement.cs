using UnityEngine;

public class PingPongMovement : MonoBehaviour
{
    public Vector3 pointA = new Vector3(6f, 0.0f, 0.0f);
    public Vector3 pointB = new Vector3(-6f, 0.0f, 0.0f);
    public float velocity = 4f;

    private Vector3 currentTarget;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentTarget = pointA;
        transform.position = pointB;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (currentTarget - transform.position).normalized * velocity * Time.deltaTime;
        if (Vector3.Distance(transform.position, currentTarget) < 0.1f)
        {
            if (currentTarget == pointB)
            {
                currentTarget = pointA;
            }
            else
            {
                currentTarget = pointB;
            }

        }
    }
}

