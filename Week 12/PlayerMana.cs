using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Mana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    // Update is called once per frame
    void Update()
    {
        manaText.text = "Mana: " + mana;
        UseMana();
    }

    void UseMana()
    {
        if (Keyboard.current.rKey.wasPressedThisFrame && mana >= 10)
        {
            mana -= 10;
            animator.SetTrigger("magic");
        }
    }
}