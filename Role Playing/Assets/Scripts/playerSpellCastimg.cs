using UnityEngine;

public class playerSpellCastimg : MonoBehaviour
{
    public int currentSpell;
    public string[] spellName;
    public Material[] gemColor;
    public Renderer gemRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      for(int i =0; i < gemRenderer.materials.Length; i++)
        {
            print("at index " + i +" material " + gemRenderer.materials[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwapSpell(int newSpell)
    {
        currentSpell = newSpell;
        print(spellName[currentSpell]);
        gemRenderer.materials[1]=gemColor[currentSpell];

    }
}
