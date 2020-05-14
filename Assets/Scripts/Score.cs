using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Camera cam;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + (Mathf.Floor(cam.transform.position.y) * 10).ToString();
    }

}
