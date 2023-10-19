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


   - All fields on the creation form are readonly.
   - Fields are filled in only with parameters from the query string.
   - Upon clicking the "Save" button, the user is displayed in view mode.

