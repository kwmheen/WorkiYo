using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fixObjectAxis : MonoBehaviour
{
    private float lockedPosX;
    private float lockedPosZ;
    private Quaternion lockedRotation; // ȸ���� ������ ����

    void Start()
    {
        lockedPosX = transform.position.x;
        lockedPosZ = transform.position.z;
        lockedRotation = transform.rotation; // �ʱ� ȸ�� ����
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(lockedPosX, transform.position.y, lockedPosZ);
        transform.rotation = lockedRotation; // ������ ȸ���� ����
    }
}
