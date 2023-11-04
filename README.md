# Traveloo

## Proyekt haqida

Ushbu proyekt Traveloo web dasturi va desktop loyihasi uchun yaratilgan. Bu dastur sayohatlar bilan bog'liq ma'lumotlarni boshqarish imkonini beradi.

## Tashqi kerakli kutubxona va o'rnatish

### Ushbu proyekt ishga tushirish uchun quyidagi kutubxonalarni va dasturlarni talab qiladi:

> - .NET Framework 7 versiya
> - Blazor 7
> - WPF 7
> - Entity Framework 7
> - PostgreSQL ma'lumotlar bazasi

 utubxonalarni o'rnatish uchun quyidagi komandalarni bajaring:
 
 ``` dotnet restore ```

Loyihani ishga tushirish uchun quyidagi qadamllarni bajaring:

**PostgreSQL ma'lumotlar bazasini sozlang.**

**Web.config** faylida kerakli sozlamalarni o'zgartiring.

Migratsiyalarni bajaring:

` dotnet ef database update `

**Dasturni ishga tushiring:**

` dotnet run `

Brauzeringizda **http://localhost:5000** manzilini oching.
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

> CategoryId - int : virtual Category

> TicketId - int : virtual Ticket

Category

> Id - int

> Name - string

Muallif
> Proyektning avtori: **Abdulvosid Foziljonov**

Lisensiya
> Ushbu proyekt **MIT litsenziyasi** asosida taqdim etilgan.
