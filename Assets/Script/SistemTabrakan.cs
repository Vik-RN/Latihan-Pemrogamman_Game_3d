using UnityEngine;
using TMPro;

public class SistemTabrakan : MonoBehaviour
{
    public int score = 0;
    public int timer;
    public TMP_Text ScoreUi;
    public TMP_Text TimeUi;


    void Start()
    {
        
    }

    void Update()
    {
        timer = ((int)Time.time);
        TimeUi.text = score.ToString();

    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Enemy")
        {
            Debug.Log("Kamu masuk collision musuh");
        }

        if(other.gameObject.tag=="Item")
        {
            score +=1;
            ScoreUi.text = score.ToString();
            Destroy(this);
        }
    }

}
