# Lesson 52 — Types of Inheritance

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Inheritance allows one class to derive properties and behavior from another class.

Depending on the relationship between classes, inheritance can be categorized into different types.

Although Object-Oriented Programming defines **five types of inheritance**, Java directly supports only some of them because of design considerations.

---

# 2. Types of Inheritance

The five commonly recognized types are:

1. Single Inheritance
2. Multilevel Inheritance
3. Hierarchical Inheritance
4. Multiple Inheritance
5. Hybrid Inheritance

---

# 3. Single Inheritance

A child class inherits from one parent class.

```text
Animal
   ▲
   │
  Dog
```

Example:

```java
class Animal {
    void eat() {
        System.out.println("Eating");
    }
}

class Dog extends Animal {
    void bark() {
        System.out.println("Barking");
    }
}
```

Java fully supports single inheritance.

---

# 4. Multilevel Inheritance

A class inherits from another derived class.

```text
Animal
   ▲
   │
 Mammal
   ▲
   │
  Dog
```

Example:

```java
class Animal {
    void eat() {}
}

class Mammal extends Animal {
    void walk() {}
}

class Dog extends Mammal {
    void bark() {}
}
```

The `Dog` class inherits members from both `Mammal` and `Animal`.

---

# 5. Hierarchical Inheritance

Multiple child classes inherit from the same parent class.

```text
        Animal
        /    \
      Dog    Cat
```

Example:

```java
class Animal {
    void eat() {}
}

class Dog extends Animal {
    void bark() {}
}

class Cat extends Animal {
    void meow() {}
}
```

Both subclasses share the parent's functionality.

---

# 6. Multiple Inheritance

A class inherits from more than one parent.

```text
 ParentA    ParentB
      \      /
       \    /
        Child
```

Java **does not support multiple inheritance through classes** because it can create ambiguity (Diamond Problem).

However, Java supports multiple inheritance of **type** using interfaces.

```java
interface Flyable {
    void fly();
}

interface Swimmable {
    void swim();
}

class Duck implements Flyable, Swimmable {

    public void fly() {}

    public void swim() {}
}
```

---

# 7. Hybrid Inheritance

Hybrid inheritance combines two or more inheritance types.

```text
      Animal
      /    \
   Dog      Cat
      \    /
      RobotDog
```

Java does not support hybrid inheritance using classes.

It can be achieved safely using interfaces.

---

# 8. Java Support Summary

| Type | Supported in Java? |
|------|---------------------|
| Single | ✅ Yes |
| Multilevel | ✅ Yes |
| Hierarchical | ✅ Yes |
| Multiple (Classes) | ❌ No |
| Multiple (Interfaces) | ✅ Yes |
| Hybrid (Classes) | ❌ No |
| Hybrid (Interfaces) | ✅ Possible |

---

# 9. Enterprise Examples

- Single: `Employee -> Manager`
- Multilevel: `User -> Employee -> Manager`
- Hierarchical: `Payment -> CreditCardPayment`, `UPIPayment`
- Multiple (Interfaces): `SmartDevice implements Camera, GPS`
- Hybrid: Microservice contracts using multiple interfaces

---

# 10. Best Practices

- Prefer simple inheritance hierarchies.
- Use interfaces for multiple capabilities.
- Avoid deep inheritance trees.
- Favor composition when relationships are unclear.

---

# 11. Common Mistakes

❌ Assuming Java supports multiple inheritance through classes.

❌ Creating deep hierarchies that are difficult to maintain.

❌ Using inheritance instead of composition.

---

# 12. Interview Questions

1. What are the different types of inheritance?
2. Which inheritance types are supported in Java?
3. Why doesn't Java support multiple inheritance through classes?
4. How can Java achieve multiple inheritance?
5. What is hybrid inheritance?

---

# 13. Quick Revision

```text
Single       ✓
Multilevel   ✓
Hierarchical ✓
Multiple     ✗ (Classes)
              ✓ (Interfaces)
Hybrid       ✗ (Classes)
              ✓ (Interfaces)
```

---

# 14. Summary

Object-Oriented Programming defines five major types of inheritance. Java directly supports single, multilevel, and hierarchical inheritance through classes while avoiding multiple and hybrid inheritance because of ambiguity issues. Instead, Java uses interfaces to safely support multiple inheritance of type, enabling flexible and maintainable enterprise software designs.
