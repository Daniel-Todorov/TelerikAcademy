//Create a TODO list with the following UI controls 
// Form input for new Item 
// Button for adding the new Item 
// Button for deleting some item 
// Show and Hide Button

//Not so pretty but still working solition.
window.onload = function mainFunction() {
    var newTaskButton = document.getElementById('new-task-button'),
        showListButton = document.getElementById('show-list-button'),
        hideListButton = document.getElementById('hide-list-button');

    newTaskButton.addEventListener('click', addNewTask);
    showListButton.addEventListener('click', showList);
    hideListButton.addEventListener('click', hideList);
}

function addNewTask(event) {
    var newTaskText = document.getElementById('new-task').value;
        
    if (newTaskText.length > 0) {
        var task = document.createElement('span'),
            button = document.createElement('button'),
            list = document.createElement('li'),
            todoList = document.getElementById('todo-list');
        task.textContent = newTaskText;
        console.dir(task)
        button.textContent = 'Delete';
        button.addEventListener('click', deleteTask);
        list.appendChild(task);
        list.appendChild(button);
        todoList.appendChild(list);
        
    }
}

function deleteTask(event) {
    var itemToDelete = event.target.parentNode;
    itemToDelete.parentNode.removeChild(itemToDelete);
}

function showList() {
    var todoList = document.getElementById('todo-list');
    todoList.style.display = 'block';
}

function hideList(event) {
    var todoList = document.getElementById('todo-list');
    todoList.style.display = 'none';
}