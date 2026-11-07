using UnityEngine;

public class MovementManager : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontal + transform.forward * vertical;
        controller.Move(move * playerSpeed * Time.deltaTime);
    }
}
