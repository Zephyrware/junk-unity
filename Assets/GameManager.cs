using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameObject Canvas;

    private void Awake()
    {
        Canvas = GameObject.Find("Canvas");
    }
}
