using System;
using UnityEngine;

namespace Cooking {
    [Serializable]
    public class IngredientInAisle {
        public IngredientObject ingredient;
        [Range(0f, 1f)]
        public float chanceToSpawn = 0.5f;
    }
    [CreateAssetMenu(fileName = "Aisle", menuName = "Cooking/Vendors/Aisle")]

    public class VendorAisleObject : ScriptableObject
    {
        [TextArea]
        public string description;
        public IngredientInAisle[] ingredients;
    }
}

