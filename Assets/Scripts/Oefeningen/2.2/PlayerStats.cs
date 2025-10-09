using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //Tip: Met een header kun je titels plaatsen in de inspector
    [Header("Character Info")]
    public string playerName = "DragonSlayer";
    public int level = 1;
    public string characterClass = "Warrior";
    public int age = 26;
    public string characterCountry = "Norway";

    [Header("Combat Stats")]
    public int health = 100;
    public int maxHealth = 100;
    public int mana = 50;
    public int attack = 25;
    public int defense = 15;
    public float speed = 70.5f;
    public int charisma = 60;

    [Header("Game Progress")]
    public int experience = 0;
    public int gold = 150;
    public float playtimeHours = 2.5f;
    public bool hasCompletedTutorial = true;
    public string joinDate = "25 October 2011";
    public int friends = 0;

    [Header("Inventory")]
    public int healthPotions = 3;
    public int keys = 1;
    public string currentWeapon = "Iron Sword";
    public string currentShield = "Bronze Shield";
    public string currentRanged = "Level 1 Bow";

    void Start()
    {
        DisplayCharacterSheet();
    }

    void Update()
    {
        // Input om stats te updaten
        if (Input.GetKeyDown(KeyCode.L))
        {
            //Level UP!
            level++;
            maxHealth += 20;
            health = maxHealth; // Full heal bij level up
            attack += 5;
            defense += 3;
            mana += 10;

            Debug.Log("LEVEL UP! Now level " + level);
            Debug.Log("Stats increased!");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            //Use Health Potion
            if (healthPotions > 0 && health < maxHealth)
            {
                healthPotions--;
                health += 30;
                if (health > maxHealth) health = maxHealth;

                Debug.Log("Used health potion! Health: " + health + "/" + maxHealth);
                Debug.Log("Potions remaining: " + healthPotions);
            }
            else if (healthPotions <= 0)
            {
                Debug.Log("No health potions left!");
            }
            else
            {
                Debug.Log("Health is already full!");
            }
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            DisplayCharacterSheet();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerName = "Noob";
            level = 0;
            characterClass = "";
            age = 0;
            health = 0;
            attack = 0;
            defense = 0;
            mana = 0;
            charisma = 0;
            speed = 0f;
            experience = 0;
            maxHealth = 0;
            friends = 0;
            characterCountry = "";
            hasCompletedTutorial = false;
            currentRanged = "";
            currentShield = "";
            currentWeapon = "";
            healthPotions = 0;
            keys = 0;
            gold = 0;

            Debug.Log("Stats reset!");

        }
        //Reset Stats here when R is pressed!

    }

    private void DisplayCharacterSheet()
    {
        //Display Character Sheet
        Debug.Log("=== CHARACTER SHEET ===");
        Debug.Log("Name: " + playerName + " the " + characterClass);
        Debug.Log("Character age: " + age);
        Debug.Log("Level: " + level);
        Debug.Log("Health: " + health + "/" + maxHealth);
        Debug.Log("Mana: " + mana);
        Debug.Log("Speed: " + speed);
        Debug.Log("Charisma: " + charisma);
        Debug.Log("Attack: " + attack + " | Defense: " + defense);
        Debug.Log("Experience: " + experience + " XP");
        Debug.Log("Gold: " + gold + " coins");
        Debug.Log("Playtime: " + playtimeHours + " hours");
        Debug.Log("Current Weapon: " + currentWeapon);
        Debug.Log("Current shield: " + currentShield);
        Debug.Log("Current Ranged: " + currentRanged);
        Debug.Log("Items: " + healthPotions + " health potions, " + keys + " keys");
        Debug.Log("Tutorial Complete: " + hasCompletedTutorial);
        Debug.Log("Join date: " + joinDate);
        Debug.Log("Friends: " + friends);
        Debug.Log("Country: " + characterCountry);
        Debug.Log("========================");
    }
}