
# Object-Oriented-Programming — Repository Overview

Short collection of OOP examples and exercises (C++, C#, Java, Python, JS).

## Structure
- Cpp/: C++ example programs and exercises.
- DOTNET/: Multiple C#/.NET projects (Web API, console apps, sample exercises).
- EventDrivenApp/: C# event-driven example project.
- FundTransfer*/, FundTransferManager*/: Sample .NET apps showing transaction/transfer logic.
- MyApp/, HRApp/: Misc JavaScript/Node and other projects (see `package.json`).
- Java/: Java projects and sample apps (Maven-based subprojects).
- Lab4/: Python examples (e.g., `Program.py`, `Employee.py`).
- OOSolution/: Visual Studio solution(s) and related C# projects.
- Handbook/: Course notes and chapters about OOP (reference material).

## Quick Start
These examples are small, language-specific projects. Use the commands below from the repository root (Windows PowerShell).

### .NET (C#)
Run a .NET project (example: BankingAppWebApi):

```powershell
dotnet run --project DOTNET/BankingAppWebApi/BankingAppWebApi.csproj
```

To build a console project:

```powershell
dotnet build PATH/ToProject.csproj
dotnet run --project PATH/ToProject.csproj
```

### C++
Compile and run a simple C++ file:

```powershell
g++ -std=c++17 -O2 -o program Cpp/catalog.cpp
./program
```

Or open the `Cpp/` files with your IDE (Visual Studio/VS Code) and build the appropriate target.

### Node / JavaScript
If a folder contains `package.json` (e.g., `HRApp/`), run:

```powershell
cd HRApp
npm install
node Program.js
```

### Java (Maven)
For Maven-based projects under `Java/`:

```powershell
cd Java/YourProject
mvn clean package
java -jar target/your-artifact.jar
```

### Python
Run the Python examples (requires Python 3.x):

```powershell
python Lab4/Program.py
python Lab4/Employee.py
```

## Notes
- This repository contains many example folders and course material. Check each folder's README or project file for specific instructions.
- Paths and commands assume Windows PowerShell; adapt for other shells or OSes.

## Contributing
If you'd like a polished repository README with badges, licensing, or CI instructions, tell me which projects to highlight and I will update this file.

## License
Add a license file if you intend to publish this repository publicly.
