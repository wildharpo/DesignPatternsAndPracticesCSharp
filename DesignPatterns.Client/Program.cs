// This application contains a collection of implemented design patterns based on those discussed in the book entitled 
// "Design Patterns: Elements of Reusable Object-Oriented Software" by the "Gang of Four" (Erich Gamma, Richard Helm,
// Ralph Johnson, and John Vlissides)

using DesignPatterns.Console.TestDrivers.Behavioral.ChainOfResponsibility;
using DesignPatterns.Console.TestDrivers.Behavioral.Command;
using DesignPatterns.Console.TestDrivers.Behavioral.Interpreter;
using DesignPatterns.Console.TestDrivers.Behavioral.Iterator;
using DesignPatterns.Console.TestDrivers.Structural.Composite;
using DesignPatterns.Console.TestDrivers.Structural.Facade;
using DesignPatterns.Console.TestDrivers.Structural.Flyweight;
using DesignPatterns.Console.TestDrivers.Structural.Proxy;

//// Creational Design Patterns Tests
//BuilderTestDriver.RunTest();
//FactoryTestDriver.RunTestWithExcelApplication();
//SingletonTestDriver.RunTest();

//// Structural Design Patterns Tests
//CompositeTestDriver.RunTest();
//FacadeTestDriver.RunTest();
//FlyweightTestDriver.RunTest();
//ProxyTestDriver.RunTest();

// Behavioral Design Patterns Tests
//ChainOfResponsibilityTestDriver.RunTest();
//CommandTestDriver.RunTest();
InterpreterTestDriver.RunTest();
//IteratorTestDriver.RunTest();