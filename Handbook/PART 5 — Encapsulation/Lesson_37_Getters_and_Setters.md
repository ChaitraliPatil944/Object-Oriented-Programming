# Lesson 37 — Getters and Setters

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

In Java, object fields are usually declared `private` to protect an object's internal state. To allow controlled access to these fields, classes provide **getter** and **setter** methods.

- **Getter**: Returns the value of a field.
- **Setter**: Updates the value of a field, usually after validation.

Together, getters and setters are a fundamental part of encapsulation.

---

# 2. Why Use Getters and Setters?

Without getters and setters:

```java
class Employee {
    public double salary;
}
```

Any code can modify the salary directly, even with invalid values.

With encapsulation:

```java
class Employee {

    private double salary;

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        this.salary = salary;
    }
}
```

Access is controlled through methods.

---

# 3. Getter Method

A getter returns the current value of a private field.

Example:

```java
class Student {

    private int marks;

    public int getMarks() {
        return marks;
    }
}
```

Usage:

```java
Student s = new Student();

System.out.println(s.getMarks());
```

---

# 4. Setter Method

A setter modifies a private field.

Example:

```java
class Student {

    private int marks;

    public void setMarks(int marks) {
        this.marks = marks;
    }
}
```

Usage:

```java
Student s = new Student();

s.setMarks(95);
```

---

# 5. Validation in Setters

One major advantage of setters is validation.

```java
class Employee {

    private double salary;

    public void setSalary(double salary) {

        if (salary >= 0) {
            this.salary = salary;
        }
    }
}
```

Invalid values are rejected.

---

# 6. Complete Example

```java
class Employee {

    private String name;
    private double salary;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getSalary() {
        return salary;
    }

    public void setSalary(double salary) {
        if (salary >= 0) {
            this.salary = salary;
        }
    }
}
```

---

# 7. Read-Only Objects

Sometimes only a getter is provided.

```java
private final int id;

public int getId() {
    return id;
}
```

The value can be read but not modified.

---

# 8. Write-Only Properties

Although uncommon, a class may expose only a setter.

```java
public void setPassword(String password) {
    this.password = password;
}
```

The password can be updated but not retrieved.

---

# 9. UML Representation

```text
+----------------------------+
| Employee                   |
+----------------------------+
| - name : String            |
| - salary : double          |
+----------------------------+
| + getName() : String       |
| + setName(String) : void   |
| + getSalary() : double     |
| + setSalary(double) : void |
+----------------------------+
```

---

# 10. Enterprise Example

```java
class BankAccount {

    private double balance;

    public double getBalance() {
        return balance;
    }

    public void deposit(double amount) {
        if(amount > 0){
            balance += amount;
        }
    }
}
```

Notice there is **no setter** for `balance`.

Business methods (`deposit`, `withdraw`) control updates.

---

# 11. Common Mistakes

❌ Providing setters for every field.

❌ Setters without validation.

❌ Exposing sensitive information through getters.

❌ Returning mutable internal collections directly.

---

# 12. Best Practices

- Keep fields private.
- Validate data in setters.
- Do not create unnecessary setters.
- Prefer business methods over generic setters.
- Expose read-only properties when appropriate.

---

# 13. Interview Questions

1. What is a getter?
2. What is a setter?
3. Why are getters and setters used?
4. Can a class have only a getter?
5. Why should setters validate input?
6. Should every field have a setter?

---

# 14. Summary

Getters and setters provide controlled access to an object's private fields. They are a key mechanism for implementing encapsulation, allowing developers to validate input, protect object integrity, and expose only the operations required by the application. In well-designed enterprise software, business methods are often preferred over unrestricted setters.
