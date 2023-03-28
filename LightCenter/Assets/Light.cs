using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public float minIntensity = 0.0f;        // Минимальная интенсивность света
    public float maxIntensity = 1.0f;        // Максимальная интенсивность света
    public float flickerSpeed = 1.0f;        // Скорость мерцания

    private Light lightSource;              // Ссылка на компонент источника света
    private float targetIntensity;          // Целевая интенсивность света
    private float intensity;

    private void Start()
    {
        // Получаем компонент источника света
        lightSource = GetComponent<Light>();

        // Задаем начальную целевую интенсивность света
        targetIntensity = Random.Range(minIntensity, maxIntensity);
    }

    private void Update()
    {
        // Плавно изменяем интенсивность света
        lightSource.intensity = Mathf.Lerp(lightSource.intensity, targetIntensity, flickerSpeed * Time.deltaTime);

        // Если интенсивность света достигла целевой, то задаем новую целевую интенсивность
        if (Mathf.Approximately(lightSource.intensity, targetIntensity))
        {
            targetIntensity = Random.Range(minIntensity, maxIntensity);
        }
    }
}
