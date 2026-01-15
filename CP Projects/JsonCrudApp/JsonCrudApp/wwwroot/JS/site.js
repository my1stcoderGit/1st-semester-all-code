// API Base URL - points to our backend
const API_BASE_URL = '/api/items';

// DOM Elements - Get references to HTML elements
const elements = {
    itemId: document.getElementById('item-id'),
    itemName: document.getElementById('item-name'),
    itemDescription: document.getElementById('item-description'),
    itemPrice: document.getElementById('item-price'),
    saveButton: document.getElementById('save-button'),
    cancelButton: document.getElementById('cancel-button'),
    clearButton: document.getElementById('clear-button'),
    refreshButton: document.getElementById('refresh-button'),
    searchInput: document.getElementById('search-input'),
    itemsContainer: document.getElementById('items-container'),
    loading: document.getElementById('loading'),
    noItems: document.getElementById('no-items'),
    messageArea: document.getElementById('message-area'),
    nameError: document.getElementById('name-error'),
    priceError: document.getElementById('price-error')
};

// Current state
let isEditing = false;
let allItems = [];

// ==================== EVENT LISTENERS ====================

// When page loads, initialize everything
document.addEventListener('DOMContentLoaded', function () {
    console.log('Page loaded, initializing app...');

    // Load items from API
    loadItems();

    // Setup event listeners for buttons
    setupEventListeners();

    // Show welcome message
    showMessage('Welcome to Item Manager! Start by adding your first item.', 'success');
});

function setupEventListeners() {
    // Save button click
    elements.saveButton.addEventListener('click', saveItem);

    // Cancel button click
    elements.cancelButton.addEventListener('click', cancelEdit);

    // Clear form button click
    elements.clearButton.addEventListener('click', clearForm);

    // Refresh button click
    elements.refreshButton.addEventListener('click', loadItems);

    // Search input typing
    elements.searchInput.addEventListener('input', filterItems);

    // Enter key in form fields
    elements.itemName.addEventListener('keypress', function (e) {
        if (e.key === 'Enter') saveItem();
    });

    elements.itemPrice.addEventListener('keypress', function (e) {
        if (e.key === 'Enter') saveItem();
    });
}

// ==================== FORM VALIDATION ====================

function validateForm() {
    let isValid = true;

    // Clear previous errors
    elements.nameError.textContent = '';
    elements.priceError.textContent = '';

    // Validate name
    if (!elements.itemName.value.trim()) {
        elements.nameError.textContent = 'Item name is required';
        elements.itemName.style.borderColor = '#dc3545';
        isValid = false;
    } else {
        elements.itemName.style.borderColor = '#dee2e6';
    }

    // Validate price
    const price = parseFloat(elements.itemPrice.value);
    if (!elements.itemPrice.value || isNaN(price) || price < 0) {
        elements.priceError.textContent = 'Valid price is required';
        elements.itemPrice.style.borderColor = '#dc3545';
        isValid = false;
    } else {
        elements.itemPrice.style.borderColor = '#dee2e6';
    }

    return isValid;
}

// ==================== API FUNCTIONS ====================

async function loadItems() {
    try {
        // Show loading indicator
        elements.loading.style.display = 'flex';
        elements.itemsContainer.innerHTML = '';

        console.log('Loading items from API...');

        // Fetch items from API
        const response = await fetch(API_BASE_URL);

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        allItems = await response.json();
        console.log(`Loaded ${allItems.length} items`);

        // Display items
        displayItems(allItems);

        // Hide loading indicator
        elements.loading.style.display = 'none';

    } catch (error) {
        console.error('Error loading items:', error);
        showMessage('Error loading items. Please check if the server is running.', 'error');
        elements.loading.style.display = 'none';
    }
}

async function saveItem() {
    // Validate form first
    if (!validateForm()) {
        showMessage('Please fix the errors in the form.', 'error');
        return;
    }

    try {
        // Create item object from form data
        const item = {
            id: elements.itemId.value ? parseInt(elements.itemId.value) : 0,
            name: elements.itemName.value.trim(),
            description: elements.itemDescription.value.trim(),
            price: parseFloat(elements.itemPrice.value)
        };

        let response;
        let method;
        let url;

        if (isEditing) {
            // Update existing item
            method = 'PUT';
            url = `${API_BASE_URL}/${item.id}`;
            console.log(`Updating item with ID: ${item.id}`);
        } else {
            // Create new item
            method = 'POST';
            url = API_BASE_URL;
            console.log('Creating new item');
        }

        // Send request to API
        response = await fetch(url, {
            method: method,
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(item)
        });

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        // Show success message
        const action = isEditing ? 'updated' : 'created';
        showMessage(`Item ${action} successfully!`, 'success');

        // Reset form and reload items
        clearForm();
        loadItems();

    } catch (error) {
        console.error('Error saving item:', error);
        showMessage('Error saving item. Please try again.', 'error');
    }
}

async function deleteItem(id) {
    // Confirm deletion
    if (!confirm('Are you sure you want to delete this item?')) {
        return;
    }

    try {
        console.log(`Deleting item with ID: ${id}`);

        const response = await fetch(`${API_BASE_URL}/${id}`, {
            method: 'DELETE'
        });

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        // Show success message
        showMessage('Item deleted successfully!', 'success');

        // Reload items
        loadItems();

    } catch (error) {
        console.error('Error deleting item:', error);
        showMessage('Error deleting item. Please try again.', 'error');
    }
}

// ==================== UI FUNCTIONS ====================

function displayItems(items) {
    elements.itemsContainer.innerHTML = '';

    if (items.length === 0) {
        elements.noItems.style.display = 'block';
        return;
    }

    elements.noItems.style.display = 'none';

    // Sort items by ID (newest first)
    items.sort((a, b) => b.id - a.id);

    // Create HTML for each item
    items.forEach(item => {
        const itemElement = createItemElement(item);
        elements.itemsContainer.appendChild(itemElement);
    });
}

function createItemElement(item) {
    const div = document.createElement('div');
    div.className = 'item-card';
    div.innerHTML = `
        <div class="item-header">
            <h3 class="item-title">${escapeHtml(item.name)}</h3>
            <span class="item-price">$${item.price.toFixed(2)}</span>
        </div>
        <p class="item-description">${escapeHtml(item.description) || 'No description'}</p>
        <div class="item-footer">
            <div class="item-date">
                <i class="fas fa-calendar"></i> Created: ${formatDate(item.createdDate)}
            </div>
            <div class="item-actions">
                <button class="btn btn-edit" onclick="editItem(${item.id})">
                    <i class="fas fa-edit"></i> Edit
                </button>
                <button class="btn btn-delete" onclick="deleteItem(${item.id})">
                    <i class="fas fa-trash"></i> Delete
                </button>
            </div>
        </div>
    `;
    return div;
}

function filterItems() {
    const searchTerm = elements.searchInput.value.toLowerCase().trim();

    if (!searchTerm) {
        // If search is empty, show all items
        displayItems(allItems);
        return;
    }

    // Filter items based on search term
    const filteredItems = allItems.filter(item =>
        item.name.toLowerCase().includes(searchTerm) ||
        item.description.toLowerCase().includes(searchTerm) ||
        item.price.toString().includes(searchTerm)
    );

    displayItems(filteredItems);
}

function editItem(id) {
    // Find the item to edit
    const itemToEdit = allItems.find(item => item.id === id);

    if (!itemToEdit) {
        showMessage('Item not found!', 'error');
        return;
    }

    console.log(`Editing item with ID: ${id}`);

    // Fill form with item data
    elements.itemId.value = itemToEdit.id;
    elements.itemName.value = itemToEdit.name;
    elements.itemDescription.value = itemToEdit.description;
    elements.itemPrice.value = itemToEdit.price;

    // Update UI for edit mode
    isEditing = true;
    elements.saveButton.innerHTML = '<i class="fas fa-save"></i> Update Item';
    elements.cancelButton.style.display = 'block';

    // Change form panel title
    document.querySelector('.form-panel h2').innerHTML = '<i class="fas fa-edit"></i> Edit Item';

    // Show message
    showMessage(`Editing item: ${itemToEdit.name}`, 'success');

    // Scroll to form
    document.querySelector('.form-panel').scrollIntoView({ behavior: 'smooth' });
}

function cancelEdit() {
    clearForm();
    showMessage('Edit cancelled.', 'info');
}

function clearForm() {
    // Clear form fields
    elements.itemId.value = '';
    elements.itemName.value = '';
    elements.itemDescription.value = '';
    elements.itemPrice.value = '';

    // Clear errors
    elements.nameError.textContent = '';
    elements.priceError.textContent = '';
    elements.itemName.style.borderColor = '#dee2e6';
    elements.itemPrice.style.borderColor = '#dee2e6';

    // Reset to add mode
    isEditing = false;
    elements.saveButton.innerHTML = '<i class="fas fa-save"></i> Save Item';
    elements.cancelButton.style.display = 'none';

    // Reset form panel title
    document.querySelector('.form-panel h2').innerHTML = '<i class="fas fa-edit"></i> Item Form';

    // Focus on first field
    elements.itemName.focus();
}

function showMessage(message, type) {
    // Set message and type
    elements.messageArea.textContent = message;
    elements.messageArea.className = `message-area ${type}`;

    // Auto-hide after 5 seconds (except errors)
    if (type !== 'error') {
        setTimeout(() => {
            elements.messageArea.style.display = 'none';
        }, 5000);
    }
}

// ==================== HELPER FUNCTIONS ====================

function escapeHtml(text) {
    // Prevent XSS attacks by escaping HTML
    const div = document.createElement('div');
    div.textContent = text;
    return div.innerHTML;
}

function formatDate(dateString) {
    const date = new Date(dateString);
    return date.toLocaleDateString('en-US', {
        year: 'numeric',
        month: 'short',
        day: 'numeric',
        hour: '2-digit',
        minute: '2-digit'
    });
}

// Make functions available globally (for onclick attributes)
window.editItem = editItem;
window.deleteItem = deleteItem;