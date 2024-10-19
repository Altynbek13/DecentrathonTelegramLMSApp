using Domain.Entities;

namespace Persistence.Mocks
{
    public class CourseMockRepository
    {
        public List<Course> Courses { get; set; } = new();
        public CourseMockRepository()
        {
            // Инициализация курсов с вложенными модулями, лекциями, квестами и тестами
            var course1 = new Course
            {
                Id = 1,
                Title = "Основы C#",
                Description = "Изучите основы C#",
                ImgPath = "/images/Основы CSharp.png",
                TokenReward = 50,
                Modules = new List<Module>
                {
                    new Module
                    {
                        Id = 1,
                        Title = "Введение в C#",
                        Description = "Начало работы с C#",
                        TokenReward = 20,
                        Lectures = new List<Lecture>
                        {
                            new Lecture
                            {
                                Id = 1,
                                Title = "Переменные в C#",
                                Description = "Понимание переменных в C#",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 10
                            },
                            new Lecture
                            {
                                Id = 2,
                                Title = "Типы данных в C#",
                                Description = "Изучение различных типов данных в C#",
                                Materials = "Слайды и упражнения",
                                TokenReward = 15
                            }
                        },
                        Tests = new List<Test>
                        {
                            new Test
                            {
                                Id = 1,
                                Title = "Тест по переменным в C#",
                                Description = "Проверьте свои знания основ C#",
                                TokenReward = 30,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 1,
                                        Text = "Какой результат будет у Console.WriteLine(1 + \"1\");?",
                                        Answers = new List<string> { "2", "11", "Ошибка", "Ни один из вариантов" },
                                        CorrectAnswer = "11"
                                    },
                                    new Question
                                    {
                                        Id = 2,
                                        Text = "Какой результат будет у Console.WriteLine(1 + \"8\");?",
                                        Answers = new List<string> { "9", "18", "Ошибка", "Ни один из вариантов" },
                                        CorrectAnswer = "18"
                                    },

                                }
                            },
                            new Test
                            {
                                Id = 2,
                                Title = "Тест по основам C#",
                                Description = "Проверьте свои знания основ C#",
                                TokenReward = 30,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 3,
                                        Text = "Какой результат будет у Console.WriteLine(1 + \"1\");?",
                                        Answers = new List<string> { "2", "11", "Ошибка", "Ни один из вариантов" },
                                        CorrectAnswer = "11"
                                    },
                                    new Question
                                    {
                                        Id = 4,
                                        Text = "Какой результат будет у Console.WriteLine(1 + \"8\");?",
                                        Answers = new List<string> { "9", "18", "Ошибка", "Ни один из вариантов" },
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
                                Title = "Создайте асинхронный API-клиент",
                                Description = "Разработайте клиент, который выполняет асинхронные вызовы API.",
                                Deadline = DateTime.Now.AddDays(7),
                                TokenReward = 50
                            },
                            new Assignment
                            {
                                Id = 2,
                                Title = "Создайте игру 'Виселица'",
                                Description = "Разработайте игру 'Виселица' с игровым интерфейсом.",
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
                        Title = "Приключение C#",
                        Description = "Выполните задания по C#",
                        TokenReward = 50,
                        Tasks = new List<QuestTask>
                        {
                            new QuestTask
                            {
                                Id = 1,
                                Text = "Напишите программу, которая выводит 'Hello, World!'",
                                Status = false
                            },
                            new QuestTask
                            {
                                Id = 2,
                                Text = "Создайте метод, который возвращает сумму двух целых чисел.",
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
                        Title = "Тест для новичков по C#",
                        Description = "Проверьте свои базовые знания C#.",
                        TokenReward = 20,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 6,
                                Text = "Какой правильный синтаксис для объявления переменной в C#?",
                                Answers = new List<string> { "var x = 5;", "int x = 5;", "let x = 5;", "x = 5;" },
                                CorrectAnswer = "int x = 5;"
                            },
                            new Question
                            {
                                Id = 7,
                                Text = "Какой тип данных используется для хранения значений true/false?",
                                Answers = new List<string> { "int", "bool", "string", "double" },
                                CorrectAnswer = "bool"
                            }
                        }
                    },
                    new Quiz
                    {
                        Id = 2,
                        Title = "Тест по типам данных",
                        Description = "Проверьте свои знания типов данных в C#.",
                        TokenReward = 25,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 8,
                                Text = "Какой из следующих вариантов не является примитивным типом данных?",
                                Answers = new List<string> { "int", "float", "string", "Array" },
                                CorrectAnswer = "Array"
                            },
                            new Question
                            {
                                Id = 9,
                                Text = "Каков размер 'int' в C#?",
                                Answers = new List<string> { "2 байта", "4 байта", "8 байт", "16 байт" },
                                CorrectAnswer = "4 байта"
                            }
                        }
                    }
                }
            };

            var course2 = new Course
            {
                Id = 2,
                Title = "Основы ASP.NET",
                Description = "Изучите основы создания веб-приложений с использованием ASP.NET",
                ImgPath = "/images/Основы ASP.NET.png",
                TokenReward = 70,
                Modules = new List<Module>
                {
                    new Module
                    {
                        Id = 2,
                        Title = "Введение в ASP.NET",
                        Description = "Начало работы с ASP.NET",
                        TokenReward = 30,
                        Lectures = new List<Lecture>
                        {
                            new Lecture
                            {
                                Id = 3,
                                Title = "Основы MVC в ASP.NET",
                                Description = "Понимание архитектуры MVC в ASP.NET",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 15
                            },
                            new Lecture
                            {
                                Id = 4,
                                Title = "Работа с базами данных в ASP.NET",
                                Description = "Использование Entity Framework для взаимодействия с базой данных",
                                Materials = "Слайды и упражнения",
                                TokenReward = 20
                            }
                        },
                        Tests = new List<Test>
                        {
                            new Test
                            {
                                Id = 3,
                                Title = "Тест по основам MVC",
                                Description = "Проверьте свои знания MVC",
                                TokenReward = 35,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 10,
                                        Text = "Что означает MVC?",
                                        Answers = new List<string> { "Model View Controller", "Model Value Controller", "Main View Controller", "Model Value Control" },
                                        CorrectAnswer = "Model View Controller"
                                    },
                                    new Question
                                    {
                                        Id = 11,
                                        Text = "Какой метод используется для обработки GET-запросов в ASP.NET?",
                                        Answers = new List<string> { "GET", "Retrieve", "HttpGet", "Fetch" },
                                        CorrectAnswer = "HttpGet"
                                    }
                                }
                            },
                            new Test
                            {
                                Id = 4,
                                Title = "Тест по Entity Framework",
                                Description = "Проверьте свои знания работы с базами данных",
                                TokenReward = 40,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 12,
                                        Text = "Что такое DbContext в Entity Framework?",
                                        Answers = new List<string> { "Класс для подключения к базе данных", "Интерфейс для обработки запросов", "Библиотека для работы с HTTP-запросами", "Метод для выполнения миграций" },
                                        CorrectAnswer = "Класс для подключения к базе данных"
                                    },
                                    new Question
                                    {
                                        Id = 13,
                                        Text = "Какой атрибут используется для указания ключа в модели?",
                                        Answers = new List<string> { "[Key]", "[Primary]", "[Identity]", "[Unique]" },
                                        CorrectAnswer = "[Key]"
                                    }
                                }
                            }
                        },
                        Assignments = new List<Assignment>
                        {
                            new Assignment
                            {
                                Id = 3,
                                Title = "Создайте веб-API на ASP.NET",
                                Description = "Разработайте простое API, которое возвращает список продуктов.",
                                Deadline = DateTime.Now.AddDays(10),
                                TokenReward = 60
                            },
                            new Assignment
                            {
                                Id = 4,
                                Title = "Создайте приложение ToDo на ASP.NET",
                                Description = "Разработайте приложение для управления задачами с использованием базы данных.",
                                Deadline = DateTime.Now.AddDays(15),
                                TokenReward = 120
                            }
                        }
                    }
                },
                Quests = new List<Quest>
                {
                    new Quest
                    {
                        Id = 2,
                        Title = "ASP.NET Челлендж",
                        Description = "Выполните задания по ASP.NET",
                        TokenReward = 60,
                        Tasks = new List<QuestTask>
                        {
                            new QuestTask
                            {
                                Id = 3,
                                Text = "Создайте контроллер, который возвращает 'Hello, World!'",
                                Status = false
                            },
                            new QuestTask
                            {
                                Id = 4,
                                Text = "Добавьте поддержку CRUD операций в ваше веб-приложение.",
                                Status = false
                            }
                        }
                    }
                },
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 3,
                        Title = "Тест для новичков по ASP.NET",
                        Description = "Проверьте свои базовые знания ASP.NET.",
                        TokenReward = 25,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 9,
                                Text = "Какой атрибут используется для указания HTTP-глагола POST?",
                                Answers = new List<string> { "[Post]", "[HttpPost]", "[Send]", "[HttpSend]" },
                                CorrectAnswer = "[HttpPost]"
                            },
                            new Question
                            {
                                Id = 10,
                                Text = "Какой класс используется для создания контекста базы данных в ASP.NET?",
                                Answers = new List<string> { "DbContext", "DataContext", "SQLContext", "AppContext" },
                                CorrectAnswer = "DbContext"
                            }
                        }
                    },
                    new Quiz
                    {
                        Id = 4,
                        Title = "Тест по работе с базами данных",
                        Description = "Проверьте свои знания по взаимодействию с базой данных.",
                        TokenReward = 30,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 11,
                                Text = "Что делает метод SaveChanges() в Entity Framework?",
                                Answers = new List<string> { "Сохраняет изменения в базе данных", "Создает резервную копию данных", "Удаляет данные", "Обновляет структуру базы данных" },
                                CorrectAnswer = "Сохраняет изменения в базе данных"
                            },
                            new Question
                            {
                                Id = 12,
                                Text = "Какой тип отношения устанавливается с помощью атрибута [ForeignKey]?",
                                Answers = new List<string> { "Один-к-одному", "Один-ко-многим", "Многие-ко-многим", "Все вышеперечисленные" },
                                CorrectAnswer = "Один-ко-многим"
                            }
                        }
                    }
                }
            };

            var course3 = new Course
            {
                Id = 3,
                Title = "Основы JavaScript",
                Description = "Изучите основы программирования на JavaScript",
                ImgPath = "/images/Основы JavaScript.png",
                TokenReward = 60,
                Modules = new List<Module>
                {
                    new Module
                    {
                        Id = 3,
                        Title = "Введение в JavaScript",
                        Description = "Начало работы с JavaScript",
                        TokenReward = 25,
                        Lectures = new List<Lecture>
                        {
                            new Lecture
                            {
                                Id = 5,
                                Title = "Переменные и типы данных в JavaScript",
                                Description = "Понимание переменных и типов данных",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 12
                            },
                            new Lecture
                            {
                                Id = 6,
                                Title = "Функции и методы в JavaScript",
                                Description = "Изучение функций и методов в JavaScript",
                                Materials = "Слайды и упражнения",
                                TokenReward = 18
                            }
                        },
                        Tests = new List<Test>
                        {
                            new Test
                            {
                                Id = 5,
                                Title = "Тест по переменным и типам данных",
                                Description = "Проверьте свои знания переменных и типов данных",
                                TokenReward = 30,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 14,
                                        Text = "Какой ключевое слово используется для объявления переменной в JavaScript?",
                                        Answers = new List<string> { "var", "let", "const", "Все вышеперечисленные" },
                                        CorrectAnswer = "Все вышеперечисленные"
                                    },
                                    new Question
                                    {
                                        Id = 15,
                                        Text = "Какой тип данных представляет значение true или false?",
                                        Answers = new List<string> { "number", "string", "boolean", "object" },
                                        CorrectAnswer = "boolean"
                                    }
                                }
                            },
                            new Test
                            {
                                Id = 6,
                                Title = "Тест по функциям и методам",
                                Description = "Проверьте свои знания функций и методов в JavaScript",
                                TokenReward = 35,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 16,
                                        Text = "Что делает функция 'console.log()'?",
                                        Answers = new List<string> { "Выводит сообщение в консоль", "Создает новую переменную", "Открывает новое окно", "Запускает другой скрипт" },
                                        CorrectAnswer = "Выводит сообщение в консоль"
                                    },
                                    new Question
                                    {
                                        Id = 17,
                                        Text = "Какой метод используется для добавления элемента в конец массива?",
                                        Answers = new List<string> { "push()", "add()", "insert()", "append()" },
                                        CorrectAnswer = "push()"
                                    }
                                }
                            }
                        },
                        Assignments = new List<Assignment>
                        {
                            new Assignment
                            {
                                Id = 5,
                                Title = "Создайте простую игру 'Угадай число'",
                                Description = "Разработайте игру, в которой пользователь должен угадать число от 1 до 100.",
                                Deadline = DateTime.Now.AddDays(10),
                                TokenReward = 50
                            },
                            new Assignment
                            {
                                Id = 6,
                                Title = "Создайте веб-страницу с формой",
                                Description = "Разработайте веб-страницу с формой для сбора пользовательских данных.",
                                Deadline = DateTime.Now.AddDays(14),
                                TokenReward = 80
                            }
                        }
                    }
                },
                Quests = new List<Quest>
                {
                    new Quest
                    {
                        Id = 3,
                        Title = "JavaScript Челлендж",
                        Description = "Выполните задания по JavaScript",
                        TokenReward = 70,
                        Tasks = new List<QuestTask>
                        {
                            new QuestTask
                            {
                                Id = 5,
                                Text = "Напишите функцию, которая возвращает квадрат числа.",
                                Status = false
                            },
                            new QuestTask
                            {
                                Id = 6,
                                Text = "Создайте массив и выведите его элементы в консоль.",
                                Status = false
                            }
                        }
                    }
                },
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 5,
                        Title = "Тест для новичков по JavaScript",
                        Description = "Проверьте свои базовые знания JavaScript.",
                        TokenReward = 25,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 18,
                                Text = "Какой оператор используется для сравнения двух значений?",
                                Answers = new List<string> { "=", "==", "===", "Все вышеперечисленные" },
                                CorrectAnswer = "Все вышеперечисленные"
                            },
                            new Question
                            {
                                Id = 19,
                                Text = "Какой метод используется для преобразования строки в число?",
                                Answers = new List<string> { "parseInt()", "toString()", "Number()", "parseFloat()" },
                                CorrectAnswer = "parseInt()"
                            }
                        }
                    },
                    new Quiz
                    {
                        Id = 6,
                        Title = "Тест по функциям",
                        Description = "Проверьте свои знания функций в JavaScript.",
                        TokenReward = 30,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 20,
                                Text = "Какой ключевое слово используется для объявления функции?",
                                Answers = new List<string> { "function", "func", "declare", "define" },
                                CorrectAnswer = "function"
                            },
                            new Question
                            {
                                Id = 21,
                                Text = "Что такое стрелочная функция в JavaScript?",
                                Answers = new List<string> { "Функция без имени", "Функция, возвращающая значение", "Упрощенный синтаксис функции", "Все вышеперечисленные" },
                                CorrectAnswer = "Все вышеперечисленные"
                            }
                        }
                    }
                }
            };

            var course4 = new Course
            {
                Id = 4,
                Title = "Основы Python",
                Description = "Изучите основы программирования на Python",
                ImgPath = "/images/Основы Python.jpg",
                TokenReward = 70,
                Modules = new List<Module>
                {
                    new Module
                    {
                        Id = 4,
                        Title = "Введение в Python",
                        Description = "Начало работы с Python",
                        TokenReward = 30,
                        Lectures = new List<Lecture>
                        {
                            new Lecture
                            {
                                Id = 7,
                                Title = "Переменные и типы данных в Python",
                                Description = "Понимание переменных и типов данных в Python",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 15
                            },
                            new Lecture
                            {
                                Id = 8,
                                Title = "Условия и циклы в Python",
                                Description = "Изучение условий и циклов в Python",
                                Materials = "Слайды и упражнения",
                                TokenReward = 20
                            }
                        },
                        Tests = new List<Test>
                        {
                            new Test
                            {
                                Id = 7,
                                Title = "Тест по переменным и типам данных",
                                Description = "Проверьте свои знания переменных и типов данных в Python",
                                TokenReward = 35,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 22,
                                        Text = "Какой тип данных используется для хранения текстовых значений в Python?",
                                        Answers = new List<string> { "int", "str", "float", "bool" },
                                        CorrectAnswer = "str"
                                    },
                                    new Question
                                    {
                                        Id = 23,
                                        Text = "Какой оператор используется для проверки равенства в Python?",
                                        Answers = new List<string> { "=", "==", "!=", "all of the above" },
                                        CorrectAnswer = "=="
                                    }
                                }
                            },
                            new Test
                            {
                                Id = 8,
                                Title = "Тест по условиям и циклам",
                                Description = "Проверьте свои знания условий и циклов в Python",
                                TokenReward = 40,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 23,
                                        Text = "Какой оператор используется для проверки истинности в условии?",
                                        Answers = new List<string> { "if", "elif", "else", "Все вышеперечисленные" },
                                        CorrectAnswer = "Все вышеперечисленные"
                                    },
                                    new Question
                                    {
                                        Id = 24,
                                        Text = "Какой цикл используется для перебора элементов в списке?",
                                        Answers = new List<string> { "for", "while", "do while", "switch" },
                                        CorrectAnswer = "for"
                                    }
                                }
                            }
                        },
                        Assignments = new List<Assignment>
                        {
                            new Assignment
                            {
                                Id = 7,
                                Title = "Создайте программу для вычисления факториала числа",
                                Description = "Напишите программу, которая вычисляет факториал заданного числа.",
                                Deadline = DateTime.Now.AddDays(10),
                                TokenReward = 60
                            },
                            new Assignment
                            {
                                Id = 8,
                                Title = "Создайте простую веб-приложение на Flask",
                                Description = "Разработайте простое веб-приложение с использованием Flask.",
                                Deadline = DateTime.Now.AddDays(14),
                                TokenReward = 100
                            }
                        }
                    }
                },
                Quests = new List<Quest>
                {
                    new Quest
                    {
                        Id = 4,
                        Title = "Python Челлендж",
                        Description = "Выполните задания по Python",
                        TokenReward = 80,
                        Tasks = new List<QuestTask>
                        {
                            new QuestTask
                            {
                                Id = 7,
                                Text = "Напишите функцию, которая возвращает сумму всех элементов списка.",
                                Status = false
                            },
                            new QuestTask
                            {
                                Id = 8,
                                Text = "Создайте словарь и выведите его содержимое.",
                                Status = false
                            }
                        }
                    }
                },
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 7,
                        Title = "Тест для новичков по Python",
                        Description = "Проверьте свои базовые знания Python.",
                        TokenReward = 30,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 25,
                                Text = "Какой метод используется для добавления элемента в список?",
                                Answers = new List<string> { "append()", "add()", "insert()", "push()" },
                                CorrectAnswer = "append()"
                            },
                            new Question
                            {
                                Id = 26,
                                Text = "Какой ключевое слово используется для объявления функции в Python?",
                                Answers = new List<string> { "def", "function", "func", "declare" },
                                CorrectAnswer = "def"
                            }
                        }
                    },
                    new Quiz
                    {
                        Id = 8,
                        Title = "Тест по циклам",
                        Description = "Проверьте свои знания циклов в Python.",
                        TokenReward = 35,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 27,
                                Text = "Какой цикл используется для выполнения блока кода, пока условие истинно?",
                                Answers = new List<string> { "for", "while", "do while", "switch" },
                                CorrectAnswer = "while"
                            },
                            new Question
                            {
                                Id = 28,
                                Text = "Какой оператор используется для выхода из цикла?",
                                Answers = new List<string> { "break", "continue", "exit", "stop" },
                                CorrectAnswer = "break"
                            }
                        }
                    }
                }
            };

            var course5 = new Course
            {
                Id = 5,
                Title = "Основы веб-разработки",
                Description = "Изучите основы веб-разработки с HTML, CSS и JavaScript",
                ImgPath = "/images/Основы Веб-разработки.jpg",
                TokenReward = 80,
                Modules = new List<Module>
                {
                    new Module
                    {
                        Id = 5,
                        Title = "Введение в веб-разработку",
                        Description = "Основы веб-технологий",
                        TokenReward = 40,
                        Lectures = new List<Lecture>
                        {
                            new Lecture
                            {
                                Id = 9,
                                Title = "HTML: Структура веб-страницы",
                                Description = "Основы разметки с использованием HTML",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 20
                            },
                            new Lecture
                            {
                                Id = 10,
                                Title = "CSS: Стилизация веб-страниц",
                                Description = "Изучение CSS для оформления страниц",
                                Materials = "Слайды и упражнения",
                                TokenReward = 25
                            },
                            new Lecture
                            {
                                Id = 11,
                                Title = "JavaScript: Основы программирования на стороне клиента",
                                Description = "Введение в JavaScript для интерактивности",
                                Materials = "Конспекты лекций и примеры кода",
                                TokenReward = 25
                            }
                        },
                        Tests = new List<Test>
                        {
                            new Test
                            {
                                Id = 9,
                                Title = "Тест по HTML",
                                Description = "Проверьте свои знания основ HTML",
                                TokenReward = 35,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 29,
                                        Text = "Какой тег используется для создания гиперссылки?",
                                        Answers = new List<string> { "<link>", "<a>", "<href>", "<url>" },
                                        CorrectAnswer = "<a>"
                                    },
                                    new Question
                                    {
                                        Id = 30,
                                        Text = "Какой атрибут задает адрес ссылки?",
                                        Answers = new List<string> { "src", "href", "link", "address" },
                                        CorrectAnswer = "href"
                                    }
                                }
                            },
                            new Test
                            {
                                Id = 10,
                                Title = "Тест по CSS",
                                Description = "Проверьте свои знания основ CSS",
                                TokenReward = 35,
                                Questions = new List<Question>
                                {
                                    new Question
                                    {
                                        Id = 31,
                                        Text = "Какой селектор используется для выбора всех элементов на странице?",
                                        Answers = new List<string> { "*", ".", "#", "!" },
                                        CorrectAnswer = "*"
                                    },
                                    new Question
                                    {
                                        Id = 32,
                                        Text = "Какой свойство CSS используется для изменения цвета текста?",
                                        Answers = new List<string> { "color", "text-color", "font-color", "bg-color" },
                                        CorrectAnswer = "color"
                                    }
                                }
                            }
                        },
                        Assignments = new List<Assignment>
                        {
                            new Assignment
                            {
                                Id = 9,
                                Title = "Создайте простую веб-страницу с HTML",
                                Description = "Разработайте веб-страницу, используя только HTML.",
                                Deadline = DateTime.Now.AddDays(7),
                                TokenReward = 50
                            },
                            new Assignment
                            {
                                Id = 10,
                                Title = "Добавьте стили к вашей веб-странице с помощью CSS",
                                Description = "Оформите свою веб-страницу с использованием CSS.",
                                Deadline = DateTime.Now.AddDays(10),
                                TokenReward = 70
                            },
                            new Assignment
                            {
                                Id = 11,
                                Title = "Добавьте интерактивность с помощью JavaScript",
                                Description = "Используйте JavaScript для добавления интерактивных элементов на вашу страницу.",
                                Deadline = DateTime.Now.AddDays(14),
                                TokenReward = 100
                            }
                        }
                    }
                },
                Quests = new List<Quest>
                {
                    new Quest
                    {
                        Id = 5,
                        Title = "Веб-разработка Челлендж",
                        Description = "Выполните задания по веб-разработке",
                        TokenReward = 90,
                        Tasks = new List<QuestTask>
                        {
                            new QuestTask
                            {
                                Id = 9,
                                Text = "Создайте веб-страницу с заголовком и абзацем текста.",
                                Status = false
                            },
                            new QuestTask
                            {
                                Id = 10,
                                Text = "Добавьте стиль к элементам вашей страницы с помощью CSS.",
                                Status = false
                            }
                        }
                    }
                },
                Quizzes = new List<Quiz>
                {
                    new Quiz
                    {
                        Id = 9,
                        Title = "Тест для новичков по веб-разработке",
                        Description = "Проверьте свои базовые знания веб-разработки.",
                        TokenReward = 40,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 33,
                                Text = "Что такое CSS?",
                                Answers = new List<string> { "Язык разметки", "Язык стилей", "Язык программирования", "Язык базы данных" },
                                CorrectAnswer = "Язык стилей"
                            },
                            new Question
                            {
                                Id = 34,
                                Text = "Какой язык используется для создания интерактивных элементов на веб-странице?",
                                Answers = new List<string> { "HTML", "CSS", "JavaScript", "PHP" },
                                CorrectAnswer = "JavaScript"
                            }
                        }
                    },
                    new Quiz
                    {
                        Id = 10,
                        Title = "Тест по HTML и CSS",
                        Description = "Проверьте свои знания по HTML и CSS.",
                        TokenReward = 50,
                        Questions = new List<Question>
                        {
                            new Question
                            {
                                Id = 35,
                                Text = "Какой тег используется для создания заголовка в HTML?",
                                Answers = new List<string> { "<title>", "<h1>", "<header>", "<head>" },
                                CorrectAnswer = "<h1>"
                            },
                            new Question
                            {
                                Id = 36,
                                Text = "Какой атрибут используется для изменения фона страницы?",
                                Answers = new List<string> { "background", "bgcolor", "style", "color" },
                                CorrectAnswer = "bgcolor"
                            }
                        }
                    }
                }
            };

            Courses.AddRange(new[] { course1, course2, course3, course4, course5});
        }
    }
}
