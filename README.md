# Product and User Management Application

This is an application designed for viewing and managing lists of products and users.

## Functional Enhancements

### Validation of Products

1. **Price**: The price value must fall within the range of 0 and 100,000.
2. **Name**: This is a mandatory field.
3. **Description**: 
   - This field is not mandatory.
   - If provided, the length should be greater than 2 characters.
   - It should not be equal to the product's name but should start with the product's name.
4. **Type**: This field is an enumeration with values: *Toy, Technique, Clothes, Transport*. It is displayed as a SelectList on the views for editing and creating products to prevent the entry of incorrect values.

Upon clicking the "Save" button:
- If there are no validation errors, the product is saved and displayed in view (details) mode.
- In case of validation errors, they are displayed on the same page.

### Binding

1. **Edit Prices for Products of Chosen Category**:
   - Links to edit the prices of products are provided on the view with the list of products.
   - The view for editing prices displays the **Id, Name, and Price** of all products in the chosen category.
   - Price can be edited, while Id and Name are readonly.
   - Clicking on the "Save" button saves all the prices if there are no validation errors and displays errors if there are any.

2. **Add a New User with Query String**:
   - All fields on the creation form are readonly.
   - Fields are filled in only with parameters from the query string.
   - Upon clicking the "Save" button, the user is displayed in view mode.

These enhancements add validation for product attributes, the ability to edit prices for products of a chosen category, and a method to add new users via query strings.
