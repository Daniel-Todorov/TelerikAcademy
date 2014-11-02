var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var CareTaker = (function (_super) {
    __extends(CareTaker, _super);
    function CareTaker(name, age) {
        _super.call(this, name, age);
    }
    CareTaker.prototype.cleanCell = function (cell) {
        cell.dirtLevel -= 50;
    };
    return CareTaker;
})(Person);
//# sourceMappingURL=CareTaker.js.map
