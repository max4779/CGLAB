using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float sensitivity = 2.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        currentX += mouseX;
        currentY -= mouseY;

        // 플레이어 회전 (Y축 회전만 변경)
        transform.rotation = Quaternion.Euler(currentY, currentX, 0);

        // 플레이어 이동 (이동 방향을 회전에 영향받지 않게 조정)
        Vector3 moveDirection = new Vector3(moveX, 0, moveZ);
        moveDirection = Quaternion.Euler(currentY, currentX, 0) * moveDirection;
        moveDirection.Normalize(); // 이동 방향을 정규화하여 같은 속도로 이동
        moveDirection *= moveSpeed * Time.deltaTime;

        transform.position += moveDirection;
    }
}
