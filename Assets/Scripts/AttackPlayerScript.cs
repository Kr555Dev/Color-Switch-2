
using UnityEngine;

public class AttackPlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public float followSpeed;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, followSpeed * Time.deltaTime);
    }
    
}
