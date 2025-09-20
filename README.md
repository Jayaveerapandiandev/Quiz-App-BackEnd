# 📝 Quiz Application Backend  

This is the **backend** for a full-stack Quiz Application, built with **ASP.NET Core Web API**, **C#**, **Entity Framework Core**, and **Microsoft SQL Server 2022**.  

---

## 🚀 Tech Stack  

<p align="left">
  <!-- ASP.NET Core -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/dotnetcore/dotnetcore-original.svg" width="50" height="50" alt="ASP.NET Core"/>
  
  <!-- C# -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/csharp/csharp-original.svg" width="50" height="50" alt="C#"/>
  
  <!-- Entity Framework Core -->
  <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Entity_Framework_Logo.svg" width="50" height="50" alt="Entity Framework Core"/>
  
  <!-- SQL Server -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-original.svg" width="50" height="50" alt="SQL Server 2022"/>
  
  <!-- Visual Studio -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/visualstudio/visualstudio-plain.svg" width="50" height="50" alt="Visual Studio 2022"/>
  
  <!-- SSMS (SQL Server Management Studio) -->
  <img src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/microsoftsqlserver/microsoftsqlserver-original.svg" width="50" height="50" alt="SSMS 2022"/>
</p>


---

## 📖 Project Overview  

The **Quiz App** provides a seamless quiz-taking experience with features like real-time progress tracking, automatic navigation, and result review.  

### 🔑 Features  
- 🧑‍💻 **User Entry**: User enters **username** and **email** to start the quiz.  
- ❓ **Quiz Flow**: Displays **15 multiple-choice questions** one by one.  
- ⏱️ **Timer Support**: Countdown timer ensures quizzes are time-bound.  
- 📊 **Progress Board**: Shows current progress (e.g., *Question 5 of 15*).  
- ⚡ **Auto Navigation**: Selecting an option automatically moves to the next question.  
- 🏆 **Results Screen**: After finishing 15 questions, displays:  
  - ✅ Final **score**  
  - 🔄 **Retake Quiz** option  
  - 📋 **Review Answers** option  

---

## 🗄️ Backend Responsibilities  

- Provides **RESTful APIs** for questions, answers, participants, and scores.  
- Uses **Entity Framework Core** with **Code-First Migrations** for database schema.  
- Stores quiz data in **SQL Server 2022**.  
- Developed and tested using **Visual Studio 2022** and **SQL Server Management Studio (SSMS) 2022**.  

---

## 🏗️ How It Works  

1. **User Registration** → Enter username & email.  
2. **Quiz Start** → Fetch 15 random questions from the database.  
3. **Quiz Session** → Timer starts, answers auto-submit on selection, progress updates.  
4. **Completion** → Final score displayed with review/retake options.  

---

## 📌 Requirements  

- ASP.NET Core 6.0+  
- Entity Framework Core  
- Microsoft SQL Server 2022  
- Visual Studio 2022  
- SQL Server Management Studio (SSMS) 2022  

---

## ⚡ Getting Started  

1. Clone this repository:  
   ```bash
   git clone https://github.com/your-username/quizapp-backend.git
   cd quizapp-backend
