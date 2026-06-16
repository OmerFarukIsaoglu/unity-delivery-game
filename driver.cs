using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
public class driver : MonoBehaviour
{
    [SerializeField]
    float rotatevalue = 0.10f;
    [SerializeField]
    float translatevalue = 0.09f;
    [SerializeField]
    float speedup = 42.3f;
    [SerializeField]
    float speedDown = 29.3f;
    [SerializeField]
    TMP_Text boostword;
    private void Start()
    {
boostword.gameObject.SetActive(false);  

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("boost"))
        {
            translatevalue = speedup;
            boostword.gameObject.SetActive(true);
            Destroy(collision.gameObject,0.1f);
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        boostword.gameObject.SetActive(false); 
        translatevalue = speedDown;
    }


    void Update()
    {
        float steer = 0f;
        float move = 0f;
        

        if (Keyboard.current.wKey.isPressed) 
        {
            move = 1f;
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            move = -1f;
        }
            if (Keyboard.current.dKey.isPressed) 
        {
            steer = -1f;
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            steer = 1f;
        }
        float moveamount = move * translatevalue * Time.deltaTime;
        float steeramount = steer * rotatevalue * Time.deltaTime;
        transform.Rotate(0, 0, steeramount);
        transform.Translate(0, moveamount, 0);

    }
}
