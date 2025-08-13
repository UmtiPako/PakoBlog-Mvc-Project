# PakoBlog MVC Project

The **PakoBlog MVC** project is a fully functional blog application built with the ASP.NET Core MVC framework. It enables authors to publish posts, categorize content, manage comments, and interact with readers.

> This README provides setup instructions, project architecture details, and contribution guidelines. Update it as your project grows.

---

## 🚀 Features
- **Blog Post Management**: Create, edit, delete posts with support for drafts, published statuses, and scheduled publishing.
- **Category & Tag Support**: Organize content using categories and tags for better navigation.
- **Comment System**: Users can comment on posts. Admins can moderate: approve, hide, or delete comments.
- **User Authentication**: Secure access with roles like Admin, Editor, and Author.
- **UI & Styling**: Uses Bootstrap (or similar) for responsive design.
- **Search & Filtering**: Search posts by title, category, tags, or date.

---

## 📂 Project Structure
```
PakoBlog-Mvc-Project/
├── Controllers/      # MVC controllers
├── Models/           # Domain models
├── Views/            # Razor views
├── Data/             # Database context & migrations
├── Services/         # Business logic & services
├── wwwroot/          # Static assets (CSS, JS, images)
├── Program.cs        # Application entry point
├── appsettings.json  # Configuration settings
└── PakoBlog-Mvc-Project.csproj  # Project file
```

---

## 📦 Installation

1. **Clone the repository**:
   ```bash
   git clone https://github.com/UmtiPako/PakoBlog-Mvc-Project.git
   ```

2. **Navigate into the project directory**:
   ```bash
   cd PakoBlog-Mvc-Project
   ```

3. **Install dependencies**:
   ```bash
   dotnet restore
   ```

4. **Configure settings**:
   - Edit `appsettings.json` with your database connection string and any other required configurations.

5. **Apply database migrations**:
   ```bash
   dotnet ef database update
   ```

6. **Run the application**:
   ```bash
   dotnet run
   ```

7. Access the app at `https://localhost:5001` (or whichever port is configured).

---

## 🛠 Technologies Used
- **ASP.NET Core MVC** – Framework for building web apps
- **Entity Framework Core** – ORM for database access
- **C#** – Programming language
- **Bootstrap** (or similar) – Responsive UI framework
- **Razor Views** – Templating engine for generating HTML

---

## 🤝 Contributing

We welcome contributions! Here’s how to get started:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/YourFeatureName
   ```
3. Implement your changes and commit:
   ```bash
   git commit -m "Add feature: brief description"
   ```
4. Push your branch:
   ```bash
   git push origin feature/YourFeatureName
   ```
5. Open a Pull Request for review.

---

## 📄 License

This project is licensed under the **MIT License**. Please refer to the [LICENSE](LICENSE) file for full details.

