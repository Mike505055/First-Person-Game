using UnityEngine;

public class playerSpellCastimg : MonoBehaviour
{
    public int currentSpell;
    public string[] spellName;
    public ParticleSystem[] gemVFX;
    public Material[] gemColor;
    public Renderer staffRenderer;
    public GameObject spellAttackPrefab;
    public Transform gemAnchor;

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
            Instantiate(spellAttackPrefab, gemAnchor.position,gemAnchor.rotation);
        } 
    }
    public void SwapSpell(int newSpell)
    {
        currentSpell = newSpell;
        print(spellName[currentSpell]);
        Material[] currentMaterials = staffRenderer.materials;
        currentMaterials[1] = gemColor[currentSpell];
        staffRenderer.materials = currentMaterials;
        for (int i = 0; i < gemVFX.Length; i++)
        {
            gemVFX[i].Stop();
        }
      

        gemVFX[currentSpell].Play();
    }
}
