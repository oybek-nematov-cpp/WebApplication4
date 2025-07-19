# WebApplication4 - Tools API

Bu ASP.NET Core Web API loyihasi foydalanuvchiga quyidagi xizmatlarni taqdim etadi: tasodifiy son yaratish, ism bilan salomlashish, bugungi sanani ko‘rsatish, matn uzunligini hisoblash va sonning kvadrat ildizini topish.

## Endpointlar

### GET /api/tools  
0 dan 100 gacha tasodifiy son qaytaradi.  
**Misol:**  
`GET http://localhost:5000/api/tools`  
**Javob:**  
34

### GET /api/tools/greet?name=Ali  
2 soniya kutib, `Salom, Ali` javobini qaytaradi.  
**Misol:**  
`GET http://localhost:5000/api/tools/greet?name=Ali`  
**Javob:**  
"Salom, Ali"

### GET /api/tools/today  
Bugungi sanani `yyyy-MM-dd` formatida qaytaradi.  
**Misol:**  
`GET http://localhost:5000/api/tools/today`  
**Javob:**  
"2025-07-19"

### GET /api/tools/length?text=Salom  
Matn uzunligini qaytaradi.  
**Misol:**  
`GET http://localhost:5000/api/tools/length?text=Salom`  
**Javob:**  
5

### GET /api/tools/sqrt?value=81  
Berilgan sonning kvadrat ildizini hisoblaydi.  
**Misol:**  
`GET http://localhost:5000/api/tools/sqrt?value=81`  
**Javob:**  
9

## Texnologiyalar

- ASP.NET Core Web API
- C#
- RESTful API

## Natijalar

![photo_2025-07-19_21-40-50](https://github.com/user-attachments/assets/5c2f5618-6c33-40f4-9173-35fb3577cf6e)


![photo_2025-07-19_21-41-24](https://github.com/user-attachments/assets/a68129a9-a716-4161-84be-1df6921cfeb6)
![photo_2025-07-19_21-41-20](https://github.com/user-attachments/assets/1380ec74-37bb-483d-b47c-8e98f79b1174)
![photo_2025-07-19_21-41-12](https://github.com/user-attachments/assets/c7a82d80-2b49-49e7-932a-4df925c6580e)
![photo_2025-07-19_21-41-05](https://github.com/user-attachments/assets/64d9d04f-942c-4dbe-9d96-ad88f3457224)
