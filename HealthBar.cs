using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject DyingEffectsPanel;

    public float maxHealth;
    public float minHealth;
    public float  currentHealth;
    public HealthBar healthBar;
    void Start()
    {
  
        currentHealth = PlayerManager.instance.CurrentHealth;
        maxHealth = PlayerManager.instance.MaxHealth;
        minHealth = PlayerManager.instance.MinHealth;
        healthBar.SetMaxHealth(maxHealth);
        DyingEffectsPanel.SetActive(false);
    }


    public void SetMaxHealth(float health)
    { 
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(float health)
    {
        slider.value = health;
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void Update()
    {
        if (slider.value <= 10f)
        {
            Die();
        }

        if(slider.value <= 30f)
        {
            DyingEffectsPanel.SetActive(true);
        }
    }
    
    public void Die()
    {
        SceneManager.LoadScene("DeadPanel");
    }
}
