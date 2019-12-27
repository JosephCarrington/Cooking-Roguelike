using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cooking {
    public class VendorInventoryUIController : MonoBehaviour
    {
        // Start is called before the first frame update
        public VendorObject testVendor;
        public Text vendorName;
        void Awake() {
            SetVendor(testVendor);
        }

        void SetVendor(VendorObject vendor) {
            vendorName.text = vendor.name;
        }
    }
}

