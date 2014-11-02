using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeAndTravel
{
    class UpdatedInteractionManager : InteractionManager
    {
        protected override Item CreateItem(string itemTypeString, string itemNameString, Location itemLocation, Item item)
        {
            switch (itemTypeString)
            {
                case "armor":
                    item = new Armor(itemNameString, itemLocation);
                    break;
                case "weapon":
                    item = new Weapon(itemNameString, itemLocation);
                    break;
                case "wood":
                    item = new Wood(itemNameString, itemLocation);
                    break;
                case "iron":
                    item = new Iron(itemNameString, itemLocation);
                    break;
                default:
                    break;
            }

            return item;
        }

        protected override Location CreateLocation(string locationTypeString, string locationName)
        {
            Location location = null;
            switch (locationTypeString)
            {
                case "town":
                    location = new Town(locationName);
                    break;
                case "mine":
                    location = new Mine(locationName);
                    break;
                case "forest":
                    location = new Forest(locationName);
                    break;
                default:
                    break;
            }
            return location;
        }

        protected override void HandlePersonCommand(string[] commandWords, Person actor)
        {
            switch (commandWords[1])
            {
                case "gather":
                    HandleGatherInteraction(actor, commandWords[2]);
                    break;
                case "craft":
                    HandleCraftInteraction(actor, commandWords[2], commandWords[3]);
                    break;
                case "drop":
                case "pickup":
                case "sell":
                case "buy":
                case "inventory":
                case "money":
                case "travel":
                    base.HandlePersonCommand(commandWords, actor);
                    break;
                default:
                    break;
            }
        }

        private void HandleGatherInteraction(Person actor, string itemName)
        {
            //Gathering means a Person takes an item from a special location
            //A Person should be able to gather from mines and from forests
            //A Person can gather from a forest only if he has a Weapon in his inventory
            //Gathering from a forests results in adding a Wood item in the Person’s inventory
            //A Person can gather from a mine only if he has an Armor in his inventory
            //Gathering from a mine results in adding an Iron item in the Person’s inventory
            //Syntax: Joro gather newItemName – gathers an item, naming it newItemName if the Person Joro is at a mine or forest, and respectively has an Armor or Weapon

            if (actor.Location.LocationType == LocationType.Forest && actor.ListInventory().Any(a => a.GetType() == typeof(Weapon)))
            {
                Wood a = new Wood(itemName);
                base.AddToPerson(actor, a);
                actor.AddToInventory(new Wood(itemName));
            }

            if (actor.Location.LocationType == LocationType.Mine && actor.ListInventory().Any(a => a.GetType() == typeof(Armor)))
            {
                Iron a = new Iron(itemName);
                base.AddToPerson(actor, a);
                actor.AddToInventory(new Iron(itemName));
            }
        }

        private void HandleCraftInteraction(Person actor, string itemToCraft, string itemName)
        {
            //A Person can craft items, provided he has some items in his inventory
            //A Person should be able to craft Weapons and Armor
            //Crafting an Armor requires that the Person has Iron in his inventory
            //Results in adding an Armor item in the Person’s inventory
            //Crafting a Weapon requires that the Person has Iron and Wood in his inventory
            //Syntax: Joro craft weapon/armor newItemName - gathers an item, naming it newItemName if the Person Joro has the necessary
            switch (itemToCraft)
            {
                case "armor":
                    if (actor.ListInventory().Any(a => a.GetType() == typeof(Iron)))
                    {
                        Armor armor = new Armor(itemName);
                        base.AddToPerson(actor, armor);
                        actor.AddToInventory(new Armor(itemName));
                    }
                    break;
                case "weapon":
                    if (actor.ListInventory().Any(a => a.GetType() == typeof(Iron)) && actor.ListInventory().Any(a => a.GetType() == typeof(Wood)))
                    {
                        Weapon weapon = new Weapon(itemName);
                        base.AddToPerson(actor, weapon);
                        actor.AddToInventory(new Weapon(itemName));
                    }
                    break;
                default:
                    break;
            }
        }

        protected override Person CreatePerson(string personTypeString, string personNameString, Location personLocation)
        {
            Person person = null;
            switch (personTypeString)
            {
                case "merchant":
                    person = new Merchant(personNameString, personLocation);
                    break;
                case "shopkeeper":
                    person = new Shopkeeper(personNameString, personLocation);
                    break;
                case "traveller":
                    person = new Traveller(personNameString, personLocation);
                    break;
                default:
                    break;
            }
            return person;
        }
    }
}
