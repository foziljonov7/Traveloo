# Traveloo

## Proyekt haqida

Ushbu proyekt Traveloo web dasturi va desktop loyihasi uchun yaratilgan. Bu dastur sayohatlar uchun CRM sistema sifatida foydalaniladi.

## Tashqi kerakli kutubxonalarni o'rnatish

### Ushbu proyekt ishga tushirish uchun quyidagi kutubxonalarni va package talab qiladi:

> - .NET Framework 7 versiya
> - Entity Framework 7
> - PostgreSQL ma'lumotlar bazasi

### Projectda ishlatilgan Nuget packages

- API

> - Microsoft.EntityFrameworkCore
> - Microsoft.EntityFrameworkCore.Design
> - Microsoft.EntityFrameworkCore.Tools
> - Npgsql.EntityFrameworkCore.PostgreSQL
> - BCrypt.Net-Next
> - Microsoft.AspNetCore.Authentication.JwtBearer
> - Microsoft.AspNetCore.Identity.EntityFrameworkCore
> - System.IdentityModel.Tokens.Jwt

 Kutubxonalarni qayta ishga tushurish uchun quyidagi komandalarni bajaring:
 
 ``` dotnet restore ```

Loyihani ishga tushirish uchun quyidagi qadamllarni bajaring:

**PostgreSQL ma'lumotlar bazasini sozlang.**

**Web.config** faylida kerakli sozlamalarni o'zgartiring.

Migratsiyalarni qayta ishga tushuring:

` dotnet ef database update `

**Dasturni ishga tushiring:**

` dotnet run `

Brauzeringizda **https://localhost:7220** manzilini oching.
> Qo'llanma
>> Qo'llanmaga bu havoladan o'ting, qo'llanmada dastur ishlatish, sahifalarni boshqarish va boshqa muhim funktsiyalarni ko'rish mumkin.

## Models

Ticket

> Id - int : random

> Fligth - string

> Price - double

> Date -> UTCNOW

Human

> Id - guid : NewGuid

> Firstname - string

> Lastname - string

> Age - int

> Phone - string

> Location - string

> CategoryId - int : virtual Category Id

> TicketId - int : virtual Ticket Id

Category

> Id - int

> Name - string

Identity

> Registration

>> Email

> Username

>> Password

> Login

>> Email

>> Password

Muallif
> Proyektning avtori: **Abdulvosid Foziljonov**

Lisensiya
> Ushbu proyekt **MIT litsenziyasi** asosida taqdim etilgan.
