using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public static GameControllerScript gameController;
    public bool swipeDirection;
    public bool canSwipe = true;
    public bool firstTimeInfoScreen = true;

    private void Awake()
    {
        if (gameController != null)
        {
            Destroy(this);
        }
        gameController = this;
        DontDestroyOnLoad(this);
    }
}
