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
        ScoreUi.text = "Score : " + score.ToString();
        TimeUi.text = "Waktu Bermain: 0";
    }

    void Update()
    {
        timer = (int)Time.time;
        TimeUi.text = "Waktu Bermain: " + timer.ToString();
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
            ScoreUi.text = "Score: " + score.ToString();
            Destroy(other.gameObject);
        }
    }

}
