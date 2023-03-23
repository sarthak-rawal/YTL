
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public float linemovemnet = 2000f;
    public float sidemovement = 600f;
    // Start is called before the first frame update
   /* void Start()
    {
        
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, linemovemnet * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(- sidemovement * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
       

    }
}
