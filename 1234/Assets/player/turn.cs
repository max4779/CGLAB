using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turn : MonoBehaviour
{
    public float rotationSpeed = 1.0f; // 회전 속도

    private bool rightStick = false; // 오른쪽 컨트롤러 조이스틱 사용 여부

    private void Update()
    {
        // 오른쪽 컨트롤러의 조이스틱 입력 가져오기
        Vector2 rightThumbstickInput = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.RTouch);

        // 플레이어 회전 처리
        RotatePlayer(rightThumbstickInput);
    }

    void RotatePlayer(Vector2 thumbstickInput)
    {
        // 오른쪽 컨트롤러의 X축 입력 값을 이용하여 회전
        float rightRotationAmount = thumbstickInput.x * rotationSpeed * Time.deltaTime;

        // 오른쪽 컨트롤러 조이스틱이 움직이면 회전 시작
        if (Mathf.Abs(thumbstickInput.x) > 0.1f)
        {
            rightStick = true;
        }

        // 오른쪽 컨트롤러 조이스틱이 멈추면 회전 멈춤
        if (Mathf.Abs(thumbstickInput.x) < 0.1f && rightStick)
        {
            rightStick = false;
            rightRotationAmount = 0;
        }

        // 플레이어 회전
        transform.Rotate(Vector3.up, rightRotationAmount);
    }
}



