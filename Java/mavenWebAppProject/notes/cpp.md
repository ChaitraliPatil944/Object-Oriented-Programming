# Runtime Polymorphism Using Shape, Line, Circle

---

# Example

```cpp
class Shape {
public:
    virtual void draw() {
        cout << "Drawing Shape";
    }
};

class Line : public Shape {
public:
    void draw() override {
        cout << "Drawing Line";
    }
};

class Circle : public Shape {
public:
    void draw() override {
        cout << "Drawing Circle";
    }
};
```

---

# Why `virtual` is Important

```cpp
virtual void draw()
```

tells compiler:

```text
"Use runtime dispatch"
```

So compiler creates:

* vtable
* vptr

---

# Step 1 — VTables Created by Compiler

---

# Shape_vtable

```text
+----------------------+
| &Shape::draw         |
+----------------------+
```

---

# Line_vtable

`Line` overrides `draw()`:

```text
+----------------------+
| &Line::draw          |
+----------------------+
```

---

# Circle_vtable

```text
+----------------------+
| &Circle::draw        |
+----------------------+
```

---

# Step 2 — Object Memory Layout

---

# Shape Object

```cpp
Shape s;
```

Memory:

```text
+----------------------+
| vptr --------------+ | -----> Shape_vtable
+----------------------+
| Shape data members   |
+----------------------+
```

---

# Line Object

```cpp
Line l;
```

Memory:

```text
+----------------------+
| vptr --------------+ | -----> Line_vtable
+----------------------+
| Shape data members   |
+----------------------+
| Line data members    |
+----------------------+
```

---

# Circle Object

```cpp
Circle c;
```

Memory:

```text
+----------------------+
| vptr --------------+ | -----> Circle_vtable
+----------------------+
| Shape data members   |
+----------------------+
| Circle data members  |
+----------------------+
```

---

# Runtime Polymorphism

```cpp
Shape* ptr = new Circle();

ptr->draw();
```

---

# What Happens Internally

---

# Step 1 — Pointer Type

```text
ptr → Shape*
```

Compiler only knows:

```text
"ptr is Shape pointer"
```

But actual object is:

```text
Circle object
```

---

# Runtime Memory

```text
ptr
 |
 v

Circle Object
+----------------------+
| vptr --------------+ | -----> Circle_vtable
+----------------------+
| Shape data members   |
+----------------------+
| Circle data members  |
+----------------------+
```

---

# Step 2 — Virtual Function Resolution

Compiler converts conceptually:

```cpp
ptr->draw();
```

into something like:

```cpp
ptr->vptr[0]();
```

Meaning:

```text
1. Access object
2. Read vptr
3. Go to vtable
4. Call function at slot 0
```

---

# Actual Dispatch

```text
Circle Object
+----------------------+
| vptr --------------+ | -----> Circle_vtable
+----------------------+


Circle_vtable
+----------------------+
| &Circle::draw        |
+----------------------+
```

So executed function becomes:

```cpp
Circle::draw()
```

Output:

```text
Drawing Circle
```

---

# Another Example

```cpp
Shape* ptr = new Line();

ptr->draw();
```

---

# Runtime Flow

```text
ptr
 |
 v

Line Object
+----------------------+
| vptr --------------+ | -----> Line_vtable
+----------------------+

Line_vtable
+----------------------+
| &Line::draw          |
+----------------------+
```

Function called:

```cpp
Line::draw()
```

Output:

```text
Drawing Line
```

---

# Full Polymorphism Diagram

```text
                 Shape*
                    |
                    v

           +------------------+
           |  Circle Object   |
           |------------------|
           | vptr ----------- | --------------------+
           +------------------+                     |
           | Shape members    |                     |
           +------------------+                     |
           | Circle members   |                     |
           +------------------+                     |
                                                    v

                                        +------------------+
                                        | Circle_vtable    |
                                        |------------------|
                                        | &Circle::draw    |
                                        +------------------+
                                                    |
                                                    v

                                            Circle::draw()
```

---

# Without Virtual Function

If:

```cpp
void draw()
```

instead of:

```cpp
virtual void draw()
```

then compiler uses:

```text
STATIC BINDING
```

Meaning:

```cpp
Shape* ptr = new Circle();

ptr->draw();
```

calls:

```cpp
Shape::draw()
```

because compiler chooses function using pointer type:

```text
Shape*
```

NOT actual object type.

---

# Relationship Between Concepts

| Concept      | Meaning                       |
| ------------ | ----------------------------- |
| Shape        | Base class/interface          |
| Line/Circle  | Derived classes               |
| overriding   | Replacing base implementation |
| virtual      | Enables runtime dispatch      |
| vtable       | Stores function addresses     |
| vptr         | Hidden pointer inside object  |
| polymorphism | Same call, different behavior |

---

# Core Insight

```text
Object decides function
NOT pointer type
```

because:

```text
object → vptr → vtable → correct overridden function
```

---

# Final Visualization

```text
                COMPILE TIME
        --------------------------------

        Shape::draw marked virtual

                ↓

        Compiler creates vtables



                RUNTIME
        --------------------------------

        Shape* ptr = new Circle();

                ptr
                 |
                 v

          +---------------+
          | Circle Object |
          |---------------|
          | vptr -------- | ----------------+
          +---------------+                 |
                                            v

                                +-------------------+
                                | Circle_vtable     |
                                |-------------------|
                                | &Circle::draw     |
                                +-------------------+
                                            |
                                            v

                                    Circle::draw()
```