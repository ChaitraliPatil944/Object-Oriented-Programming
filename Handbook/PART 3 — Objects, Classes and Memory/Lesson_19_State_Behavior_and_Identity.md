# Lesson 19 — State, Behavior and Identity

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Every object in Object-Oriented Programming is defined by three fundamental characteristics:

- **State**
- **Behavior**
- **Identity**

These three properties distinguish one object from another and explain how objects interact within a software system. Understanding them is essential because almost every interview on OOP eventually asks, "What are the characteristics of an object?"

---

# 2. State

The **state** of an object is the current value of its instance variables (fields).

State changes over time as the object is modified.

Example:

```java
class BankAccount {

    String accountHolder;
    double balance;
}
```

Creating an object:

```java
BankAccount account = new BankAccount();

account.accountHolder = "Alice";
account.balance = 5000;
```

Current state:

```text
accountHolder = Alice
balance = 5000
```

If money is deposited:

```java
account.balance += 1000;
```

New state:

```text
accountHolder = Alice
balance = 6000
```

The object is the same, but its **state** has changed.

---

# 3. Behavior

The **behavior** of an object is defined by its methods.

Methods describe what an object can do.

Example:

```java
class BankAccount {

    double balance;

    void deposit(double amount){
        balance += amount;
    }

    void withdraw(double amount){
        balance -= amount;
    }
}
```

Behaviors:

- deposit()
- withdraw()

These methods change the object's state.

---

# 4. Identity

The **identity** of an object is its unique existence in memory.

Two objects may contain identical data but still be different objects.

Example:

```java
Student s1 = new Student();
Student s2 = new Student();
```

Even if:

```text
rollNo = 101
name = Alice
```

for both objects, `s1` and `s2` have different identities because they occupy different memory locations.

---

# 5. Relationship Between State, Behavior and Identity

```text
                 Object
                    │
      ┌─────────────┼─────────────┐
      ▼             ▼             ▼
   State         Behavior      Identity
 (Variables)     (Methods)    (Memory)
```

These three characteristics together define every object.

---

# 6. Real-World Example

### Car

State:

```text
Brand = BMW
Color = Black
Speed = 80 km/h
Fuel = 35 L
```

Behavior:

```text
Start
Accelerate
Brake
Stop
Refuel
```

Identity:

```text
Vehicle Registration Number
VIN (Vehicle Identification Number)
```

Even if two cars have the same model and color, their identities are different.

---

# 7. Java Example

```java
class Car {

    String brand;
    int speed;

    void accelerate() {
        speed += 20;
    }

    void brake() {
        speed -= 20;
    }
}

public class Main {

    public static void main(String[] args) {

        Car car = new Car();

        car.brand = "BMW";
        car.speed = 60;

        car.accelerate();

        System.out.println(car.speed);
    }
}
```

Output:

```text
80
```

The behavior (`accelerate()`) changed the object's state (`speed`).

---

# 8. Memory View

```text
Stack

car
 |
 v

Heap

+---------------------------+
| Car Object                |
|---------------------------|
| brand = BMW               |
| speed = 80                |
+---------------------------+
```

The object's identity is tied to its unique memory location.

---

# 9. Enterprise Example

### E-Commerce Order

State:

- Order ID
- Customer
- Total Amount
- Status

Behavior:

- Place Order
- Cancel Order
- Generate Invoice
- Process Payment

Identity:

- Unique Order ID
- Specific object instance in memory

This mirrors how business entities are modeled in enterprise applications.

---

# 10. Common Misconceptions

❌ State and identity are the same.

❌ Methods are part of an object's state.

❌ Two objects with the same values are the same object.

Correct understanding:

- State is **what the object currently contains**.
- Behavior is **what the object can do**.
- Identity is **what uniquely distinguishes the object**.

---

# 11. Best Practices

- Keep object state consistent.
- Encapsulate state using private fields.
- Expose behavior through well-defined methods.
- Use identity carefully when comparing objects.

---

# 12. Interview Questions

1. What are the three characteristics of an object?
2. What is meant by an object's state?
3. How does behavior affect state?
4. What is object identity?
5. Can two objects have the same state but different identities?

---

# 13. Summary

Every object in Object-Oriented Programming is defined by its **state**, **behavior**, and **identity**. The state represents the current values of its fields, behavior is expressed through methods that operate on that state, and identity uniquely distinguishes one object from another. Together, these characteristics allow developers to model real-world entities accurately and build maintainable enterprise applications.
