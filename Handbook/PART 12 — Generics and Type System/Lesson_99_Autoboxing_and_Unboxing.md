# Lesson 99 — Autoboxing and Unboxing

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Autoboxing** and **Unboxing** are Java features introduced in **Java 5** that automatically convert between **primitive data types** and their corresponding **wrapper classes**.

- **Autoboxing:** Primitive → Wrapper Object
- **Unboxing:** Wrapper Object → Primitive

These features simplify coding by eliminating manual conversions.

---

# 2. Primitive Types and Wrapper Classes

| Primitive | Wrapper Class |
|-----------|---------------|
| byte | Byte |
| short | Short |
| int | Integer |
| long | Long |
| float | Float |
| double | Double |
| char | Character |
| boolean | Boolean |

Example:

```java
int number = 10;
Integer obj = Integer.valueOf(number);
```

With autoboxing, Java performs this conversion automatically.

---

# 3. What is Autoboxing?

Autoboxing automatically converts a primitive value into its wrapper object.

### Example

```java
public class Demo {

    public static void main(String[] args) {

        Integer number = 100;

        Double price = 99.99;

        Character ch = 'A';

        Boolean flag = true;

        System.out.println(number);
    }
}
```

Equivalent manual code:

```java
Integer number = Integer.valueOf(100);
```

---

# 4. What is Unboxing?

Unboxing automatically converts a wrapper object back into a primitive value.

### Example

```java
Integer number = 200;

int value = number;

System.out.println(value);
```

Equivalent manual code:

```java
int value = number.intValue();
```

---

# 5. Why Are They Needed?

Before Java 5:

```java
Integer number = Integer.valueOf(100);

int value = number.intValue();
```

After Java 5:

```java
Integer number = 100;

int value = number;
```

Cleaner, shorter, and easier to read.

---

# 6. Autoboxing with Collections

Collections store **objects**, not primitive types.

Without autoboxing:

```java
ArrayList<Integer> list = new ArrayList<>();

list.add(Integer.valueOf(10));
```

With autoboxing:

```java
ArrayList<Integer> list = new ArrayList<>();

list.add(10);
```

Java automatically creates the `Integer` object.

---

# 7. Unboxing in Expressions

```java
Integer a = 10;
Integer b = 20;

int sum = a + b;

System.out.println(sum);
```

Java automatically unboxes `a` and `b` before performing arithmetic.

---

# 8. NullPointerException Risk

Unboxing a `null` wrapper object causes a `NullPointerException`.

Example:

```java
Integer number = null;

int value = number; // Runtime Error
```

Always check for `null` before unboxing.

---

# 9. Advantages

- Cleaner code
- Less boilerplate
- Easier collection usage
- Automatic conversions
- Better readability

---

# 10. Disadvantages

- Performance overhead due to object creation
- Additional memory usage
- Risk of `NullPointerException`
- Can introduce hidden boxing/unboxing operations

---

# 11. Best Practices

- Use primitives for performance-critical code.
- Use wrapper classes when working with collections or generics.
- Avoid unnecessary boxing and unboxing in loops.
- Check wrapper objects for `null` before unboxing.

---

# 12. Common Mistakes

❌ Assuming wrapper objects cannot be `null`.

❌ Excessive boxing/unboxing inside performance-sensitive code.

❌ Confusing primitives with wrapper classes.

---

# 13. Interview Questions

1. What is autoboxing?
2. What is unboxing?
3. Why were these features introduced?
4. Why do collections use wrapper classes instead of primitives?
5. What happens if a `null` wrapper object is unboxed?

---

# 14. Quick Revision

```text
Autoboxing
Primitive ───► Wrapper

Unboxing
Wrapper ───► Primitive
```

---

# 15. Interview Cheat Sheet

```text
Autoboxing
int → Integer
double → Double
char → Character

Unboxing
Integer → int
Double → double

✔ Introduced in Java 5
✔ Automatic Conversion
✔ Used with Collections
⚠ NullPointerException Possible
```

---

# 16. Summary

Autoboxing and unboxing automatically convert between Java's primitive data types and their corresponding wrapper classes. These features reduce boilerplate code, simplify the use of collections and generics, and improve readability. However, developers should be aware of the performance overhead and the possibility of `NullPointerException` when unboxing `null` wrapper objects.
