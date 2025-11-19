using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.Video;

public class navesigma : MonoBehaviour
{   
    int lifes;
    float shield;
    bool alive;
   

    [SerializeField] float speed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lifes = 3;
        shield = 100;
        alive = true;
        speed = 15;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Movement();
        
        if (alive= true && Input.GetKeyDown(KeyCode.Space))
        {
            Impact();

            
     
        }
        void Impact()
        {
            if (shield <= 25f)
            {
                lifes = lifes - 1;
                if (lifes <= 0)
                {
                    print("HAS MUERTO");
                    alive = false;
                }
                else
                {
                    shield = 100;
                    print(lifes + " VIDAS RESTANTES, ESCUDO RESTABLECIDO");

                }

            }
            else 
            {
                shield = shield  - 25;
                print("IMPACTO, TE QUEDA " + shield + " ESCUDO");

                 
       
            }

        }
        void Movement()
        {
            float desplY = Input.GetAxis("Vertical") * speed;
            transform.Translate(Vector3.up * desplY * Time.deltaTime);

            float desplX = Input.GetAxis("Horizontal") * speed;
            transform.Translate(Vector3.right * desplX * Time.deltaTime);


        
        }
        void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Enemigo")
            {
                Destroy(gameObject);

            }
        }
    }  }

    




        




    

