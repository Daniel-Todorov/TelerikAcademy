var Person = (function () {
    function Person(name, age) {
        this.name = name;
        this.age = age;
    }
    Person.prototype.feedAnimal = function (food, animal) {
        animal.hunger -= food.hungerPoints;
    };
    return Person;
})();
//# sourceMappingURL=Person.js.map
