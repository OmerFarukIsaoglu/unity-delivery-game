using UnityEngine;
using TMPro;
public class colllisions : MonoBehaviour
{
    bool package;
    [SerializeField]
    float takingpackage = 0.3f;
    [SerializeField]
    TMP_Text gameovertext;
    public int counter = 0;
    private void Start()
    {
        gameovertext.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("package") && !package) {
            Debug.Log("u got the package :)");
            package = true;
            Destroy(collision.gameObject,takingpackage);
            GetComponent<ParticleSystem>().Play();
        }
        
        if (collision.CompareTag("customer") && package) {
            Debug.Log("the package has arrived sucsesfully ");
            package = false;
            GetComponent<ParticleSystem>().Stop();
            Destroy(collision.gameObject, 0.3f);
            counter++;
            if (counter == 5)
            {
                gameovertext.gameObject.SetActive(true);
            }
        }
        if (collision.CompareTag("work"))
        {
            Debug.Log("its time to take a nap");
        }
       
 
        }

    
}
