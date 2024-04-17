using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceAdjuster : MonoBehaviour
{
    public Slider distanceSlider;
    public Transform leftCylinder;
    public Transform rightCylinder;

    private void Start()
    {
        // �����̴��� �ʱⰪ ����
        distanceSlider.minValue = 0; // �ּ� �Ÿ�
        distanceSlider.maxValue = 1; // �ִ� �Ÿ�
        distanceSlider.value = 0.5f; // ���۽� �߰� ��

        // �����̴� ���� ����� �� ȣ��� �޼��� ����
        distanceSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // 'Left Cylinder'�� 'Right Cylinder' ������ ������ ���
        Vector3 position = Vector3.Lerp(leftCylinder.position, rightCylinder.position, value);
        // ���� �������� ���� ������ �Ǹ����� ��ġ ����
        transform.position = new Vector3(position.x, transform.position.y, position.z);
    }
}

