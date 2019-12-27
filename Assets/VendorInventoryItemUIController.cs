using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Cooking {
    public class VendorInventoryItemUIController : MonoBehaviour
    {
        public Text titleText;
        public Text quantityText;
        public Image icon;
        public void SetItem(IngredientObject ingredient, int quantity, int age) {
            titleText.text = ingredient.name;
            quantityText.text = quantity.ToString();
            icon.sprite = ingredient.icon;
            icon.color = ingredient.GetColorByAge(age);
        }
    }
}

