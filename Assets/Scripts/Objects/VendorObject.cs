using System;
using UnityEngine;



namespace Cooking {
    [CreateAssetMenu(fileName = "Vendor", menuName = "Cooking/Vendor")]

    public class VendorObject : ScriptableObject
    {
        [TextArea]
        public string description;
        public VendorAisleObject[] aisles;        
    }
}

