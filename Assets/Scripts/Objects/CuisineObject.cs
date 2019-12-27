using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cooking {
    [CreateAssetMenu(fileName = "Cuisine", menuName = "Cooking/Cuisine")]
    public class CuisineObject : ScriptableObject
    {
        public string description;
        public CuisineObject[] children;
    }
}

