using UnityEngine;

public class MovePipe : MonoBehaviour
{
    public float moveSpeed = 20.0f;
    public float deadZone = -35.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += moveSpeed * Time.deltaTime * Vector3.left;

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
