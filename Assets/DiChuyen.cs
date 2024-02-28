using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiChuyen : MonoBehaviour
{
    public Rigidbody2D rb;
    public float tocDo = 6;
    public float traiPhai;
    public Animator anim;
    public float do_Cao;

 

 

    // Start is called before the first frame update
    public bool isFacingRight = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        traiPhai = Input.GetAxis("Horizontal");
        // A =-1, 0 , D=1
        rb.velocity = new Vector2(tocDo * traiPhai, rb.velocity.y);

        if (isFacingRight ==true && traiPhai == -1)
        {
            transform.localScale = new Vector3(-1,1,1);
            isFacingRight = false;
        }
        if(isFacingRight ==false && traiPhai == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isFacingRight = true;
        }
        //Animator
        anim.SetFloat("dichuyen",Mathf.Abs(traiPhai));
        if (Input.GetMouseButtonDown(0))
        {
            anim.SetTrigger("Tancong");
        }
        //Nhay 

        if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * do_Cao, ForceMode2D.Impulse);
        }
    }

}
