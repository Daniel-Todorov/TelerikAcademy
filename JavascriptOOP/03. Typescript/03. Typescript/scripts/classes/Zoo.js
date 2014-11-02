var Zoo = (function () {
    function Zoo() {
        this.visitors = [];
        this.careTakers = [];
        this.cells = [];
        this.fee = 99.99;
    }
    Zoo.prototype.addVisitor = function (visitor) {
        this.visitors.push(visitor);
    };

    Zoo.prototype.addCareTaker = function (careTaker) {
        this.careTakers.push(careTaker);
    };

    Zoo.prototype.addCell = function (cell) {
        this.cells.push(cell);
    };
    return Zoo;
})();
//# sourceMappingURL=Zoo.js.map
