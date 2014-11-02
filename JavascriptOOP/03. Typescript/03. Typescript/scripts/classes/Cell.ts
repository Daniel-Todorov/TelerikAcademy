class Cell {
    dirtLevel: number;
    animals: Array<Animal>;

    constructor(animals: Array<Animal>) {
        this.dirtLevel = animals.length * 100;
        this.animals = animals;
    }
}