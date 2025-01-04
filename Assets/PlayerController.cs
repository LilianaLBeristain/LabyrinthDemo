using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playersRigidBody;
    private float speed = 15f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playersRigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            playersRigidBody.AddForce(-Vector3.right * speed);
           // transform.Rotate(new Vector3(0, 0, 80));
        } 
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            playersRigidBody.AddForce(Vector3.right * speed);
            // transform.Rotate(new Vector3(0, 0, 80));
        } 
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            playersRigidBody.AddForce(Vector3.forward * speed);
        } 
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            playersRigidBody.AddForce(-Vector3.forward * speed);
            // transform.Rotate(new Vector3(0, 0, 80));
        }
    }
}
