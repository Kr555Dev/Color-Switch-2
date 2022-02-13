
using UnityEngine;

public class FollowPlayerScript : MonoBehaviour
{
    public Transform player;

     void Update()
    {
        if(player.position.y > transform.position.y)
        {
            transform.position = new Vector3(0f, player.position.y, transform.position.z);
        }
           }

}
