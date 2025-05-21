using ProjectArchitectureBase.Event;
using ProjectArchitectureBase.Variables;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    public VoidEvent onLevelWin;
    public StringEvent Fire;
    public IntVariable health;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onLevelWin.Raise();
            Fire.Raise("You Fail");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            health.Value = 4;
        }
    }
    public void OnLevelWin()
    {
        Debug.Log("LevelWin");
    }
}
