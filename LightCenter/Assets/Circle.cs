using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = 1.0f;      // �������� ��������
    public float radius = 1.0f;     // ������ ��������
    public float height = 0.0f;     // ������ ��������

    private float angle = 0.0f;     // ���� ��������
    private Transform parent;       // ������������ ������

    private void Start()
    {
        // �������� ������������ ������
        parent = transform.parent;
    }

    private void Update()
    {
        // ��������� ����� ���� ��������
        angle += speed * Time.deltaTime;

        // ��������� ����� ������� �������
        float x = radius * Mathf.Cos(angle);
        float y = height;
        float z = radius * Mathf.Sin(angle);
        transform.localPosition = new Vector3(x, y, z);

        // ������������ ������ ������������ ������������� �������
        transform.RotateAround(parent.position, Vector3.up, speed * Time.deltaTime);
    }
}
