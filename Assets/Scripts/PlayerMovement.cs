using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Public Attributes
    public float movementSpeed = 5f;
    public float rotationSpeed = 100f;

    void Start()
    {
        
    }

    void Update()
    {
        //Cube Movement by Keys
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movementSpeed);
        }
        if(Input.GetKey(KeyCode.W))
        {
             transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
        }

        //Cube Rotation by Keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -rotationSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }

        //Dash
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed * 75);
        }
    }
}
