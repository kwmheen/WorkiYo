using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceMeasurer : MonoBehaviour
{
    public Transform cubeTransform;
    public Transform planeTransform;
    public TMP_Text distanceText;
    public TMP_Text maxDistanceText; // 최고 거리를 표시할 텍스트

    private float maxDistance = 0f; // 최고 거리를 저장할 변수
    private Color originalColor; // 원래 텍스트 색상을 저장할 변수

    void Start()
    {
        // 원래 텍스트 색상 저장
        originalColor = distanceText.color;
    }

    void Update()
    {
        if (cubeTransform != null && planeTransform != null && distanceText != null && maxDistanceText != null)
        {
            float distance = Vector3.Distance(cubeTransform.position, planeTransform.position);
            distanceText.text = "Distance: " + distance.ToString("F2") + "m";

            // 새로 계산된 거리가 현재 최고 거리보다 크거나 같은 경우
            if (distance >= maxDistance)
            {
                maxDistance = distance;
                // 최고 거리 텍스트 갱신
                maxDistanceText.text = "Max Distance: " + maxDistance.ToString("F2") + "m";
                // 현재 거리 텍스트 색상 변경
                distanceText.color = Color.red;
            }
            else
            {
                // 현재 거리가 최고 거리보다 작은 경우 원래 색상으로 복원
                distanceText.color = originalColor;
            }
        }
    }
}
