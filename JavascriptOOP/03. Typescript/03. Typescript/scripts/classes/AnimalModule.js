var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Animals;
(function (Animals) {
    var Bear = (function (_super) {
        __extends(Bear, _super);
        function Bear(name, age) {
            _super.call(this, name, age);
        }
        return Bear;
    })(Animal);
    Animals.Bear = Bear;

    var Rabit = (function (_super) {
        __extends(Rabit, _super);
        function Rabit(name, age) {
            _super.call(this, name, age);
        }
        return Rabit;
    })(Animal);
    Animals.Rabit = Rabit;
    var Eagle = (function (_super) {
        __extends(Eagle, _super);
        function Eagle(name, age) {
            _super.call(this, name, age);
        }
        return Eagle;
    })(Animal);
    Animals.Eagle = Eagle;
    var Hippo = (function (_super) {
        __extends(Hippo, _super);
        function Hippo(name, age) {
            _super.call(this, name, age);
        }
        return Hippo;
    })(Animal);
    Animals.Hippo = Hippo;
    var Lion = (function (_super) {
        __extends(Lion, _super);
        function Lion(name, age) {
            _super.call(this, name, age);
        }
        return Lion;
    })(Animal);
    Animals.Lion = Lion;
})(Animals || (Animals = {}));
//# sourceMappingURL=AnimalModule.js.map
