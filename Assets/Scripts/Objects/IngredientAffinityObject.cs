using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking {

    public enum Affinity {
        Avoid,
        Good,
        Great,
        Amazing,
        Classic
    }
    public class IngredientAffinityObject : ScriptableObject
    {
        public IngredientObject ingredient;
        public Affinity affinity;
    }

}
