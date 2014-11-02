class Visitor extends Person implements Payer {
    money: number;

    constructor(name: string, age: number) {
        super(name, age);

        this.money = Math.floor(Math.random() * 1000);
    }

    canPay(fee: number) {
        if (this.money >= fee) {
            return true;
        } else {
            return false;
        }
    }
}