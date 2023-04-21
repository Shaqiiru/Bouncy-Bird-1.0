using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

   public float Force;
   private Rigidbody2D rb;
   private Animator anim;
  
   private int Points = 0;
   private int HighScorePoints;
   public Text ScoreText;
   public Text HighScoretext;
   public GameObject panel;
   public bool isPaused;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        HighScorePoints = PlayerPrefs.GetInt("HighScore", 0);
        panel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
        	ClickedOnMouse();
        }
        else
        {
        	anim.SetBool("Clicked", false);
        }

        if(Points > HighScorePoints)
        {
        	PlayerPrefs.SetInt("HighScore", Points);
        }

        HighScoretext.text = HighScorePoints.ToString();

        

    }

    void ClickedOnMouse()
    {
       	rb.velocity = Vector2.up * Force;
       	anim.SetBool("Clicked", true);
    }    
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
    	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.tag == "PipeScore")
    	{
    		Points = Points + 1;
    		ScoreText.text = Points.ToString();
    		
    	}
    }

    
}
