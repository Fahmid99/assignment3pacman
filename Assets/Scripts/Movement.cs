using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour { 

    Vector2 endPoint = Vector2.zero;
    public float pacmanSpeed = 0.3f;
    void Start() {
        endPoint = transform.position;
    }

    void FixedUpdate() {
        Vector2 p = Vector2.MoveTowards(transform.position, endPoint, pacmanSpeed);
        GetComponent<Rigidbody2D>().MovePosition(p); 
         
         if ((Vector2)transform.position == endPoint) {
        if (Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
            endPoint = (Vector2)transform.position + Vector2.up;
        if (Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
            endPoint = (Vector2)transform.position + Vector2.right;
        if (Input.GetKey(KeyCode.DownArrow) && valid(-Vector2.up))
            endPoint = (Vector2)transform.position - Vector2.up;
        if (Input.GetKey(KeyCode.LeftArrow) && valid(-Vector2.right))
            endPoint = (Vector2)transform.position - Vector2.right;
            else 
            { 
                
            }
    }


    Vector2 dir = endPoint - (Vector2)transform.position;
    GetComponent<Animator>().SetFloat("DirX", dir.x);
    GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

    bool valid(Vector2 dir) {
      
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}
