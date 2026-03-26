using UnityEngine;

public class player : MonoBehaviour
{
    private Rigidbody rigidBodyrb;
    private Animator anim;
    private AudioSource music;
    public float jumbforce;
    public ParticleSystem bomb;
    public ParticleSystem dirt;
    public AudioClip jumbsound;
    public AudioClip explode;
    public float gravityadjust;
    private bool isGrounded;
    public bool Gameover;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigidBodyrb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        music = GetComponent<AudioSource>();
        Physics.gravity *= gravityadjust;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&isGrounded==true&&!Gameover)
        {
            rigidBodyrb.AddForce(Vector3.up * jumbforce, ForceMode.Impulse);
            isGrounded=false;
            anim.SetTrigger("Jump_trig");
            dirt.Stop();
            music.PlayOneShot(jumbsound,1.0f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Ground")&& !Gameover)
        {
            isGrounded = true;
            dirt.Play();
        }
       else if(collision.gameObject.CompareTag("Obstacles")&& !Gameover)
        {
            Gameover = true;
            Debug.Log("Game Over !!");
            anim.SetBool("Death_b", true);
            anim.SetInteger("DeathType_int",1);
            bomb.Play();
            dirt.Stop();
            music.PlayOneShot(explode,1.0f);
            
        }
    }
}
