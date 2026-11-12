
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerMana : MonoBehaviour
{
    public int mana = 100;
    public TMP_Text manaText;
    public Animator animator;

    void Start()
    {
        manaText.text = "Mana: " + mana;
    }

    void Update()
    {
        manaText.text = "Mana: " + mana;
        UseMana();
    }

    void UseMana()
    {
        if (Keyboard.current != null &&
            Keyboard.current.rKey.wasPressedThisFrame && mana >= 10)
        {
            mana -= 10;
            animator.SetTrigger("magic");
        }
    }
}
