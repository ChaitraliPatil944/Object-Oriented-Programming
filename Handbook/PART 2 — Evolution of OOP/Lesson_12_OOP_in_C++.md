# Lesson 12 — OOP in C++

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Although Smalltalk introduced Object-Oriented Programming (OOP), it was **C++** that brought OOP into mainstream software development.

Developed by **Bjarne Stroustrup** in the early 1980s, C++ extended the C programming language by adding object-oriented features while retaining the speed and efficiency of C.

Because of this balance, C++ became one of the most influential programming languages in history.

---

# 2. Why Was C++ Created?

The C language was excellent for system programming but lacked features needed for building large, maintainable software.

Developers wanted:

- Better code organization
- Reusability
- Modularity
- Easier maintenance

Instead of creating a completely new language, Bjarne Stroustrup enhanced C with OOP concepts.

---

# 3. Evolution

```text
C
 │
 ▼
C with Classes
 │
 ▼
C++
 │
 ▼
Modern C++
```

Originally, C++ was called **"C with Classes."**

---

# 4. Major OOP Features in C++

C++ introduced:

- Classes
- Objects
- Constructors
- Destructors
- Encapsulation
- Inheritance
- Polymorphism
- Operator Overloading
- Function Overloading
- Templates

---

# 5. Class Example

```cpp
#include <iostream>
using namespace std;

class Car {

public:
    string brand;

    void start() {
        cout << "Car Started";
    }
};

int main() {

    Car car;
    car.brand = "BMW";
    car.start();
}
```

The class acts as a blueprint, and `car` is an object.

---

# 6. Constructor Example

```cpp
class Student {

public:

    string name;

    Student(string n) {
        name = n;
    }
};
```

Constructors initialize objects automatically.

---

# 7. Inheritance Example

```cpp
class Vehicle {

public:

    void start() {
        cout << "Vehicle Started";
    }
};

class Car : public Vehicle {

};
```

`Car` inherits the behavior of `Vehicle`.

---

# 8. Runtime Polymorphism

```cpp
class Animal {

public:

    virtual void sound() {
        cout << "Animal";
    }
};

class Dog : public Animal {

public:

    void sound() override {
        cout << "Bark";
    }
};
```

The `virtual` keyword enables runtime polymorphism.

---

# 9. Multiple Inheritance

Unlike Java, C++ supports multiple inheritance.

```cpp
class Printer {

};

class Scanner {

};

class AllInOne : public Printer, public Scanner {

};
```

While powerful, it can introduce ambiguity, leading to the famous **Diamond Problem**.

---

# 10. Comparison: C vs C++

| C | C++ |
|---|------|
| Procedural | Multi-paradigm |
| Functions | Classes + Functions |
| No Inheritance | Supports Inheritance |
| No Polymorphism | Supports Polymorphism |
| No Templates | Templates Available |

---

# 11. Advantages of C++

- High performance
- Object-oriented design
- Direct memory control
- Generic programming
- Efficient for system software

---

# 12. Limitations

- Complex syntax
- Manual memory management
- Pointer-related bugs
- Steeper learning curve

Java later addressed many of these issues through automatic garbage collection and a simplified object model.

---

# 13. Real-World Applications

C++ is widely used in:

- Operating Systems
- Game Engines
- Embedded Systems
- Browsers
- Database Engines
- High-Frequency Trading
- Graphics Software

---

# 14. Influence on Java

Java borrowed many ideas from C++:

- Class syntax
- Inheritance
- Polymorphism
- Access modifiers
- Constructors

However, Java removed:

- Pointer arithmetic
- Manual memory management
- Multiple inheritance of classes

This made Java safer and easier for enterprise development.

---

# Interview Questions

1. Who developed C++?
2. Why was C++ created?
3. Why was it originally called "C with Classes"?
4. What OOP features were introduced in C++?
5. Why does Java not support multiple inheritance of classes?

---

# Summary

C++ played a crucial role in making Object-Oriented Programming practical for real-world software development. By combining the efficiency of C with powerful OOP concepts such as classes, inheritance, and polymorphism, C++ influenced nearly every modern object-oriented language, including Java.
