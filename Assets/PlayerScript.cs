using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private float speed;
    private Vector3 target = new Vector3(-2, 0, -7);



    /*// Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            transform.Rotate(new Vector3(0, 0, 80));
        }
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(0, 0, 80));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(80, 0, 0));
        }
    }*/
}
