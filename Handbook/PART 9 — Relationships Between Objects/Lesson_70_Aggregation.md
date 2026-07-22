# Lesson 70 — Aggregation

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Aggregation** is a special type of **Association** that represents a **weak "has-a" relationship**.

In aggregation, one object contains or uses another object, but **both objects have independent lifecycles**.

If the container object is destroyed, the contained object can still exist.

---

# 2. Definition

Aggregation is a relationship where one class has a reference to another class without owning its lifetime.

Characteristics:

- Weak has-a relationship
- Objects exist independently
- Ownership is shared or absent
- Implemented using object references

---

# 3. Real-World Example

```text
Department ◇──── Employee

Department has Employees.

Deleting a Department
does NOT delete Employees.
```

Employees can be moved to another department.

---

# 4. Java Example

```java
class Employee {
    String name;

    Employee(String name) {
        this.name = name;
    }
}

class Department {

    String name;
    Employee employee;

    Department(String name, Employee employee) {
        this.name = name;
        this.employee = employee;
    }

    void display() {
        System.out.println(employee.name + " works in " + name);
    }
}
```

Usage:

```java
Employee emp = new Employee("Amit");
Department dept = new Department("IT", emp);

dept.display();
```

Output:

```
Amit works in IT
```

---

# 5. UML Representation

Aggregation is represented by a **hollow diamond**.

```text
Department ◇──────── Employee
```

The diamond is placed on the "whole" side.

---

# 6. Enterprise Examples

- Department → Employee
- Library → Books
- Team → Players
- University → Professors

The contained objects continue to exist even if the container changes.

---

# 7. Aggregation vs Association

| Association | Aggregation |
|-------------|-------------|
| General relationship | Specialized association |
| No ownership implied | Weak ownership |
| "Knows-a" | Weak "Has-a" |
| Independent lifecycles | Independent lifecycles |

---

# 8. Advantages

- Promotes code reuse
- Loose coupling
- Flexible object sharing
- Models real-world ownership accurately

---

# 9. Best Practices

- Use aggregation when parts can exist independently.
- Avoid forcing ownership where none exists.
- Prefer interfaces for collaboration.

---

# 10. Common Mistakes

❌ Confusing aggregation with composition.

❌ Treating aggregation as inheritance.

❌ Assuming contained objects are destroyed with the container.

---

# 11. Interview Questions

1. What is aggregation?
2. How is aggregation different from association?
3. How is aggregation different from composition?
4. Why is it called a weak has-a relationship?
5. Give enterprise examples of aggregation.

---

# 12. Quick Revision

```text
Aggregation
│
├── Weak Has-A
├── Hollow Diamond
├── Independent lifecycles
├── Object reference
└── Specialized Association
```

---

# 13. Summary

Aggregation is a specialized form of association that models a weak "has-a" relationship. The container object references other objects without owning their lifetime, allowing them to exist independently. It is widely used in enterprise systems to model flexible relationships such as Department-Employee and Team-Player.
