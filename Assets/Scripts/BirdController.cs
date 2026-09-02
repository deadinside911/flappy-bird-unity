using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public InputAction flyAction;
    public LogicManager logicManager;
    public bool isAlive = true;
    public float flapStrength = 10.0f;
    public float yLimit = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        flyAction.Enable();

        logicManager = GameObject.FindGameObjectWithTag("LogicManager").GetComponent<LogicManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flyAction.triggered && isAlive)
        {
            birdRigidBody.linearVelocityY = flapStrength; 
        }

        if (transform.position.y > yLimit || transform.position.y < -yLimit)
        {
            logicManager.gameOver();
            isAlive = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.gameOver();
        isAlive = false;
    }
}
