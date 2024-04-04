// See https://aka.ms/new-console-template for more information


using SDP_Decorators.ConcreteComponent;
using SDP_Decorators.ConcreteDecorator;
using SDP_Decorators.Interfaces;

WeaponComponent gun = new Pistol(10);
//this is the decorator pattern in action
//it allows us to add new functionality to an object without altering its structure
gun = new Scope(gun, 5);
gun = new Black(gun);
gun = new Barrel(gun, 5);
//this could work really well with customizeable weapons in a game, for example
//might want to use this for a purely numbers based rpg, such as a jrpg or a kotor-like

Console.WriteLine(gun.Fire());