
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Jumpforce = 15f;
    public SpriteRenderer spr;
    public string currentColor;

    public Color blue;
    public Color yellow;
    public Color violet;
    public Color pink;

    public GameObject bombEffect;
    // Start is called before the first frame update
    void Start()
    {
        SetRandomcolor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w") || Input.GetMouseButton(0))
        {
            rb.velocity = Vector2.up * Jumpforce;
        }

        if (Input.GetKey("a"))
        {
            rb.velocity = Vector2.left * Jumpforce;
        }

        if (Input.GetKey("d"))
        {
            rb.velocity = Vector2.right * Jumpforce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collides)
    {
        Debug.Log(collides.tag);

        if (collides.tag == currentColor)
        {
            Debug.Log("Congrats ! you earned 1 point.");
        }

        if (collides.tag == "colorChanger")
        {
            SetRandomcolor();
            Destroy(collides.gameObject);
            return;
        }

        if (collides.tag != currentColor)
        {
            Debug.Log("GAME OVER !");
            Instantiate(bombEffect, transform.position, Quaternion.identity);
            Destroy(bombEffect);

            Invoke("Restart", 0.75f);
            return;
        }       
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
    }

    void SetRandomcolor()
    {
        int Playercolor = Random.Range(0,4);

        switch (Playercolor)
        {
            case 0:
                currentColor = "blue";
                spr.color = blue;
                break;
            case 1:
                currentColor = "yellow";
                spr.color = yellow;
                break;
            case 2:
                currentColor = "violet";
                spr.color = violet;
                break;
            case 3:
                currentColor = "pink";
                spr.color = pink;
                break;

        }
    }
}
