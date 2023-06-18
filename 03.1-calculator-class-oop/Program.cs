//Erstellt erneut einen Taschenrechner.
//Nur diesmal soll die gesammte Logik und Berechnungen in die Klasse "Taschenrechner_Logik" verlagert werden.
//Sämtliche Berechnungen und das "Menü", sollen mit seperaten Methoden ausgeführt und aufgerufen werden.
//In der Program.cs soll dann nur eine Objektinitialisierung und ein Methodenaufruf stehen.

using _calculator_class_oop;

Calculator calculator = new Calculator();
calculator.RunCalculator();