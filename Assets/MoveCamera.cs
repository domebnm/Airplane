using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] Transform playerTr;
    float offsetY;
    private void Start()
    {
        offsetY = transform.position.y - playerTr.position.y;
    }
    private void Update()
    {
        transform.position = new Vector3 (transform.position.x, playerTr.position.y + offsetY, transform.position.z);
    }
}
