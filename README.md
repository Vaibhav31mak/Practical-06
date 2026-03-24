# 📌 Events Demo (.NET 10 Console App)

## 🚀 Overview
A console application demonstrating event handling in C# using delegates and custom events.

## 🎯 Objective
- Understand events and delegates
- Learn publisher-subscriber pattern
- Trigger and handle events

## 🛠️ Tech Stack
- Language: C#
- Framework: .NET 10
- Type: Console Application

## 🧠 Concepts Covered
- Events & Delegates
- Event Invocation
- Publisher-Subscriber Pattern
- Null-safe invocation (?.Invoke)

---

## ⚙️ How It Works
1. `ProcessBusinessLogic` defines an event `ProcessCompleted`
2. `StartProcess()` triggers the event
3. `OnProcessCompleted()` invokes event safely
4. Main method subscribes to event
5. Event handler executes when event is raised

## Screenshots
<img width="1113" height="624" alt="image" src="https://github.com/user-attachments/assets/a469c1b9-62df-43c3-aa8f-75f21e55bf54" />

---

## ▶️ How to Run
1. Clone the repository
2. Navigate to project folder
3. Run:
   ```bash
   dotnet run
