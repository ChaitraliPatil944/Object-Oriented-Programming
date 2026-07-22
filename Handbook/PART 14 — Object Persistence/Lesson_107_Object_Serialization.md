# Lesson 107 — Object Serialization

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Object Serialization** is the process of converting a Java object into a stream of bytes so that it can be:

- Stored in a file
- Sent over a network
- Saved in a database
- Cached for later use

The reverse process is called **Deserialization**, which reconstructs the object from the byte stream.

Serialization is widely used in distributed systems, web applications, messaging systems, and persistence frameworks.

---

# 2. Why Serialization?

Serialization allows objects to survive beyond the lifetime of a running program.

Common use cases:

- Saving application state
- Sending objects through sockets
- Remote Method Invocation (RMI)
- HTTP session storage
- Distributed caching

---

# 3. Serializable Interface

To make an object serializable, its class must implement the marker interface:

```java
java.io.Serializable
```

It contains **no methods**.

Example:

```java
import java.io.Serializable;

class Student implements Serializable {

    private int id;
    private String name;

    Student(int id, String name) {
        this.id = id;
        this.name = name;
    }
}
```

---

# 4. Serializing an Object

Java uses `ObjectOutputStream` to write objects.

```java
import java.io.*;

public class Demo {

    public static void main(String[] args) throws Exception {

        Student student = new Student(1, "Alice");

        ObjectOutputStream out =
            new ObjectOutputStream(
                new FileOutputStream("student.ser"));

        out.writeObject(student);
        out.close();

        System.out.println("Object serialized.");
    }
}
```

A file named `student.ser` is created.

---

# 5. How Serialization Works

```text
Java Object
     │
     ▼
ObjectOutputStream
     │
     ▼
Byte Stream
     │
     ▼
File / Network / Database
```

The object's state is converted into bytes.

---

# 6. Serialization Requirements

- Class must implement `Serializable`.
- All non-transient fields should be serializable.
- Referenced objects must also be serializable.
- Use `serialVersionUID` for version compatibility.

---

# 7. What Gets Serialized?

Serialized:

- Instance variables
- Object graph (if serializable)

Not Serialized:

- Static variables
- Transient variables
- Methods
- Constructors

---

# 8. Advantages

- Easy object persistence
- Network communication
- Session management
- Object caching
- Distributed applications

---

# 9. Best Practices

- Always declare `serialVersionUID`.
- Serialize only required data.
- Use `transient` for sensitive fields.
- Close streams properly or use try-with-resources.
- Avoid serializing unnecessary object graphs.

---

# 10. Common Mistakes

❌ Forgetting to implement `Serializable`.

❌ Serializing non-serializable referenced objects.

❌ Ignoring version compatibility.

❌ Serializing passwords or sensitive information.

---

# 11. Interview Questions

1. What is serialization?
2. Why is the `Serializable` interface called a marker interface?
3. Which class writes serialized objects?
4. What data is not serialized?
5. What is `serialVersionUID` used for?

---

# 12. Quick Revision

```text
Object
  │
Serializable
  │
ObjectOutputStream
  │
Byte Stream
  │
File / Network
```

---

# 13. Interview Cheat Sheet

```text
Serialization

✔ Object → Bytes
✔ Serializable Interface
✔ ObjectOutputStream
✔ Used for Persistence & Networking

Not Serialized
✘ static
✘ transient
```

---

# 14. Summary

Object Serialization converts Java objects into byte streams so they can be stored or transmitted. A class must implement the `Serializable` marker interface to participate in serialization. Java's `ObjectOutputStream` handles the conversion, making serialization an essential feature for persistence, networking, caching, and distributed object-oriented applications.
