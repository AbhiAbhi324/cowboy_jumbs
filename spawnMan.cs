using UnityEngine;

public class spawnMan : MonoBehaviour
{
    public GameObject obstacles;
    private player playerscript;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("Spawn", 2, Random.Range(1f, 3f));
        playerscript=GameObject.Find("Player").GetComponent<player>();
    }

  

    // Update is called once per frame
    void Spawn()
    {
        if (playerscript.Gameover == false)
        {
            Instantiate(obstacles, transform.position, obstacles.transform.rotation);
        }
    }
    
}
