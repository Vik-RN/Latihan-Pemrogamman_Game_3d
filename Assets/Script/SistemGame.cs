using UnityEngine;

public class SistemGame : MonoBehaviour
{
    void Awake()
    {
        Debug.Log("Sistem sedang disiapkan");
    }

    void Start()
    {
        for (int i = 1; i <= 5; i++)
        {
            Debug.Log("Membuat Rintangan" + i);
        }
    }

    void Update()
    {
        if (transform.position.y < 0)
        {
            Debug.Log("Kamu Kalah");
        }
    }
}


