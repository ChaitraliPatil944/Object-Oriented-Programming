# Lesson 108 — Deserialization

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Deserialization** is the process of reconstructing a Java object from a stream of bytes that was previously created through serialization.

It is the reverse of **Object Serialization**.

Deserialization enables applications to restore object state from:

- Files
- Network streams
- Databases
- Distributed caches

---

# 2. Why Deserialization?

Deserialization allows applications to:

- Restore saved application data
- Receive objects across a network
- Recover user sessions
- Read cached objects
- Exchange data between distributed systems

---

# 3. ObjectInputStream

Java uses `ObjectInputStream` to read serialized objects.

```java
import java.io.*;

ObjectInputStream in =
    new ObjectInputStream(
        new FileInputStream("student.ser"));
```

The `readObject()` method reconstructs the object.

---

# 4. Basic Example

Assume `Student` implements `Serializable`.

```java
import java.io.*;

public class Demo {

    public static void main(String[] args) throws Exception {

        ObjectInputStream in =
            new ObjectInputStream(
                new FileInputStream("student.ser"));

        Student student = (Student) in.readObject();

        in.close();

        System.out.println(student);
    }
}
```

`readObject()` returns an `Object`, so an explicit cast is required.

---

# 5. How Deserialization Works

```text
File / Network
      │
      ▼
Byte Stream
      │
      ▼
ObjectInputStream
      │
      ▼
Java Object
```

The object's state is reconstructed from its serialized byte stream.

---

# 6. Serialization vs Deserialization

| Serialization | Deserialization |
|---------------|-----------------|
| Object → Bytes | Bytes → Object |
| ObjectOutputStream | ObjectInputStream |
| writeObject() | readObject() |
| Stores object | Restores object |

---

# 7. Exceptions During Deserialization

Common exceptions include:

- `IOException`
- `ClassNotFoundException`
- `InvalidClassException`
- `StreamCorruptedException`

Example:

```java
try {
    // deserialization code
} catch (IOException | ClassNotFoundException e) {
    System.out.println(e.getMessage());
}
```

---

# 8. Security Considerations

Deserializing data from untrusted sources can be dangerous.

Best practices:

- Accept serialized data only from trusted sources.
- Validate object contents after deserialization.
- Keep classes version compatible.
- Avoid deserializing unknown classes.

---

# 9. Advantages

- Restores complete object state
- Simplifies persistence
- Enables distributed communication
- Supports session recovery
- Works seamlessly with Java serialization

---

# 10. Best Practices

- Use try-with-resources.
- Declare `serialVersionUID`.
- Validate deserialized objects.
- Handle exceptions properly.
- Deserialize only trusted data.

---

# 11. Common Mistakes

❌ Forgetting that `readObject()` returns `Object`.

❌ Ignoring `ClassNotFoundException`.

❌ Deserializing incompatible class versions.

❌ Reading serialized data from untrusted sources without validation.

---

# 12. Interview Questions

1. What is deserialization?
2. Which class performs deserialization?
3. Why does `readObject()` require casting?
4. Which exceptions may occur during deserialization?
5. Why can deserialization be a security risk?

---

# 13. Quick Revision

```text
Byte Stream
     │
ObjectInputStream
     │
readObject()
     │
Java Object
```

---

# 14. Interview Cheat Sheet

```text
Deserialization

✔ Bytes → Object
✔ ObjectInputStream
✔ readObject()
✔ Explicit Cast Required

Common Exceptions
IOException
ClassNotFoundException
InvalidClassException
```

---

# 15. Summary

Deserialization reconstructs Java objects from serialized byte streams using `ObjectInputStream`. It is the reverse of serialization and is widely used for persistence, networking, distributed systems, and session management. Proper exception handling, version compatibility, and secure handling of untrusted data are essential for safe and reliable deserialization.
