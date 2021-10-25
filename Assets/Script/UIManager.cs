using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public Text _timerText = null;
    private Text timerText { get { return _timerText; } set { timerText = value; } }

    

    public static UIManager instance { get; private set; } = null;
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        
    }


private void Update()
    {
        
    }
 public void SetTimer(float time)
    {
        timerText.text = "Timer " + time.ToString("F1");
    }
}
