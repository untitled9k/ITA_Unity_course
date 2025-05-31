using UnityEngine;

public class Teleport : MonoBehaviour
{

    public float teleportInterval = 2f;
    private float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= teleportInterval)
        {
            TeleportToRandomPosition();
            timer = 0f;
        }
    }

    void TeleportToRandomPosition()
    {
        var position = new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        transform.position = position;
    }
}
