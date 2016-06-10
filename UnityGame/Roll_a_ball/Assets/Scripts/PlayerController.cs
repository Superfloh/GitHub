using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float speed;
    public Text countText;
    public Text winText;
    private int count = 0;

    // extra stuff
    public GameObject westWall;
    public GameObject hiddenGround;
    public GameObject hiddenTopWall;
    public GameObject hiddenBotWall;
    public GameObject hiddenLeftWall;
    public GameObject hiddenPickUps;




	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        updateText();
        winText.text = "";
        hiddenGround.SetActive(false);
        hiddenLeftWall.SetActive(false);
        hiddenBotWall.SetActive(false);
        hiddenTopWall.SetActive(false);
        hiddenPickUps.SetActive(false);

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

	}


    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            updateText();
        }


    }

    void updateText()
    {
        countText.text = "Count: " + count.ToString();
        if(count == 16)
        {
            winText.text = "Hasste gaaaaanz doll gemacht!";
            westWall.SetActive(false);
            hiddenGround.SetActive(true);
            hiddenLeftWall.SetActive(true);
            hiddenBotWall.SetActive(true);
            hiddenTopWall.SetActive(true);
            hiddenPickUps.SetActive(true);
        }
        if(count == 17)
        {
            winText.text = "Game clear!";
            countText.text = "Count: OVER 9000!" ;
        }
    }
}
