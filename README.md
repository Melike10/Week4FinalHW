# Week4FinalHW - C# .NET Core Console Application

This project is a C# .NET Core Console Application created as part of the Patika Dev+ Week 4 final homework. The application demonstrates the use of abstraction, encapsulation, inheritance, and polymorphism through the implementation of a `BaseMachine` class and its derived classes: `Computer` and `Phone`. The `Program` class serves as the entry point for user interaction.

## Classes Overview

### 1. BaseMachine (Abstract Class)

#### Description:
The `BaseMachine` class is an abstract class that defines the common properties and methods for different types of machines. It provides a base for the `Computer` and `Phone` classes to inherit from, ensuring that these derived classes share certain characteristics.

#### Properties:
- **ProductionDate (DateTime)**: Automatically set to the current date and time when a machine is created.
- **SerialNumber (int)**: A unique identifier for the machine.
- **Description (string)**: A brief description of the machine.
- **Name (string)**: The name of the machine.
- **OperatingSystem (string)**: The operating system that the machine uses.

#### Methods:
- **virtual void WriteInfo()**: Displays the machine's details. This method can be overridden by derived classes to add or modify the displayed information.
- **abstract void GetNameMachine()**: Must be implemented by derived classes to display the name of the machine.

### 2. Computer (Derived Class)

#### Description:
The `Computer` class inherits from `BaseMachine` and represents a computer. It includes additional properties specific to computers, such as the number of USB ports and whether the computer has Bluetooth functionality.

#### Properties:
- **UsbEntryNum (int)**: The number of USB ports on the computer. This property is encapsulated to only allow values of 2 or 4.
- **HasBluetooth (bool)**: Indicates whether the computer has Bluetooth capability.

#### Methods:
- **override void GetNameMachine()**: Displays the name of the computer.
- **override void WriteInfo()**: Extends the base `WriteInfo` method to include USB port count and Bluetooth capability.

### 3. Phone (Derived Class)

#### Description:
The `Phone` class inherits from `BaseMachine` and represents a mobile phone. It adds a property to indicate whether the phone is licensed in Turkey.

#### Properties:
- **IsTrLicence (bool)**: Indicates whether the phone has a Turkish license.

#### Methods:
- **override void GetNameMachine()**: Displays the name of the phone.
- **override void WriteInfo()**: Extends the base `WriteInfo` method to include the Turkish license status.

### 4. Program (Main Entry Point)

#### Description:
The `Program` class contains the `Main` method, which is the entry point of the console application. It interacts with the user, allowing them to create instances of `Computer` or `Phone` by entering relevant details.

#### Methods:
- **static void Main(string[] args)**: The main method that drives the application. It guides the user through the process of selecting a machine type, entering details, and displaying the machine information. The loop continues until the user decides to exit.
- **static (string, string, int, string) UrunVariables(int urun)**: A helper method that collects common information required for creating `Computer` or `Phone` objects.

## Execution Flow

1. **User Selection**: The user is prompted to choose whether they want to create a `Computer` or `Phone`.
2. **Data Input**: Depending on the selection, the program gathers relevant data (e.g., USB ports, Bluetooth, Turkish license).
3. **Object Instantiation**: The program creates an instance of the selected machine (`Computer` or `Phone`).
4. **Information Display**: The program calls the methods to display the details of the created machine.
5. **Repeat or Exit**: The user can choose to create another machine or exit the program.

## Tech

This project is built as a C# .NET Core Console Application.

