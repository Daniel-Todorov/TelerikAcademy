var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Visitor = (function (_super) {
    __extends(Visitor, _super);
    function Visitor(name, age) {
        _super.call(this, name, age);

        this.money = Math.floor(Math.random() * 1000);
    }
    Visitor.prototype.canPay = function (fee) {
        if (this.money >= fee) {
            return true;
        } else {
            return false;
        }
    };
    return Visitor;
})(Person);
//# sourceMappingURL=Visitor.js.map
