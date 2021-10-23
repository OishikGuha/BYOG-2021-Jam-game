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
    public Image VKey;
    public Image Space;

    [Space]
    [Space]

    public Sprite WKey_Idle;
    public Sprite AKey_Idle;
    public Sprite SKey_Idle;
    public Sprite DKey_Idle;
    public Sprite VKey_Idle;
    public Sprite Space_Idle;

    [Space]

    public Sprite WKey_Pressed;
    public Sprite AKey_Pressed;
    public Sprite SKey_Pressed;
    public Sprite DKey_Pressed;
    public Sprite VKey_Pressed;
    public Sprite Space_Pressed;

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

        if(Input.GetKey(KeyCode.V))
            VKey.sprite = VKey_Pressed;
        else
            VKey.sprite = VKey_Idle;

        if(Input.GetKey(KeyCode.Space))
            Space.sprite = Space_Pressed;
        else
            Space.sprite = Space_Idle;
    }
}
