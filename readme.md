db - bootcamp17122023


## Создание проектов

- `dotnet new sln`
- `dotnet new webapi -n API`
- `dotnet new classlib -n Persistance`
- `dotnet new classlib -n Domain`

## Добавление проектов в файл решения
- `dotnet sln add API/API.csproj`
- `dotnet sln add Persistance/Persistance.csproj`
- `dotnet sln add Domain/Domain.csproj`

## Прописывание зависимостей
- `cd api`
- `dotnet add reference '../Persistance/Persistance.csproj'`
- `dotnet add reference '../Persistance/Persistance.csproj'`
- `cd API`
- `dotnet add reference '../Domain/Domain.csproj'`
- `cd Persistance`
- `dotnet add reference '../Domain/Domain.csproj'`

## Сборка проекта

- `dotnet restore`
- `dotnet build`

## Запуск проекта
- `dotnet watch --no-hot-reload`
- должен открыться браузер с ссылкой `http://localhost:XXXX/swagger/index.html`

## База данных

- `https://www.docker.com/get-started/` скачать docker
- `https://hub.docker.com/_/postgres` образ postgresql
- https://t.me/iksergeyru/176 как создать контейнер
- `https://www.pgadmin.org/download/` клиент pgAdmin

## Настройка api
- `cd persistance`
- `dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `cd api`
- `dotnet add package Microsoft.EntityFrameworkCore.Design`
- `dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design`

## dotnet ef tool

- `dotnet tool install --global dotnet-ef`

Перед выполнением инструкций удалить папку [Persistance/Migrations](./Persistance/Migrations)
- `dotnet ef migrations add init-migration -s API -p Persistance`
- `dotnet ef database update -s API`



============

```
SELECT
    c."Id" AS "UserId",
    c."FirstName",
    c."LastName",
    c."Description",
    c."TimeCerated" AS "UserCreatedTime",
    t."Id" AS "TelephoneId",
    t."Text" AS "TelephoneText",
    t."Create" AS "TelephoneCreatedTime",
    t."Telephone1",
    t."Telephone2",
    t."Telephone3"
FROM
    public."Contacts" c
JOIN
    public."UserTelephones" t ON c."Id" = t."UsernameId";
```


```
SELECT
    c."Id" AS "UserId",
    c."FirstName",
    c."LastName",
    c."Description",
    c."TimeCerated" AS "UserCreatedTime",
    t."Id" AS "TelephoneId",
    t."Text" AS "TelephoneText",
    t."Create" AS "TelephoneCreatedTime"
FROM
    public."Contacts" c
JOIN
    public."UserTelephones" t ON c."Id" = t."UsernameId"
-- WHERE c."Id" = '0a69e82e-c8ce-438e-b59d-ca7cbe6d039f';

-- -- -- SELECT count(*) FROM public."UserTelephones";
```
