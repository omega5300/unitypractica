using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    //variables para mover a player
    public float Fuerza;
    private Rigidbody RB;

    //variables UI
    public Text txtScore;
    private int Score;
    public Button BtnRestart;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        RB = this.gameObject.GetComponent<Rigidbody> ();
        BtnRestart.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        float H = Input.GetAxis("Horizontal");
        float V = Input.GetAxis("Vertical");
        Vector3 Mivector = new Vector3 (H,0,V);
        RB.AddForce (Mivector * Fuerza* Time.deltaTime);

    }

    //method ontrigger
    void OnTriggerEnter(Collider Other)
    {
        if (Other.gameObject.tag == "Coin")
        {
            Score = Score + 1;
            txtScore.text = $"Puntaje: {Score}";
            Other.gameObject.SetActive(false);
            if (Score >= 12)
            {
                txtScore.text = "I WIN";
                BtnRestart.gameObject.SetActive(true);
                Time.timeScale = 0;
            }
        }

        if (Other.gameObject.tag == "Dano")
        {
            txtScore.text = "you lose";
            BtnRestart.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    } 

}
