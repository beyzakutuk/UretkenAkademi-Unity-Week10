using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneHeightController : MonoBehaviour
{
    [SerializeField] private Slider heightSlider;
    [SerializeField] private float maxHeight = 10.0f;

    void Start()
    {
        heightSlider.value = transform.position.y;
    }

    void Update()
    {
        
    }

    public void SliderValue(float newHeight)
    {
        float clampedHeight = Mathf.Clamp(newHeight, 0.0f, maxHeight);

        Vector3 newPosition = transform.position;

        newPosition.y = clampedHeight;
        transform.position = newPosition;
    }
}
