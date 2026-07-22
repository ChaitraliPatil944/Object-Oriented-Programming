# Lesson 46 — When to Use Abstract Class

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

Choosing between an abstract class and an interface is a common design decision in Java.

An **abstract class** should be used when multiple related classes share **common state and common implementation**, but still require some behavior to be implemented differently.

---

# 2. When Should You Use an Abstract Class?

Use an abstract class when:

- Classes are closely related.
- Common fields need to be shared.
- Common methods can be reused.
- Only some methods should be implemented by subclasses.
- You want a common base implementation.

---

# 3. Decision Flow

```text
Related Classes?
      │
      ▼
Need Shared State?
      │
     Yes
      │
      ▼
Need Shared Implementation?
      │
     Yes
      │
      ▼
Use Abstract Class
```

---

# 4. Example: Employees

```java
abstract class Employee {

    protected String name;
    protected int id;

    Employee(String name, int id) {
        this.name = name;
        this.id = id;
    }

    void displayInfo() {
        System.out.println(id + " : " + name);
    }

    abstract double calculateSalary();
}

class FullTimeEmployee extends Employee {

    private double monthlySalary;

    FullTimeEmployee(String name, int id, double salary) {
        super(name, id);
        this.monthlySalary = salary;
    }

    @Override
    double calculateSalary() {
        return monthlySalary;
    }
}
```

The shared fields and `displayInfo()` method are inherited, while salary calculation differs.

---

# 5. Example: Vehicles

```java
abstract class Vehicle {

    void startEngine() {
        System.out.println("Engine Started");
    }

    abstract void fuelType();
}

class PetrolCar extends Vehicle {

    @Override
    void fuelType() {
        System.out.println("Petrol");
    }
}
```

---

# 6. Enterprise Example

```java
abstract class Notification {

    void logNotification() {
        System.out.println("Notification Logged");
    }

    abstract void send(String message);
}

class EmailNotification extends Notification {

    @Override
    void send(String message) {
        System.out.println("Email: " + message);
    }
}
```

All notification types share logging while implementing different delivery mechanisms.

---

# 7. Advantages

- Code reuse
- Reduced duplication
- Centralized common logic
- Easier maintenance
- Supports polymorphism

---

# 8. When NOT to Use an Abstract Class

Avoid an abstract class when:

- Classes are unrelated.
- Only a contract is required.
- Multiple inheritance of behavior is needed.
- No shared state exists.

In such cases, prefer an interface.

---

# 9. Abstract Class vs Interface Decision

| Situation | Preferred Choice |
|-----------|------------------|
| Shared fields | Abstract Class |
| Shared implementation | Abstract Class |
| Common constructor | Abstract Class |
| Only a contract | Interface |
| Multiple inheritance | Interface |

---

# 10. Best Practices

- Put reusable code in concrete methods.
- Keep abstract methods focused.
- Avoid unnecessary inheritance.
- Use protected fields sparingly.
- Prefer composition if inheritance is not natural.

---

# 11. Common Mistakes

❌ Using an abstract class with unrelated subclasses.

❌ Making every method abstract.

❌ Ignoring composition as an alternative.

---

# 12. Interview Questions

1. When should you use an abstract class?
2. Why not use an interface everywhere?
3. Can an abstract class have constructors?
4. Can it contain implemented methods?
5. Give a real-world example.

---

# 13. Quick Rule

```text
Need shared state?
        +
Need shared implementation?
        =
Use Abstract Class
```

---

# 14. Summary

Use an abstract class when related classes share common data and implementation but require specialized behavior in certain methods. Abstract classes reduce duplication, centralize reusable logic, and provide a strong foundation for inheritance. They are ideal for modeling families of closely related objects in enterprise Java applications.
