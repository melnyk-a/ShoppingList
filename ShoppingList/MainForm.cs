using System;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Handlers
        private void AddButton_Click(object sender, EventArgs e)
        {
            shoppingListCheckedListBox.Items.Add(
                new ShoppingItemWrapper(
                    new ShoppingItem(RemoveSpaces(addItemTextBox.Text))));
            addItemTextBox.Clear();
        }

        private void AddItemTextBox_TextChanged(object sender, EventArgs e)
        {
            addButton.Enabled = CanAdd(addItemTextBox.Text);
            UpdateUpDownButtonsState();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            shoppingListCheckedListBox.Items.RemoveAt(shoppingListCheckedListBox.SelectedIndex);
            UpdateUpDownButtonsState();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = shoppingListCheckedListBox.SelectedIndex;
            Swap(selectedIndex, selectedIndex + 1);
        }

        private void ShoppingListCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateUpDownButtonsState();
            UpdateDeleteButtonState();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = shoppingListCheckedListBox.SelectedIndex;
            Swap(selectedIndex, selectedIndex - 1);
        }
        #endregion

        private bool CanAdd(string value)
        {
            bool canAdd = !ContainOnlySpace(value);
            if (canAdd)
            {
                if (value.Length > 0)
                {
                    canAdd = !ContainInTextBox(
                        new ShoppingItemWrapper(
                            new ShoppingItem(RemoveSpaces(value))));
                }
            }
            return canAdd;
        }

        private bool ContainInTextBox(ShoppingItemWrapper item)
        {
            return shoppingListCheckedListBox.Items.Contains(item);
        }

        private bool ContainOnlySpace(string value)
        {
            return RemoveSpaces(value) == string.Empty;
        }

        private string RemoveSpaces(string value)
        {
            return value.Trim();
        }

        private void Swap(int firstIndex, int secondIndex)
        {
            CheckedListBox shoppingList = shoppingListCheckedListBox;

            object tempObject = shoppingList.Items[firstIndex];

            shoppingList.Items[firstIndex] = shoppingList.Items[secondIndex];
            shoppingList.Items[secondIndex] = tempObject;

            bool tempState = shoppingList.GetItemChecked(firstIndex);
            shoppingList.SetItemChecked(firstIndex, shoppingList.GetItemChecked(secondIndex));
            shoppingList.SetItemChecked(secondIndex, tempState);

            shoppingList.SelectedIndex = secondIndex;
        }

        private void UpdateDeleteButtonState()
        {
            int selectedIndex = shoppingListCheckedListBox.SelectedIndex;
            deleteButton.Enabled = selectedIndex != -1;
        }

        private void UpdateUpDownButtonsState()
        {
            int selectedIndex = shoppingListCheckedListBox.SelectedIndex;
            if (selectedIndex == -1)
            {
                upButton.Enabled = downButton.Enabled = false;
            }
            else
            {
                upButton.Enabled = selectedIndex != 0;
                downButton.Enabled = selectedIndex != shoppingListCheckedListBox.Items.Count - 1;
            }
        }
    }
}