class Zoo {
    private visitors: Array<Visitor>;
    private careTakers: Array<CareTaker>;
    private cells: Array<Cell>;
    private fee: number;

    constructor() {
        this.visitors = [];
        this.careTakers = [];
        this.cells = [];
        this.fee = 99.99;
    }

    addVisitor(visitor: Visitor) : void {
        this.visitors.push(visitor);
    }

    addCareTaker(careTaker: CareTaker): void {
        this.careTakers.push(careTaker);
    }

    addCell(cell: Cell): void {
        this.cells.push(cell);
    }
} 