using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RocketController : MonoBehaviour
{
    float screenWidth = Screen.width;
    [SerializeField] float thrusterForce = 1.0f;


    //[SerializeField] float tiltingForce = 10f;

    public float speed = 10.0f;
    public float rotationSpeed = 10.0f;
    float acumulado = 0;
    public float limite_angular = 90;
    public ParticleSystem particles;
    public AudioClip RocketSound;
   

    bool touch = false;

    Rigidbody rb;

    public int totalCoins = 0;

    public static Vector3 startPosition;




    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        
    }


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);


            if (touch.position.x > screenWidth / 2)
            {
                //Mudar valores
                Fly(-80.0f,1.0f);
                transform.RotateAround(transform.position, transform.up, Time.deltaTime * -28f);
                

            }

            if (touch.position.x < screenWidth / 2)
            {
                //Mudar valores
                Fly(80.0f,1.0f);
                transform.RotateAround(transform.position, transform.up, Time.deltaTime * 28f);
               

            }
           
         


            // if (touch.position.x > (screenWidth / 2))
            //{

            //  rb.AddForce(Vector3.up * thrusterForce * Time.deltaTime);
            //particles.Emit(1);
            //AudioSource.PlayClipAtPoint(RocketSound, transform.position);


            //            }




            //else
            //{


            //}



            /*thrust = Input.GetKey(KeyCode.Space);

            if (thrust)
            {
              particles.Play();
            }
            else
            {
              particles.Stop();
            }
            */



            //if (Input.GetButton("Horizontal"))
            //{

            //float angulo = rotationSpeed * Time.deltaTime * Input.GetAxisRaw("Horizontal");

            //if ((acumulado + angulo) >= limite_angular || (acumulado + angulo) <= -limite_angular)
            //angulo = 0;

            //acumulado += angulo;

            //transform.Rotate(0, 0, angulo);

            //}
        }
    }

    private void Fly(float horizontalInput, float verticalInput){

        rb.AddForce(new Vector3(horizontalInput * speed * Time.deltaTime, verticalInput *  thrusterForce * Time.deltaTime));
        particles.Play();
 

    }



    //if (Mathf.Approximately(tilt, 0f))
    //{
    // rb.freezeRotation = true;
    //transform.rotation = Quaternion.Euler(transform.eulerAngles + (new Vector3(0f, 0f, (tilt * tiltingForce * Time.deltaTime))));

    //}


    //rb.freezeRotation = false;

    void FixedUpdate()
        {

            Fly(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
          
        if (touch)
        {
        //rb.AddForce(Vector3.up * thrusterForce * Time.deltaTime);
            particles.Play();
        }

        else
        {
            particles.Stop();
          
            
        }



    }


    }


