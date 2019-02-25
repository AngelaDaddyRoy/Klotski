using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Game : MonoBehaviour
{
    List<Transform> buttons;
    void Start()
    {
        buttons = GameObject.Find("GameArea").GetComponentsInChildren<Transform>().OrderBy(x => x.name).ToList();
        buttons.Remove(GameObject.Find("GameArea").transform);

    }

    public void StartGame()
    {
        var randomArray = Tools.GetRandomUnrepeatArray(1, 8, 8);
        foreach (var item in randomArray)
        {
            Debug.Log(item);

        }
    }

    public void ResetGame()
    {

    }
}
