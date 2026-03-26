using UnityEngine;

public class moveLeft : MonoBehaviour
{
    public float speed = 10;
    private player playerscript;
    // Start is called once
    // before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerscript=GameObject.Find("Player").GetComponent<player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerscript.Gameover == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.x < -8 && gameObject.CompareTag("Obstacles"))
        {
            Destroy(gameObject);
        }
       
      
    }
}
