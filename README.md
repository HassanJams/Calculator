# Simple Calculator - Windows Forms Application

## Overview
This project is a simple desktop calculator built using C# and Windows Forms in Visual Studio. It provides basic arithmetic operations and serves as an introduction to building graphical user interfaces (GUIs) using Windows Forms. The project emphasizes two key aspects:
1. **Building the Visual Components** - Using Visual Studio tools to create and configure a Windows Form GUI.
2. **Event Handling** - Implementing logic to handle user interactions and perform calculations.

## Features
- **Basic Arithmetic Operations:**
  - Addition (+)
  - Subtraction (-)
  - Multiplication (*)
  - Division (/) with error handling for division by zero
- **Error Handling:**
  - Prevents invalid inputs
  - Clears calculator state upon errors and notifies the user
- **GUI Design:**
  - Uses `TableLayoutPanel` for structured and resizable layout
  - Logical naming conventions for all controls
  - Clean and responsive user interface

## Technologies Used
- **Language:** C#
- **Framework:** .NET Windows Forms
- **IDE:** Visual Studio

## Installation & Setup
1. Clone or download the repository.
2. Open the project in Visual Studio.
3. Build and run the solution (`Ctrl + F5`).

## Usage
1. Enter numbers using the calculator buttons.
2. Click on an arithmetic operator (+, -, *, /).
3. Enter the second number and press `=` to get the result.
4. Use the `C` button to clear the calculator.

## File Structure
- **Main Form (`CalculatorForm.cs`)** - Contains the GUI layout and event handlers.
- **Logic Handler (`CalculatorLogic.cs`)** - Handles the calculations and error recovery.
- **Program Entry (`Program.cs`)** - Entry point of the application.
- **Resource Files (`*.resx`)** - Stores form configurations.

## Future Improvements
- Implement additional functions like square root and percentage.
- Support for keyboard input.
- Improved error messages and validation.
