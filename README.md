# Traveloo

**Traveloo - Sizning ushbu proyektning nomi**

## Proyekt haqida

Ushbu proyekt Traveloo web dasturi va desktop loyihasi uchun yaratilgan. Bu dastur sayohatlar bilan bog'liq ma'lumotlarni boshqarish imkonini beradi.

## Tashqi kerakli kutubxona va o'rnatish

Ushbu proyekt ishga tushirish uchun quyidagi kutubxonalarni va dasturlarni talab qiladi:

- .NET Framework 7 versiya
- Blazor 7
- WPF 7
- Entity Framework 7
- PostgreSQL ma'lumotlar bazasi

Kutubxonalarni o'rnatish uchun quyidagi komandalarni bajaring: <br> 
> ``` dotnet restore ```
<br>
Loyiha ishga tushirish <br>
Loyihani ishga tushirish uchun quyidagi qadamllarni bajaring:
<br>
>PostgreSQL ma'lumotlar bazasini sozlang. <br>
>> Web.config faylida kerakli sozlamalarni o'zgartiring.
Migratsiyalarni bajaring:
` dotnet ef database update `
<br>
Dasturni ishga tushiring: <br>
` dotnet run `
<br>
Brauzeringizda <a> http://localhost:5000 </a> manzilini oching. <br>
> Qo'llanma
>> Qo'llanmaga bu havoladan o'ting, qo'llanmada dastur ishlatish, sahifalarni boshqarish va boshqa muhim funktsiyalarni ko'rish mumkin.

Muallif
> Proyektning avtori: Abdulvosid Foziljonov

Lisensiya
> Ushbu proyekt MIT litsenziyasi asosida taqdim etilgan.
