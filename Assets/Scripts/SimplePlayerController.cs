using UnityEngine;

public class SimplePlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotateSpeed = 180f;
    [SerializeField] private float upDownSpeed = 5f;

    void Update()
    {
        Move();
        Rotate();
        UpDown();
    }

    private void Move()
    {
        float moveXDirection = Input.GetAxis("Vertical");
        Vector3 move = Vector3.forward * moveXDirection * (Time.deltaTime * moveSpeed);
        transform.Translate(move);
    }

    private void Rotate()
    {
        float rotateInput = 0f;

        if (Input.GetKey(KeyCode.A))
            rotateInput = -1f;
        else if (Input.GetKey(KeyCode.D))
            rotateInput = 1f;

        transform.Rotate(0f, rotateInput * rotateSpeed * Time.deltaTime, 0f);
    }

    private void UpDown()
    {
        float upDownPos = 0f;

        if (Input.GetKey(KeyCode.Space))
            upDownPos = 1f;
        else if (Input.GetKey(KeyCode.LeftShift))
            upDownPos = -1f;

        transform.Translate(new Vector3(0f, upDownPos * Time.deltaTime * upDownSpeed, 0f));
    }
}