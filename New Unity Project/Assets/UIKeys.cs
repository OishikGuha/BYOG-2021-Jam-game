using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIKeys : MonoBehaviour
{

    public Image WKey;
    public Image AKey;
    public Image SKey;
    public Image DKey;

    [Space]
    [Space]

    public Sprite WKey_Idle;
    public Sprite AKey_Idle;
    public Sprite SKey_Idle;
    public Sprite DKey_Idle;

    [Space]

    public Sprite WKey_Pressed;
    public Sprite AKey_Pressed;
    public Sprite SKey_Pressed;
    public Sprite DKey_Pressed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        KeyPresser();
    }

    public void KeyPresser()
    {
        if(Input.GetKey(KeyCode.W))
            WKey.sprite = WKey_Pressed;
        else
            WKey.sprite = WKey_Idle;

        if(Input.GetKey(KeyCode.A))
            AKey.sprite = AKey_Pressed;
        else
            AKey.sprite = AKey_Idle;

        if(Input.GetKey(KeyCode.S))
            SKey.sprite = SKey_Pressed;
        else
            SKey.sprite = SKey_Idle;

        if(Input.GetKey(KeyCode.D))
            DKey.sprite = DKey_Pressed;
        else
            DKey.sprite = DKey_Idle;


    }
}
