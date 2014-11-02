define(['tech-store-models/item'], function (Item) {
    'use strict';
    var Store;

    Store = (function () {
        function Store(name) {
            if ((6 > name.length || name.length > 40) || typeof name !== 'string') {
                throw new RangeError('The name of the store must be a string with length between 6 and 30 characters!');
            }
            this.name = name;
            this._items = [];
        }

        Store.prototype.addItem = function (item) {
            if (!(item instanceof Item)) {
                throw new TypeError('The you can add only objects of type Item to the store!');
            }
            this._items.push(item);

            return this;
        };

        Store.prototype.getAll = function () {
            //returns a collection of all items, sorted alphabetically
            var itemsArray = this._items.slice();

            return sortAlphabetically(itemsArray);
        };

        Store.prototype.getSmartPhones = function () {
            //returns a collection of only the items in stock that have type 'smart-phone', sorted alphabetically by the name of the items
            var smartPhones = filterItemsByType(this._items.slice(), ['smart-phone']);

            return sortAlphabetically(smartPhones);
        };

        Store.prototype.getMobiles = function () {
            //returns a collection of only the items in stock that have type either 'smart-phone' or 'tablet', sorted alphabetically by the name of the items
            var mobiles = filterItemsByType(this._items.slice(), ['smart-phone', 'tablet']);

            return sortAlphabetically(mobiles);
        };

        Store.prototype.getComputers = function () {
            //returns a collection of only the items in stock that have type either 'pc' or 'notebook', sorted alphabetically by the name of the items
            var computers = filterItemsByType(this._items.slice(), ['pc', 'notebook']);

            return sortAlphabetically(computers);
        };

        Store.prototype.filterItemsByType = function (filterType) {
            //returns a collection of only the items in stock that have type equal to the given filterType (item.type === filterType), sorted alphabetically by the name of the items
            var itemsOfType = filterItemsByType(this._items.slice(), [filterType]);

            return sortAlphabetically(itemsOfType);
        };

        Store.prototype.filterItemsByPrice = function (options) {
            //returns a collection of only the items that have a price from the price range in the options parameter, sorted ascending by the price of the items. 
            //The options object is optional and have optional properties min and max. 
            //o	If min is missing, it should be considered as 0
            //o	If max is missing, it should be considered + 
            if (typeof options === 'undefined') {
                options = {
                    min: 0,
                    max: Infinity
                };
            }
            var itemsInStore = this._items.slice(),
                itemsNumber = itemsInStore.length,
                min = options.min || 0,
                max = options.max || Infinity,
                result = [];

            for (var i = 0; i < itemsNumber; i++) {
                if (min < itemsInStore[i].price && itemsInStore[i].price < max) {
                    result.push(itemsInStore[i]);
                }
            }

            result.sort(function (a, b) {
                return a.price > b.price ? 1 : -1;
            });

            return result;
        }

        Store.prototype.filterItemsByName = function (partOfName) {
            //returns a collection of only the items in stock that have a name containing partOfName, sorted alphabetically by the name of the items. 
            //The search should be performed case insensitive
            var itemsInStore = this._items.slice(),
                itemsNumber = itemsInStore.length,
                result = [];

            for (var i = 0; i < itemsNumber; i++) {
                if (itemsInStore[i].name.toLowerCase().indexOf(partOfName.toLowerCase()) >= 0) {
                    result.push(itemsInStore[i]);
                }
            }

            return sortAlphabetically(result);
        }

        Store.prototype.countItemsByType = function () {
            //returns an associative array that have as keys the types, that are of items in stock in the store, 
            //and values that are equal to the number of items with this type
            var itemsInStore = this._items.slice(),
                numberOfItemsInStore = itemsInStore.length,
                result = {};

            for (var i = 0; i < numberOfItemsInStore; i++) {
                if (typeof result[itemsInStore[i].type] === 'undefined') {
                    result[itemsInStore[i].type] = 1;
                } else {
                    result[itemsInStore[i].type]++;
                }
            }

            return result;
        }


        //Helper functions
        function filterItemsByType(arrayToLookInto, arrayOfTypes) {
            var itemsArray = arrayToLookInto.slice(),
                itemsCount = itemsArray.length,
                numberOfTypesNeeded = arrayOfTypes.length,
                result = [];

            for (var i = 0; i < numberOfTypesNeeded; i++) {
                for (var j = 0; j < itemsCount; j++) {
                    if (itemsArray[j].type === arrayOfTypes[i]) {
                        result.push(itemsArray[j]);
                    }
                }
            }

            return result;
        }

        function sortAlphabetically(array) {
            var alphabeticallySortedArray = array.sort(function (a, b) {
                return a.name.localeCompare(b.name);
            });

            return alphabeticallySortedArray;
        }

        return Store;
    }());

    return Store;
});