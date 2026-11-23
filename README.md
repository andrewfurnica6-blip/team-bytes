# Team Bytes: OOP Workshop

Group project for the **Object-Oriented Programming** workshop (SDU Software Engineering, Sønderborg, 23-27 November 2026).
We are building a console application for **Sønderborg Library's digital media platform**: e-books, movies, songs, video games, apps, podcasts and images, used by Borrowers, Employees and Admins. The full brief is in [`doc/project_specification.md`](doc/project_specification.md).

## Team

| Member | GitHub | Role in Sprint 1 |
|---|---|---|
| Bogdan Furnica | [@andrewfurnica6-blip](https://github.com/andrewfurnica6-blip) | Created the repo, the C# project and the LaTeX editor |
| Fabio Telesca | [@FabioT551](https://github.com/FabioT551) | Pull and verify the build |
| *Teammate 3* | *@username* | Pull and verify the build |

## Build and run

Requires the [.NET SDK](https://dotnet.microsoft.com/download) 8.0 or newer.

```bash
git clone https://github.com/andrewfurnica6-blip/team-bytes.git
cd team-bytes
dotnet build
dotnet run --project src
```

Warnings are treated as errors (the workshop asks for code that compiles without warnings). Every push is also built by GitHub Actions (**Build C#** workflow).

## Repository layout

Follows the structure proposed in the workshop handout:

```
team-bytes/
├── README.md
├── TeamBytes.sln
├── doc/project_specification.md   program specification from the handout
├── var/data.csv                   data file (used from Sprint 3 / Extension 3)
├── src/                           C# console project (Presentation / Domain / Persistence come in Sprint 3)
├── test/                          unit test project (Sprint 4)
├── latex/                         our report, written in LaTeX
│   ├── report.tex                 main document
│   ├── sections/sprintN.tex       one file per sprint
│   └── figures/                   images used in the report
└── site/                          the browser-based LaTeX editor (GitHub Pages)
```

## Writing the report (LaTeX editor)

Open **https://andrewfurnica6-blip.github.io/team-bytes/** to edit the files in `latex/` in your browser.

1. Sign in with your own GitHub token: classic token, **public_repo** scope. The sign-in page links straight to the right GitHub settings page.
2. Pick a file, edit it, and press **Save & commit** (or Ctrl+S). Every save is a normal git commit under your name.
3. GitHub Actions compiles every top-level `latex/*.tex` file. About a minute later the PDF shows up under **Show PDF**. The status dot in the top-right corner goes green when the PDF is up to date, or red with a link to the LaTeX log if it didn't compile.

Tips:
- Keep each sprint in its own `sections/` file so two people rarely edit the same file at once. If someone saved a file after you opened it, the editor warns you instead of silently overwriting their work.
- Unsaved changes are kept in your browser, so a closed tab doesn't lose work.
- You can also edit the `.tex` files locally and push with git as usual. The site always shows what's on `main`.

## Sprints

- [x] **Sprint 1**: Project creation (repo, collaborators, C# project, README)
- [ ] **Sprint 2**: Requirements, verb-noun analysis, CRC cards, UML class diagram (Mermaid)
- [ ] **Sprint 3**: Implement the class diagram in C#
- [ ] **Sprint 4**: Unit tests
- [ ] **Extensions**: E1 capabilities, E2 sorting, E3 persistence, E4 borrow/return, E5 authentication

Work for Sprint 2 onwards goes on a feature branch and is merged into `main` with a pull request.
