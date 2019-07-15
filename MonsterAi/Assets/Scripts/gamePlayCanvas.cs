using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class gamePlayCanvas : MonoBehaviour
{

    public static gamePlayCanvas instance;
    public GameObject directionalLight;
    public Monster[] monsters;
    public Text txtCandy;
    public Text winText;
    public string candyString;
    public int candyTotal = 4;
    public AudioSource music;
    private int candyFound = 0;

    // Use this for initialization
    void Awake()
    {
        updateCanvas();
        instance = this;
        winText.text = "You have found all the candy :^)";
    }
	void Start () {
	
	}
    public void updateCanvas()
    {
        candyString = "Candy " + candyFound.ToString() + "/" + candyTotal.ToString();
        txtCandy.text = candyString;
    }

    public void findPage()
    {
        candyFound++;
        updateCanvas();

        if(candyFound >= candyTotal)
        {
            directionalLight.SetActive(true);
            music.Stop();
            winText.gameObject.SetActive(true);
            for(int i = 0; i < monsters.GetLength(0);i++)
            {
                monsters[i].death();
            }
        }
    }
}
