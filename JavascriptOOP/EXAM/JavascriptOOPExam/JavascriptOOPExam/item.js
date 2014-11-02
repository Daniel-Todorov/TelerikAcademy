define(function () {
    'use strict';
    var Item,
        itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

    Item = (function () {
        function Item(type, name, price) {
            if (itemTypes.indexOf(type) < 0) {
                throw new TypeError("Item type can be only 'accessory', 'smart-phone', 'notebook', 'pc' or 'tablet'!")
            }
            this.type = type;


            if ((6 > name.length || name.length > 40) || typeof name !== 'string') {
                throw new RangeError('The name of the item must be a string between 6 and 30-characters-long!')
            }
            this.name = name;

            if (typeof price !== 'number') {
                throw new TypeError('Price must be a decimal floating-point number!')
            }
            this.price = price;
        }

        return Item;
    })();

    return Item;
});