using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class move : MonoBehaviour
{
    public float moveSpeed = 1.0f;   // �̵� �ӵ�

    private void Update()
    {
        // ���� ��Ʈ�ѷ��� ���̽�ƽ �Է� ��������
        Vector2 leftStick = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick, OVRInput.Controller.LTouch);

        // �÷��̾� �̵� �� ȸ�� ó��
        MovePlayer(leftStick);
    }

    void MovePlayer(Vector2 thumbstickInput)
    {
        // �÷��̾� �̵� ���� ���
        Vector3 moveDirection = new Vector3(thumbstickInput.x, 0, thumbstickInput.y);
        moveDirection = Camera.main.transform.TransformDirection(moveDirection);
        moveDirection.y = 0; // ���� ���� ����
        moveDirection.Normalize();

        // �÷��̾� �̵�
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}