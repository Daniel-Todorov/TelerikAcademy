function createImagesPreviewer(selector, items) {
    var container = document.querySelector(selector),
        previewContainer = document.createElement('div'),
        leftSideContainer = document.createElement('div'),
        rightSideContainer = document.createElement('div'),
        selectedItemTitle = document.createElement('h1'),
        selectedItemImage = document.createElement('img'),
        inputPretext = document.createElement('div'),
        input = document.createElement('input');

    //------------------- Left Side --------------------

    //selectedItemTitle
    selectedItemTitle.style.boxSizing = 'border-box';
    selectedItemTitle.style.width = '100%';
    selectedItemTitle.style.textAlign = 'center';
    selectedItemTitle.style.paddingTop = '15px';
    selectedItemTitle.innerText = items[0].title;
    selectedItemTitle.className = 'selectedItemTitle';

    //selectedItemImage
    selectedItemImage.style.boxSizing = 'border-box'
    selectedItemImage.style.width = '90%';
    selectedItemImage.style.borderRadius = '20px';
    selectedItemImage.style.margin = '0 5%'
    selectedItemImage.src = items[0].url;
    selectedItemImage.className = 'selectedItemImage';

    //leftSideContainer
    //leftSideContainer.style.backgroundColor = 'green'
    leftSideContainer.style.width = '70%';
    leftSideContainer.style.height = '100%';
    leftSideContainer.style.display = 'inline-block';
    leftSideContainer.style.verticalAlign = 'top';

    leftSideContainer.appendChild(selectedItemTitle);
    leftSideContainer.appendChild(selectedItemImage);

    //------------------- Right Side --------------------

    //input
    //input.style.backgroundColor = 'gray'
    input.style.width = '90%'
    input.style.border = '1px solid black'

    //inputPretext
    //inputPretext.style.backgroundColor = 'yellow'
    inputPretext.style.width = '100%';
    inputPretext.style.textAlign = 'center';
    inputPretext.innerText = 'Filter';

    //rightSideContainer
    //rightSideContainer.style.backgroundColor = 'purple';
    rightSideContainer.style.width = '30%';
    rightSideContainer.style.height = '100%';
    rightSideContainer.style.display = 'inline-block';
    rightSideContainer.style.textAlign = 'center';
    rightSideContainer.style.overflowY = 'scroll';
    rightSideContainer.className = 'rightSideContainer';

    rightSideContainer.appendChild(inputPretext);
    rightSideContainer.appendChild(input);

    //------------------- Container Side --------------------

    //previewContainer
    previewContainer.style.width = '540px';
    previewContainer.style.height = '380px';

    previewContainer.appendChild(leftSideContainer);
    previewContainer.appendChild(rightSideContainer);

    //Selector
    container.appendChild(previewContainer);

    displayItems('', items, rightSideContainer);

    //input
    input.type = 'text';
    input.addEventListener('keyup', function (event) {
        var rightSideItems = document.querySelectorAll('.rightSideItem'),
            searchTerm = event.target.value;

        for (var i = 0; i < rightSideItems.length; i++) {
            rightSideItems[i].parentNode.removeChild(rightSideItems[i]);
        }

        displayItems(searchTerm, items, rightSideContainer);
    });
}

function displayItems(searchTerm, items, rightSideContainer) {
    searchTerm = searchTerm.toLowerCase() || "";
    var itemContainer = document.createElement('div'),
        itemTitle = document.createElement('div'),
        itemImage = document.createElement('img');

    itemContainer.style.padding = '5px';
    itemContainer.className = 'rightSideItem';
    itemTitle.style.fontWeight = 'bold';
    itemImage.style.display = 'block';
    itemImage.style.width = '100%';
    itemImage.style.borderRadius = '5px';
    for (var i = 0; i < items.length; i++) {
        if (items[i].title.toLowerCase().indexOf(searchTerm) >= 0) {
            var newItemContainer = itemContainer.cloneNode(true),
                newItemTitle = itemTitle.cloneNode(true),
                newItemImage = itemImage.cloneNode(true);

            newItemTitle.innerText = items[i].title;
            newItemImage.src = items[i].url;

            newItemContainer.appendChild(newItemTitle);
            newItemContainer.appendChild(newItemImage);

            rightSideContainer.appendChild(newItemContainer);

            newItemImage.addEventListener('mouseover', function (event) {
                event.target.parentNode.style.backgroundColor = '#c9cbd2';
            });

            newItemImage.addEventListener('mouseout', function (event) {
                event.target.parentNode.style.backgroundColor = 'transparent';
            });

            newItemImage.addEventListener('click', changeSelectedItems);
        }
    }
}

function changeSelectedItems(event) {
    var selectedItemTitle = document.querySelector('.selectedItemTitle'),
        selectedItemImage = document.querySelector('.selectedItemImage'),
        newTitle = event.target.previousSibling.innerText,
        newImage = event.target.src;

    selectedItemTitle.innerText = newTitle;
    selectedItemImage.src = newImage;
}