# Правила проекта

## База данных

Строку подключения брать из appsettings.json проекта, а не из внешних инструментов (MCP, psql и т.п.).

При работе с миграциями использовать:
- `dotnet ef migrations ...` — работает с БД из appsettings.json
- `dotnet ef dbcontext script` — показать SQL скрипт
- `dotnet ef migrations list` — проверить применённые миграции

НЕ использовать для проверки состояния БД:
- postgres_query (MCP)
- psql
- любые внешние SQL-инструменты с другим подключением