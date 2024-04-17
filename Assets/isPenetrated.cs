using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isPenetrated : MonoBehaviour
{
    public Material blueMaterial;
    public Material redMaterial;
    private Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = blueMaterial; // �ʱ� ������ �Ķ������� ����
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("IgnoreCollision"))
            renderer.material = redMaterial;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("IgnoreCollision"))
            renderer.material = redMaterial;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("IgnoreCollision"))
            renderer.material = blueMaterial;
    }
}