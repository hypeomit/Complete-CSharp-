
### Instance Fields (vs) Static Fields

**Storage:**

- Instance Fields: Stored in Objects
- Static Fields: Stored in Class's memory.

**Related to:**

- Instance Fields: Represents data related to objects.

- Static Fields: Represents common data that belongs to all objects.



**Declaration:**

- Instance Fields: Declared without "static" keyword. Syntax: type fieldName;

- Static Fields: Declared with "static" keyword. Syntax: static type fieldName;



**Accessible with:**

- Instance Fields: Accessible with object (through reference variable).

- Static Fields: Accessible with class name only (not with object).



**When memory gets allocated:**

- Instance Fields: Allocated separately for each object, because instance fields are stored "inside" the objects.

- Static Fields: Allocated only once for the entire program; i.e. when the class is used for the first time while executing the program.

### Constant Fields
- Constant Fields are like static fields, that are common to all objects of the class.

- We can't change the value of constant field.

- Constant Fields are accessible with class name [not with object].

- Constant Fields are not stored in the object; will not be stored anywhere.

- Constant Fields will be replaced with its value, while compilation; so it will not be stored anywhere in memory.

- Constant Fields must be initialized, in line with declaration (with a literal value only).

- Constants can also be declared as 'local constants' (in a method).

- AccessModifier   const    type   FieldName = value;


### Readonly Fields
- Readonly Fields are like instance fields, that is stored in every object, individually.

- We can't change the value of readonly field.

- Readonly Fields are accessible with reference variable [with object].

- Readonly Fields must be initialized, either "in-line with declaration" [or] "in the constructor".

- AccessModifier    readonly    DataType    FieldName = value;

### Local Constants 
- Reference value can not be constant i.e. class, i.e. class, inheritance, delegates etc.
- We can't change the value of const at rest of the code but can access it any no of times.
- Beginning with C# 10, Interpolated strings may be constants

   ```csharp
   const string Language = "C#";
  const string Platform = ".NET";
  const string Version = "10.0";
  const string FullProductName = $"{Platform} - Language: {Language} Version: {Version}";
    ```

### Key Points to Remember

- Fields are variables that are declared in the class; but stored in objects.

- Access modifiers of fields: private, protected, private protected, internal, protected internal, public

- Modifiers of fields: static, const, readonly

- Instance fields are individual for each object; Static fields are common (one-time) for all objects.

- Constants must be initialized along with declaration; Readonly fields must be initialized either 'along with declaration' or in 'instance constructor'.

  **================================================================**
  ### Interview Question

**1. What is an assembly in C#?**

*In C#, an assembly is a logical unit of code that consists of one or more files, typically in the form of executable code (such as .exe files) or dynamically linked libraries (DLLs) that can be loaded and executed by the Common Language Runtime (CLR). An assembly is the fundamental building block of .NET applications and is the primary mechanism for packaging, deploying, and versioning code in .NET.*

*An assembly can contain types (such as classes, structures, and interfaces), resources (such as images, icons, and strings), metadata (such as version information and security permissions), and code (such as IL or intermediate language instructions). The code within an assembly is compiled into a format that is understandable by the CLR and can be executed on any platform that supports the CLR.*

**2. What are fields in C#?**

*Fields in C# are variables that hold data within a class or struct. They are used to store data that is specific to an object, and can be accessed and modified through object instances or directly through the class or struct itself.*

**3. Explain all access modifiers in C#?**

*Access modifiers in C# determine the level of access that a class member has. There are five access modifiers in C#: public, private, protected, private protected, protected internal and internal.*

**4. What is the difference between public and private access modifiers in C#?**

*Public members can be accessed from anywhere, both within and outside the class, whereas private members can only be accessed within the class they are defined in.*

**5. What is the default access modifier for a class member in C#?**

*The default access modifier for a class member in C# is ‘private’.*

**6. What is the default access modifier for a class (or other types) in C#?**

*The default access modifier for a class / other types in C# is ‘internal’.*

**7. What is the purpose of using access modifiers in C#?**

*Access modifiers help in encapsulating and hiding the internal workings of a class or struct, and controlling the level of access to its members.*

**8. Difference between 'internal' and 'protected internal' in C#**

*'internal' is an access modifier that allows members to be accessed from any code within the same assembly, but not from code outside the assembly. This means that all classes in the same assembly can access internal members, but classes in other assemblies cannot.*

*'protected internal' is an access modifier that allows members to be accessed from any code within the same assembly or from derived classes outside the assembly. This means that all classes in the same assembly, as well as any derived classes in other assemblies, can access protected internal members.*

*In other words, 'internal' grants access to members only within the same assembly, while 'protected internal' grants access to members within the same assembly as well as to derived classes outside the assembly.*

**9. Difference between 'protected' and 'private protected' in C#**

*'protected' is an access modifier that allows members to be accessed from within the class and its derived classes, whether they are in the same assembly or a different assembly. This means that any derived class, whether it is in the same assembly or a different assembly, can access the protected member.*

*'private protected' is an access modifier that allows members to be accessed from within the class and its derived classes that are in the same assembly, but not from derived classes in a different assembly. This means that only derived classes that are defined in the same assembly as the base class can access the private protected member.*

*In other words, 'protected' grants access to members from all derived classes, while 'private protected' limits access to derived classes in the same assembly only.*

**10. What is a constant in C#?**

*A constant in C# is a variable whose value cannot be changed once it is assigned. It is declared using the const keyword, and its value must be initialized at the time of declaration.*

**11. Can a constant be modified after it is declared?**

*No, a constant cannot be modified after it is declared.*

**12. What is the difference between a constant and a readonly variable in C#?**

*A constant is a compile-time constant whose value cannot be changed, whereas a readonly variable is a runtime constant whose value can only be set once, either at initialization or in a constructor.*
