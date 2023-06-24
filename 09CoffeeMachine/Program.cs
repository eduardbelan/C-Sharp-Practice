using _09CoffeeMachine;
using System;
using System.Diagnostics.Contracts;

Coffeemachine coffeemachine = new Coffeemachine(waterlvl: 0, coffeelvl: 0, maxWaterlvl: 100, maxCoffeelvl: 50);

coffeemachine.ClearOrder();


// animation when water and coffee are refilled * DONE

// animation when coffee is brewed