using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField]
    private float speed;
    [SerializeField]
    private PlayerInput playerInput;
    //[SerializeField] private MeshRenderer meshRenderer;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (rb.GetComponent<Rigidbody2D>().gravityScale == 0f)
        {
            rb.MovePosition(transform.position + (direction * speed * Time.deltaTime));
        }
        else
        {
            rb.AddForce(direction.normalized * 15f);
        }
       
    }

    public void OnMove(InputValue val)
    {
        var dir = val.Get<Vector2>();
        direction = new Vector2(dir.x,dir.y);
    }

}
