using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking {
    [CreateAssetMenu(fileName = "IngredientPart", menuName = "Cooking/Ingredient/Part")]

    public class IngredientPartObject : ScriptableObject
    {
        private IngredientObject parentObject;
        public string description;
    }
}
