using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        GetComponent<Rigidbody>().AddForce(movement * speed);
    }
}
