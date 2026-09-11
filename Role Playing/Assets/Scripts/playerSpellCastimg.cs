using UnityEngine;

public class playerSpellCastimg : MonoBehaviour
{
    public int currentSpell;
    public SpellData[] spells;
    public ParticleSystem[] gemVFX;
    
    public Renderer staffRenderer;
    
    public Transform spellSpawn;
    public Animator staffAnim;
    public float currentMana;
    public float maxMana =10;
    public float manaRegen = 0.25f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SwapSpell(currentSpell);
        currentMana = maxMana;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentMana < maxMana)
        {
            
            currentMana += Time.deltaTime*manaRegen;
            
        }
        
        if (Input.GetMouseButtonDown(0) && currentMana >= spells[currentSpell].manaCost) 
        {
            Instantiate(spells[currentSpell].attackPrefab, spellSpawn.position,spellSpawn.rotation);
            staffAnim.SetTrigger("attack");
            currentMana -= spells[currentSpell].manaCost;
            print(currentMana);
        } 
    }
    public void SwapSpell(int newSpell)
    {
        currentSpell = newSpell;
        print(spells[currentSpell].spellName[currentSpell]);
        Material[] currentMaterials = staffRenderer.materials;
        currentMaterials[1] = spells[currentSpell].gemMaterial;
        staffRenderer.materials = currentMaterials;
        for (int i = 0; i < gemVFX.Length; i++)
        {
            gemVFX[i].Stop();
        }
      

        gemVFX[currentSpell].Play();
    }
}
