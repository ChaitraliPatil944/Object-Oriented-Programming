# Lesson 100 — Implicit and Explicit Type Casting

> **Object-Oriented Programming (OOP) Handbook**

---

# 1. Introduction

**Type Casting** is the process of converting a value from one data type to another.

Java supports two types of type casting:

1. **Implicit Type Casting (Widening Conversion)**
2. **Explicit Type Casting (Narrowing Conversion)**

Type casting is commonly used when working with different primitive data types, wrapper classes, arithmetic operations, and object-oriented programming concepts such as inheritance.

---

# 2. Why Do We Need Type Casting?

Different variables may have different data types.

Example:

```java
int age = 20;
double salary = 55000.75;
```

Sometimes values need to be converted to another type for:

- Calculations
- Assignments
- Method calls
- Compatibility

---

# 3. Implicit Type Casting (Widening)

Implicit casting happens **automatically** when converting a **smaller data type into a larger compatible data type**.

No data loss occurs.

### Conversion Order

```text
byte
  ↓
short
  ↓
int
  ↓
long
  ↓
float
  ↓
double
```

### Example

```java
int number = 100;

double value = number;

System.out.println(value);
```

Output:

```text
100.0
```

Java automatically converts `int` to `double`.

---

# 4. Explicit Type Casting (Narrowing)

Explicit casting is required when converting a **larger data type into a smaller data type**.

This conversion may result in **loss of data**.

### Example

```java
double salary = 45678.95;

int amount = (int) salary;

System.out.println(amount);
```

Output:

```text
45678
```

The decimal part is discarded.

---

# 5. Data Loss During Narrowing

Example:

```java
int number = 300;

byte value = (byte) number;

System.out.println(value);
```

Output:

```text
44
```

Since `byte` ranges from -128 to 127, the value overflows.

---

# 6. Primitive Type Casting Examples

### Widening

```java
char ch = 'A';

int value = ch;
```

Output:

```text
65
```

---

### Narrowing

```java
float price = 25.75f;

int amount = (int) price;
```

Output:

```text
25
```

---

# 7. Object Type Casting

Type casting also applies to objects through inheritance.

### Upcasting (Implicit)

```java
class Animal { }

class Dog extends Animal { }

Animal obj = new Dog();
```

Upcasting is automatic and safe.

---

### Downcasting (Explicit)

```java
Animal obj = new Dog();

Dog dog = (Dog) obj;
```

Downcasting requires an explicit cast.

Incorrect downcasting may throw:

```text
ClassCastException
```

---

# 8. Implicit vs Explicit Casting

| Feature | Implicit | Explicit |
|---------|----------|----------|
| Also Called | Widening | Narrowing |
| Automatic | Yes | No |
| Cast Operator | Not Required | Required |
| Data Loss | No | Possible |
| Safe | Yes | Depends |

---

# 9. Advantages

### Implicit Casting

- Automatic
- Safe
- No data loss
- Cleaner code

### Explicit Casting

- Greater control
- Enables conversions otherwise not allowed
- Useful with inheritance and arithmetic

---

# 10. Best Practices

- Prefer widening conversions when possible.
- Use explicit casting only when necessary.
- Be aware of possible overflow and precision loss.
- Use `instanceof` before downcasting objects.

---

# 11. Common Mistakes

❌ Assuming narrowing conversions preserve values.

❌ Downcasting unrelated objects.

```java
Animal a = new Animal();

Dog d = (Dog) a; // ClassCastException
```

❌ Forgetting that floating-point values lose decimals when cast to integers.

---

# 12. Interview Questions

1. What is type casting?
2. Difference between implicit and explicit casting?
3. What is widening conversion?
4. What is narrowing conversion?
5. Difference between upcasting and downcasting?

---

# 13. Quick Revision

```text
Type Casting
│
├── Implicit (Widening)
│      └── Automatic
│
└── Explicit (Narrowing)
       └── Manual Cast
```

---

# 14. Interview Cheat Sheet

```text
Implicit Casting

byte → short → int → long → float → double

✔ Automatic
✔ Safe
✔ No Data Loss

Explicit Casting

double → float → long → int → short → byte

✔ Manual
✔ Possible Data Loss
✔ Uses (type)

Objects

Upcasting → Automatic
Downcasting → Explicit
```

---

# 15. Summary

Type casting allows Java programs to convert values between compatible data types. Implicit (widening) casting is automatic and safe because it converts smaller types into larger ones without losing information. Explicit (narrowing) casting requires a manual cast and may result in data loss or overflow. In object-oriented programming, upcasting is automatic while downcasting requires explicit casting and should be used carefully to avoid runtime exceptions.
