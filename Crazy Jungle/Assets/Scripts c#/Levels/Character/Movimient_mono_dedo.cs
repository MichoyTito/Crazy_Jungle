using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimient_mono_dedo : MonoBehaviour
{
    private Vector2 pos_dedo;
    private Camera cam;
    private Transform transform;
    private Rigidbody2D rb;
    [SerializeField]
    private float velocidad_lateral=1;

    // Start is called before the first frame update
    void Start()
    {
        cam = FindObjectOfType<Camera>();
        transform = this.GetComponent<Transform>();
        rb = this.GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch toque = Input.touches[0];
            if (toque.phase == TouchPhase.Stationary|| toque.phase == TouchPhase.Moved)
            {
                pos_dedo = toque.position;
                float pos_x_cam = cam.ScreenToWorldPoint(pos_dedo).x;
                rb.velocity = (Vector2.right*(pos_x_cam-transform.position.x)*velocidad_lateral);
            }





        }
        else
        {
            rb.velocity = rb.velocity / 1.5f;
        }

    





        
    }
}
