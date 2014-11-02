class CareTaker extends Person implements Cleaner {

    constructor(name: string, age: number) {
        super(name, age);
    }

    cleanCell(cell: Cell) {
        cell.dirtLevel -= 50;
    }
}