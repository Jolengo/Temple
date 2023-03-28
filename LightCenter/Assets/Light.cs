using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public float minIntensity = 0.0f;        // ����������� ������������� �����
    public float maxIntensity = 1.0f;        // ������������ ������������� �����
    public float flickerSpeed = 1.0f;        // �������� ��������

    private Light lightSource;              // ������ �� ��������� ��������� �����
    private float targetIntensity;          // ������� ������������� �����
    private float intensity;

    private void Start()
    {
        // �������� ��������� ��������� �����
        lightSource = GetComponent<Light>();

        // ������ ��������� ������� ������������� �����
        targetIntensity = Random.Range(minIntensity, maxIntensity);
    }

    private void Update()
    {
        // ������ �������� ������������� �����
        lightSource.intensity = Mathf.Lerp(lightSource.intensity, targetIntensity, flickerSpeed * Time.deltaTime);

        // ���� ������������� ����� �������� �������, �� ������ ����� ������� �������������
        if (Mathf.Approximately(lightSource.intensity, targetIntensity))
        {
            targetIntensity = Random.Range(minIntensity, maxIntensity);
        }
    }
}
