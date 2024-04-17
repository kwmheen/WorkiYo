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
        // 슬라이더의 초기값 설정
        distanceSlider.minValue = 0; // 최소 거리
        distanceSlider.maxValue = 1; // 최대 거리
        distanceSlider.value = 0.5f; // 시작시 중간 값

        // 슬라이더 값이 변경될 때 호출될 메서드 설정
        distanceSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    private void OnSliderValueChanged(float value)
    {
        // 'Left Cylinder'와 'Right Cylinder' 사이의 지점을 계산
        Vector3 position = Vector3.Lerp(leftCylinder.position, rightCylinder.position, value);
        // 계산된 지점으로 조정 가능한 실린더의 위치 설정
        transform.position = new Vector3(position.x, transform.position.y, position.z);
    }
}

