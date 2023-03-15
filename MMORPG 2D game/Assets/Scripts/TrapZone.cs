using System.Collections;
using UnityEngine;

public class TrapZone : RespawnZone
{
    public GameObject Trap;
    public GameObject SPlatform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Trap.SetActive(true);
            StartCoroutine(TrapRespawn());
        }
    }

    private IEnumerator TrapRespawn()
    {
        yield return new WaitForSeconds(0.6f);
        Trap.SetActive(false);
        SPlatform.SetActive(true);
        player.transform.position = respawn.transform.position;
    }

}
