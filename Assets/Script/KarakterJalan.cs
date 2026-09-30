using UnityEngine;

public class KarakterJalan : MonoBehaviour
{   
    [SerializeField]
    public float moveSpeed = 5f;
    private float inputHorizontal;
    private float inputVertical;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
      
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");
        
    }

    void FixedUpdate() 
    {
        Vector3 movement = new Vector3(inputHorizontal, 0f, inputVertical);
        transform.Translate(movement * moveSpeed * Time.deltaTime); 
    }
}
