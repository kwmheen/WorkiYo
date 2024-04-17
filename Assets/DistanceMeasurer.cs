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
    public TMP_Text maxDistanceText; // �ְ� �Ÿ��� ǥ���� �ؽ�Ʈ

    private float maxDistance = 0f; // �ְ� �Ÿ��� ������ ����
    private Color originalColor; // ���� �ؽ�Ʈ ������ ������ ����

    void Start()
    {
        // ���� �ؽ�Ʈ ���� ����
        originalColor = distanceText.color;
    }

    void Update()
    {
        if (cubeTransform != null && planeTransform != null && distanceText != null && maxDistanceText != null)
        {
            float distance = Vector3.Distance(cubeTransform.position, planeTransform.position);
            distanceText.text = "Distance: " + distance.ToString("F2") + "m";

            // ���� ���� �Ÿ��� ���� �ְ� �Ÿ����� ũ�ų� ���� ���
            if (distance >= maxDistance)
            {
                maxDistance = distance;
                // �ְ� �Ÿ� �ؽ�Ʈ ����
                maxDistanceText.text = "Max Distance: " + maxDistance.ToString("F2") + "m";
                // ���� �Ÿ� �ؽ�Ʈ ���� ����
                distanceText.color = Color.red;
            }
            else
            {
                // ���� �Ÿ��� �ְ� �Ÿ����� ���� ��� ���� �������� ����
                distanceText.color = originalColor;
            }
        }
    }
}
