using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offsetPosition = new(0, 5, -7);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offsetPosition;
    }
}
