using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixObjectAxis : MonoBehaviour
{
    private float lockedPosX;
    private float lockedPosZ;
    private Quaternion lockedRotation; // 회전을 저장할 변수

    void Start()
    {
        lockedPosX = transform.position.x;
        lockedPosZ = transform.position.z;
        lockedRotation = transform.rotation; // 초기 회전 저장
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(lockedPosX, transform.position.y, lockedPosZ);
        transform.rotation = lockedRotation; // 고정된 회전을 적용
    }
}
