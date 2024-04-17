using UnityEngine;
using UnityEngine.EventSystems; // EventSystems 네임스페이스를 사용

public class LockPosition : MonoBehaviour, IPointerMoveHandler
{
    private Vector3 originalPosition;

    void Start()
    {
        // 오브젝트의 원래 위치를 저장
        originalPosition = transform.position;
    }

    public void OnPointerMove(PointerEventData eventData)
    {
        // Y축만 변경하고 X, Z축은 원래 위치로 고정
        transform.position = new Vector3(originalPosition.x, transform.position.y, originalPosition.z);
    }
}
