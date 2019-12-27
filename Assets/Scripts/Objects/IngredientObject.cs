using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking {
  [CreateAssetMenu(fileName = "Ingredient", menuName = "Cooking/Ingredient")]
  public class IngredientObject : ScriptableObject
  {
    [TextArea]
    public string description;
    public Season[] seasons;
    public Taste[] tastes;
    public Function[] functions;
    [Range(0.1f, 0.9f)]
    public float weight = 0.5f;
    [Range(0.1f, 0.9f)]
    public float volume = 0.5f;
    public CuisineObject[] cuisines;
    public Technique[] techniques;
    public IngredientAffinityObject[] affinities;
    public IngredientObject[] children;
    public IngredientPartObject[] parts;
    [Header("Time until the ingredient ages a step")]
    public TimeIncrement ageIncrement = TimeIncrement.Hour;
    [Header("Total age increments until the ingredient is unusable")]
    public int maxViableAge = 1;
    public Gradient ageGradient;
    public Gradient cookingGradient;
    public Sprite icon;

    private int GetMaxAgeInMinutes() {
      return (int)ageIncrement * maxViableAge;
    }

    public bool IsDead(int age) {
      return age >= GetMaxAgeInMinutes();
    }

    public Color GetColorByAge(int age) {
      // age is in minutes
      Debug.Log(Mathf.InverseLerp(0f, GetMaxAgeInMinutes(), age));
      return ageGradient.Evaluate(Mathf.InverseLerp(0f, GetMaxAgeInMinutes(), age));

    
    }
  }


}

