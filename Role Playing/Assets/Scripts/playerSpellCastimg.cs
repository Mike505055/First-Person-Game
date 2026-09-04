using UnityEngine;

public class playerSpellCastimg : MonoBehaviour
{
    public int currentSpell;
    public SpellData[] spells;
    public ParticleSystem[] gemVFX;
    
    public Renderer staffRenderer;
    
    public Transform spellSpawn;
    public Animator staffAnim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SwapSpell(currentSpell);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(spells[currentSpell].attackPrefab, spellSpawn.position,spellSpawn.rotation);
            staffAnim.SetTrigger("attack");
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
