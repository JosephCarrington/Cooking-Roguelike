using UnityEditor;
using UnityEngine;

namespace Cooking.Editor.UI {
    [CustomPropertyDrawer(typeof(IngredientInAisle))]
    public class InventoryAisleEditorUIE : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            
            var indent = EditorGUI.indentLevel;
            EditorGUI.indentLevel = 0;

            var ingredientRect = new Rect(position.x, position.y, 100, position.height);
            var chanceRect = new Rect(position.x + 105, position.y, 150, position.height);
            EditorGUI.PropertyField(ingredientRect, property.FindPropertyRelative("ingredient"), GUIContent.none);
            EditorGUI.Slider(chanceRect, property.FindPropertyRelative("chanceToSpawn"), 0.01f, 1f, GUIContent.none);

            EditorGUI.indentLevel = indent;
            EditorGUI.EndProperty();

        }
    }
}

