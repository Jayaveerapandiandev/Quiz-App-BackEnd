# 📝 Quiz Application Backend  

This is the **backend** for a full-stack Quiz Application, built with **ASP.NET Core Web API**, **C#**, **Entity Framework Core**, and **Microsoft SQL Server 2022**.  

---

## 🚀 Tech Stack  

## Technologies Used

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET Core](https://img.shields.io/badge/.NET_Core-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)
![ASP.NET Core Web API](https://img.shields.io/badge/ASP.NET_Core_Web_API-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-512BD4?style=for-the-badge&logo=dot-net&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual-studio&logoColor=white)
![SSMS](https://img.shields.io/badge/SQL_Server_Management_Studio-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white)


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

- ASP.NET Core 8.0+  
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
