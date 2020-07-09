using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform playerTransform;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = playerTransform.position.z.ToString("0");
    }
}
