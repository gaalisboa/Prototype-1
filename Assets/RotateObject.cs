using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 50;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime * 100);
    }
}
