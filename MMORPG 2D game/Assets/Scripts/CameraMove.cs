using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public GameObject player;

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
    }

}
