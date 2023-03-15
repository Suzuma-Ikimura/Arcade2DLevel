using UnityEngine;

public class LevelWin : RespawnZone
{
    public GameObject SPlatform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SPlatform.SetActive(false);
            collision.transform.position = respawn.transform.position;
        }
    }

}
