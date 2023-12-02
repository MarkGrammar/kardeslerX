using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Variables : MonoBehaviour
{
    public static float ShipHealth = 100;
    public static float Happiness = 100;

    public Text ShipHealthText;
    public Text HappinessText;

    public Button Attack;
    public Button Evade;
    public GameObject Panel;


    void Start()
    {

        Attack.onClick.AddListener(Combat);

        ShipHealthText.text = "Ship Health = " + ShipHealth;
        HappinessText.text = "Happiness = " + Happiness;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Add 10 to ShipHealth
            ShipHealth += 10;

            ShipHealthText.text = "Ship Health = " + ShipHealth;
            
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            // Add 10 to ShipHealth
            Happiness += 10;

            ShipHealthText.text = "Ship Health = " + ShipHealth;
            HappinessText.text = "Happiness = " + Happiness;

        }

        
    }

    

    
    void Evasion()
    {

        Happiness += 20;
        UpdateTexts();
        Panel.SetActive(false);



    }

    void Combat()
    {
        Happiness -= 20;
        ShipHealth -= 15;
        UpdateTexts();
        Panel.SetActive(false);

    }

    void UpdateTexts()
    {
        // Update the Text component with the Happiness value
        HappinessText.text = "Happiness: " + Happiness;
        ShipHealthText.text = "Ship Health = " + ShipHealth;
    }

}
