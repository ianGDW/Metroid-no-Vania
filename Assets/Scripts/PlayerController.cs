using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3 (horizontalInput, 0f, verticalInput).normalized;

        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
