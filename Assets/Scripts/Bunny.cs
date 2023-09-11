using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunny : MonoBehaviour
{
    public float speed, jumpspeed;
    public bool yerde;
    Rigidbody2D rb;
    Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * h * speed);
        anim.SetFloat("speed", Mathf.Abs(h));
        //horizantal yani h -1 ile 1 arasýnda deðer alýyor
        //animatorde 0.1 den büyüktür dediðimiz için mathf.abs ile - olan her sayýnýn iþaretini deðiþtiriyoruz.
        anim.SetBool("yerde", yerde);
        if (h > 0.1f)
        {
            transform.localScale = new Vector2(-0.6f, 0.6f);
        }

        if (h < 0.1f)
        {
            transform.localScale = new Vector2(0.6f, 0.6f);
        }
        //bu sekilde oyun baþladýðý anda sola dönüyor saða giderken yavaþlarken bile sola dönüyor

    }
}
