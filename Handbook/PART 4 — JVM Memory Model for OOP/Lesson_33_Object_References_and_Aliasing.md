# Lesson 33 — Object References and Aliasing

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

In Java, variables that refer to objects do **not** store the objects themselves. They store **references** (addresses managed by the JVM) that point to objects in the Heap.

Because multiple reference variables can point to the same object, modifying the object through one reference affects what every other reference sees. This phenomenon is called **aliasing**.

Understanding references and aliasing is essential for debugging, object copying, parameter passing, and memory management.

---

# 2. What is an Object Reference?

An object reference is a variable that points to an object stored in the Heap.

```java
Employee emp = new Employee();
```

Memory:

```text
Stack                     Heap

emp  ───────────────►  Employee Object
```

The variable `emp` stores a reference, not the object itself.

---

# 3. What is Aliasing?

**Aliasing** occurs when two or more reference variables point to the same object.

```java
Employee e1 = new Employee();
Employee e2 = e1;
```

Memory:

```text
Stack

e1 ─────┐
         │
e2 ─────┘
         ▼

Heap

+------------------+
| Employee Object  |
+------------------+
```

Only one object exists.

---

# 4. Effect of Aliasing

```java
Employee e1 = new Employee();
e1.name = "Alice";

Employee e2 = e1;

e2.name = "Bob";

System.out.println(e1.name);
```

Output:

```text
Bob
```

Both variables reference the same object.

---

# 5. Independent Objects

```java
Employee e1 = new Employee();
Employee e2 = new Employee();
```

Memory:

```text
Stack

e1 ─────► Employee #1

e2 ─────► Employee #2
```

Changing one object does not affect the other.

---

# 6. Assignment vs Copy

Reference assignment:

```java
Employee e2 = e1;
```

Creates another reference to the same object.

Object copy:

```java
Employee e2 = (Employee) e1.clone();
```

or

```java
Employee e2 = new Employee(e1);
```

Creates a separate object.

---

# 7. Aliasing with Method Parameters

Java passes object references **by value**.

```java
void update(Employee emp){
    emp.name = "Charlie";
}
```

Calling:

```java
update(e1);
```

changes the object because both references point to the same heap object.

However:

```java
void change(Employee emp){
    emp = new Employee();
}
```

Reassigning the parameter does **not** change the caller's reference.

---

# 8. Aliasing with Collections

Collections store object references.

```java
List<Employee> list = new ArrayList<>();

Employee e = new Employee();

list.add(e);
```

If `e` changes later:

```java
e.name = "David";
```

the object inside the list also reflects the change because the list stores the same reference.

---

# 9. Null References

```java
Employee emp = null;
```

Memory:

```text
Stack

emp = null

Heap

(No object referenced)
```

Attempting to access:

```java
emp.name;
```

results in:

```text
NullPointerException
```

---

# 10. Enterprise Example

Consider a banking application.

```java
Account current = account;
Account backup = account;
```

Both variables refer to the same account.

```java
current.deposit(500);
```

The balance seen through `backup` also changes because both references access the same object.

---

# 11. Common Mistakes

❌ Assuming assignment copies an object.

❌ Believing Java passes objects by reference.

❌ Forgetting that collections store references.

❌ Modifying shared mutable objects unintentionally.

---

# 12. Best Practices

- Use cloning or copy constructors when independent objects are required.
- Be cautious when sharing mutable objects.
- Prefer immutable objects where practical.
- Understand object ownership in large applications.

---

# 13. Interview Questions

1. What is an object reference?
2. What is aliasing?
3. Does `e2 = e1` create a new object?
4. How does Java pass object references to methods?
5. Why do changes through one reference appear through another?
6. How can aliasing be avoided?

---

# 14. Summary

Object references allow variables to point to objects stored in the Heap. Aliasing occurs when multiple references point to the same object, causing changes through one reference to be visible through the others. Understanding references, aliasing, copying, and parameter passing is fundamental for writing reliable Java applications and avoiding subtle bugs.
