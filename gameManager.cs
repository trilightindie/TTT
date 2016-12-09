using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class gameManager : MonoBehaviour {

    public Text Display;
    static int currentTurn = 1;
    public static bool gameOver;

    static Transform loc;
    public GameObject x;
    public GameObject o;
    int count = 0;

    void Update()
    {
        if (count == 9 || gameOver) Display.text = "GAME OVER";
        else if (!gameOver) Display.text = "It's Player " + currentTurn + "'s turn.";

        if (loc != null)
        {
            if (currentTurn == 1) Instantiate(x, loc.position, loc.rotation);
            else Instantiate(o, loc.position, loc.rotation);

            if (currentTurn == 1) { currentTurn = 2; }
            else { currentTurn = 1; }

            count += 1;

            loc = null;
        }
    }

    static void VictoryCheck()
    {

    }

    public static void EndTurn(Transform t)
    {
        loc = t;

        VictoryCheck();
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
        gameOver = false;
        currentTurn = 1;
    }
}
