# Lab Assignment: MathEngine Using Delegates (C# Console Application)

## Problem Statement

Design and develop a **Console-Based Mathematical Engine Application** in C# that performs basic arithmetic operations using the concept of **Delegates**.

The system should allow the user to perform operations such as:
* ➕ Addition
* ➖ Subtraction
* ✖️ Multiplication
* ➗ Division

The application must be designed in a modular way using a **MathEngine class**, where all operations are implemented as methods and invoked using a **delegate mechanism**.

---

## Objective
The objective of this lab assignment is to:
* Understand and implement **Delegates in C#**
* Learn **method reference binding at runtime**
* Practice **decoupled architecture using function pointers concept**
* Build a simple **menu-driven console application**



## System Requirements
### 1. MathEngine Class
Create a class named `MathEngine` containing the following methods:
* `double Add(double a, double b)`
* `double Subtract(double a, double b)`
* `double Multiply(double a, double b)`
* `double Divide(double a, double b)`


### 2. Delegate Definition
Define a delegate that matches the signature of arithmetic methods:

```csharp
public delegate double MathOperation(double a, double b);
```
---

### 3. Functional Requirements
The application should:
1. Display a menu:
   ```
   1. Addition
   2. Subtraction
   3. Multiplication
   4. Division
   5. Exit
   ```

2. Accept user input for:
   * Choice of operation
   * Two numeric values

3. Bind the selected method dynamically using delegate

4. Execute the operation and display result
---

## Expected Output Example

```
===== Math Engine =====

Enter first number: 10
Enter second number: 5

Choose Operation:
1. Addition
2. Subtraction
3. Multiplication
4. Division

Enter choice: 1

Result: 15
```
## Constraints / Rules
* Must use **delegates (mandatory)**
* No direct method call for operations inside switch-case
* Each operation must be invoked via delegate reference
* Handle division by zero using validation

## Learning Outcomes

After completing this lab, students will understand:
* What is a delegate in C#
* How to pass methods as parameters
* Runtime method binding concept
* Clean separation of UI and business logic
* Basic error handling in console apps