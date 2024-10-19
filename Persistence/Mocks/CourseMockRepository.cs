using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Mocks
{
    public class CourseMockRepository
    {
        public List<User> Users { get; set; } = new();
        public List<Course> Courses { get; set; } = new();
        
        public CourseMockRepository()
        {
            // Инициализация пользователей
            Users.Add(new User { Id = 1, Username = "alice", EarnedTokens = 100 });
            Users.Add(new User { Id = 2, Username = "bob", EarnedTokens = 200 });

            // Инициализация курсов с вложенными модулями, лекциями, квестами и тестами
            var course1 = new Course
            {
                Id = 1,
                Title = "C# Basics",
                Description = "Learn the fundamentals of C#",
                TokenReward = 50,
                Modules = new List<Module>
            {
                new Module
                {
                    Id = 1,
                    Title = "Introduction to C#",
                    Description = "Getting started with C#",
                    TokenReward = 20,
                    Lectures = new List<Lecture>
                    {
                        new Lecture
                        {
                            Id = 1,
                            Title = "C# Variables",
                            Description = "Understanding variables in C#",
                            Materials = "Lecture notes and code samples",
                            TokenReward = 10
                        },
                        new Lecture
                        {
                            Id = 2,
                            Title = "C# Data Types",
                            Description = "Explore various data types in C#",
                            Materials = "Slides and exercises",
                            TokenReward = 15
                        }
                    },
                    Tests = new List<Test>
                    {
                        new Test
                        {
                            Id = 1,
                            Title = "C# Variables test",
                            Description = "Test your knowledge of C# basics",
                            TokenReward = 30,
                            Questions = new List<Question>
                            {
                                new Question
                                {
                                    Id = 1,
                                    Text = "What is the output of Console.WriteLine(1 + \"1\");?",
                                    Answers = new List<string> { "2", "11", "Error", "None of the above" },
                                    CorrectAnswer = "11"
                                },
                                new Question
                                {
                                    Id = 2,
                                    Text = "What is the output of Console.WriteLine(1 + \"8\");?",
                                    Answers = new List<string> { "9", "18", "Error", "None of the above" },
                                    CorrectAnswer = "18"
                                },

                            }
                        },
                        new Test
                        {
                            Id = 2,
                            Title = "C# Basics test",
                            Description = "Test your knowledge of C# basics",
                            TokenReward = 30,
                            Questions = new List<Question>
                            {
                                new Question
                                {
                                    Id = 3,
                                    Text = "What is the output of Console.WriteLine(1 + \"1\");?",
                                    Answers = new List<string> { "2", "11", "Error", "None of the above" },
                                    CorrectAnswer = "11"
                                },
                                new Question
                                {
                                    Id = 4,
                                    Text = "What is the output of Console.WriteLine(1 + \"8\");?",
                                    Answers = new List<string> { "9", "18", "Error", "None of the above" },
                                    CorrectAnswer = "18"
                                },

                            }
                        }
                    },
                    Assignments = new List<Assignment>
                    {
                        new Assignment
                        {
                            Id = 1,
                            Title = "Create an async API client",
                            Description = "Develop a client that makes async API calls.",
                            Deadline = DateTime.Now.AddDays(7),
                            TokenReward = 50
                        },
                        new Assignment
                        {
                            Id = 2,
                            Title = "Create a 'Hangman game'",
                            Description = "Develop a 'Hangman game' with game interface.",
                            Deadline = DateTime.Now.AddDays(14),
                            TokenReward = 100
                        },

                    }

                }
            },
            Quests = new List<Quest>
            {
                new Quest
                {
                    Id = 1,
                    Title = "C# Adventure",
                    Description = "Complete the C# challenges",
                    TokenReward = 50,
                    Tasks = new List<QuestTask>
                    {
                        new QuestTask
                        {
                            Id = 1,
                            Text = "Write a program that prints 'Hello, World!'",
                            Status = false
                        },
                        new QuestTask
                        {
                            Id = 2,
                            Text = "Create a method that returns the sum of two integers.",
                            Status = false
                        }
                    }
                }
            },
            Quizzes = new List<Quiz>
            {
                new Quiz
                {
                    Id = 1,
                    Title = "C# Beginner Quiz",
                    Description = "Test your basic C# knowledge.",
                    TokenReward = 20,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 6,
                            Text = "What is the correct syntax to declare a variable in C#?",
                            Answers = new List<string> { "var x = 5;", "int x = 5;", "let x = 5;", "x = 5;" },
                            CorrectAnswer = "int x = 5;"
                        },
                        new Question
                        {
                            Id = 7,
                            Text = "Which data type is used to store true/false values?",
                            Answers = new List<string> { "int", "bool", "string", "double" },
                            CorrectAnswer = "bool"
                        }
                    }
                },
                new Quiz
                {
                    Id = 2,
                    Title = "Data Types Quiz",
                    Description = "Check your understanding of C# data types.",
                    TokenReward = 25,
                    Questions = new List<Question>
                    {
                        new Question
                        {
                            Id = 8,
                            Text = "Which of the following is not a primitive data type?",
                            Answers = new List<string> { "int", "float", "string", "Array" },
                            CorrectAnswer = "Array"
                        },
                        new Question
                        {
                            Id = 9,
                            Text = "What is the size of an 'int' in C#?",
                            Answers = new List<string> { "2 bytes", "4 bytes", "8 bytes", "16 bytes" },
                            CorrectAnswer = "4 bytes"
                        }
                    }
                }
            }
            };

            var course2 = new Course
            {
                Id = 2,
                Title = "Advanced C#",
                Description = "Dive deep into advanced C# topics",
                TokenReward = 100,
                Modules = new List<Module>
            {
                new Module
                {
                    Id = 2,
                    Title = "Async Programming in C#",
                    Description = "Learn about async and await",
                    TokenReward = 40,
                    Assignments = new List<Assignment>
                    {
                        new Assignment
                        {
                            Id = 1,
                            Title = "Create an async API client",
                            Description = "Develop a client that makes async API calls.",
                            Deadline = DateTime.Now.AddDays(7),
                            TokenReward = 50
                        }
                    }
                }
            }
            };

            Courses.AddRange(new[] { course1, course2 });

        }

    }
}
