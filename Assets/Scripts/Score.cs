
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Transform player;
    public Text scoreboard;
    void Update()
    {

        scoreboard.text = player.position.z.ToString("0");

    }
}
