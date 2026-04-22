# Правила для агента

## База данных

- Строка подключения — из appsettings.json проекта (Database=Calendar)
- MCP (postgres_query) по умолчанию подключается к test1
- Миграции: `dotnet ef migrations ...`, `dotnet ef dbcontext script`, `dotnet ef migrations list`

## Git

- PowerShell 5.1 НЕ поддерживает && — использовать `;` или несколько bash вызовов
- При коммите: только этот коммит, НЕ продолжать работу по плану
- После коммита сделать пуш

## Общее

- Не делать изменений без запроса. Сначала спрос — потом делать.
- После редактирования AGENTS.md — перечитать перед продолжением

## Технические решения проекта (утверждено)

| Решение | Значение |
|---------|----------|
| GUID | `Guid.CreateVersion7()` на клиенте + `.ValueGeneratedNever()` в EF |
| EXCLUDE constraint | `BookingLinkId` + `tstzrange(StartTimeUtc, EndTimeUtc) WITH &&` |
| EventType | Поддержка разных типов событий с разной длительностью |
| Timezone | IANA string из браузера (`Intl.DateTimeFormat().resolvedOptions().timeZone`) |
| DateTime | Всегда UTC (`DateTimeKind.Utc`), НЕ `Unspecified` |
| Текстовые поля | 256 — для маленьких, 1024 — для больших |