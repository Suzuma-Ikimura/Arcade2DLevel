using UnityEngine;

public class RespawnZone : MonoBehaviour
{
    [SerializeField]protected GameObject player;
    [SerializeField]protected GameObject respawn;

    private Vector3 TransformPos;
    private Vector3 ResPosition;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == player)
        {
            collision.transform.position = TransformPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == player)
        {
            collision.transform.position = ResPosition;
        }
    }

    protected void Respawn()
    {
        TransformPos = respawn.transform.position;
    }

    protected void ResPos()
    {
        ResPosition = respawn.transform.position;
    }

}
