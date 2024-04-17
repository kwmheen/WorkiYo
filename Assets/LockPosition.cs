using UnityEngine;
using UnityEngine.EventSystems; // EventSystems ���ӽ����̽��� ���

public class LockPosition : MonoBehaviour, IPointerMoveHandler
{
    private Vector3 originalPosition;

    void Start()
    {
        // ������Ʈ�� ���� ��ġ�� ����
        originalPosition = transform.position;
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // Y�ุ �����ϰ� X, Z���� ���� ��ġ�� ����
        transform.position = new Vector3(originalPosition.x, transform.position.y, originalPosition.z);
    }
}
