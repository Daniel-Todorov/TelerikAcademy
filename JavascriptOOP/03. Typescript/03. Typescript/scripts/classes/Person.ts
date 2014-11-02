class Person implements Feeder {
    name: string;
    age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }

    feedAnimal(food: Food, animal: Animal): void {
        animal.hunger -= food.hungerPoints;
    }
}