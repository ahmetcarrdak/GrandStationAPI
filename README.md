# Grand Station API

Grand Station API, kullanıcıların anlık verileri takip etmelerini sağlayan bir arka uç uygulamasıdır. Bu proje, ASP.NET Core kullanılarak geliştirilmiştir.

## İçindekiler

- [Özellikler](#özellikler)
- [Kurulum](#kurulum)
- [Kullanım](#kullanım)
- [API Uç Noktaları](#api-uç-noktaları)
- [Bağımlılıklar](#bağımlılıklar)
- [Geliştirme](#geliştirme)
- [Test](#test)
- [Lisans](#lisans)

## Özellikler

- JWT ile kimlik doğrulama
- PostgreSQL ile veri depolama
- Gerçek zamanlı veri güncellemeleri
- RESTful API tasarımı
- Swagger ile API belgeleri

## Kurulum

### Gereksinimler

- .NET SDK (v8.0 veya üstü)
- PostgreSQL

### Adımlar

1. **Projeyi Klonlayın**

   ```bash
   git clone https://github.com/kullaniciadi/grand-station-backend.git
   cd grand-station-backend
   ```

2. **Bağımlılıkları Yükleyin**

   ```bash
   dotnet restore
   ```

3. **Veritabanını Oluşturun**

   Veritabanı bağlantı dizesini `appsettings.json` dosyasına ekleyin. Örnek bir bağlantı dizesi:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Host=localhost;Database=grandstation;Username=yourusername;Password=yourpassword"
   }
   ```

4. **Veritabanı Migrations** (Gerekliyse)

   Veritabanı tablolarını oluşturmak için aşağıdaki komutları çalıştırın:

   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. **API'yi Başlatın**

   ```bash
   dotnet run
   ```

   API, varsayılan olarak `http://localhost:5000` adresinde çalışacaktır.

## Kullanım

API uç noktalarına erişmek için HTTP istemcisi (örneğin Postman) kullanabilirsiniz. Temel HTTP yöntemlerini kullanarak API ile etkileşimde bulunabilirsiniz (GET, POST, PUT, DELETE).

## API Uç Noktaları

### Kullanıcılar

- **GET** `/api/users` - Tüm kullanıcıları getirir.
- **POST** `/api/users` - Yeni bir kullanıcı oluşturur.
- **GET** `/api/users/{id}` - Belirtilen ID'ye sahip kullanıcıyı getirir.
- **PUT** `/api/users/{id}` - Belirtilen ID'ye sahip kullanıcıyı günceller.
- **DELETE** `/api/users/{id}` - Belirtilen ID'ye sahip kullanıcıyı siler.

### Örnek İstek

```http
GET /api/users HTTP/1.1
Host: localhost:5000
Authorization: Bearer <token>
```

## Bağımlılıklar

Projeniz için gerekli olan NuGet paketleri şunlardır:

- `BCrypt.Net-Next`: 4.0.3
- `Microsoft.AspNetCore.Authentication.JwtBearer`: 8.0.8
- `Microsoft.AspNetCore.OpenApi`: 8.0.8
- `Microsoft.EntityFrameworkCore`: 8.0.8
- `Microsoft.EntityFrameworkCore.Design`: 8.0.8
- `Microsoft.EntityFrameworkCore.Tools`: 8.0.8
- `Microsoft.IdentityModel.Tokens`: 8.1.1
- `Newtonsoft.Json`: 13.0.3
- `Npgsql.EntityFrameworkCore.PostgreSQL`: 8.0.8
- `StackExchange.Redis`: 2.8.16
- `Swashbuckle.AspNetCore`: 6.4.0
- `System.IdentityModel.Tokens.Jwt`: 8.1.1
- `System.Net.WebSockets`: 4.3.0

## Geliştirme

- **Yeni Özellik Eklemek İçin**: Yeni bir dal oluşturun ve özelliklerinizi geliştirin. Daha sonra ana dal ile birleştirin.

  ```bash
  git checkout -b yeni-ozellik
  # Değişikliklerinizi yapın
  git add .
  git commit -m "Yeni özellik eklendi"
  git checkout main
  git merge yeni-ozellik
  ```

## Test

Proje testlerini çalıştırmak için:

```bash
dotnet test
```

## Lisans

Bu proje [MIT Lisansı](LICENSE) altında lisanslanmıştır.
