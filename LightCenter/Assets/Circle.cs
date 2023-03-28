using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public float speed = 1.0f;      // Скорость движения
    public float radius = 1.0f;     // Радиус движения
    public float height = 0.0f;     // Высота движения

    private float angle = 0.0f;     // Угол поворота
    private Transform parent;       // Родительский объект

    private void Start()
    {
        // Получаем родительский объект
        parent = transform.parent;
    }

    private void Update()
    {
        // Вычисляем новый угол поворота
        angle += speed * Time.deltaTime;

        // Вычисляем новую позицию объекта
        float x = radius * Mathf.Cos(angle);
        float y = height;
        float z = radius * Mathf.Sin(angle);
        transform.localPosition = new Vector3(x, y, z);

        // Поворачиваем объект относительно родительского объекта
        transform.RotateAround(parent.position, Vector3.up, speed * Time.deltaTime);
    }
}
