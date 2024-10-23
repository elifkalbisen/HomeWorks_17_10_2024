# ViewBag, ViewData ve TempData Araştırması

## 1. ViewBag

- **Tanım**: `ViewBag`, controller'dan view'a veri geçirmek için dinamik bir nesne kullanır. `ViewBag`, `dynamic` tipinde olduğu için, herhangi bir veri türünü tutabilir.
- **Kapsam**: Sadece o anki request (istek) süresince geçerlidir. Bu nedenle sayfa yenilendiğinde veya başka bir sayfaya geçildiğinde veri kaybolur.
- **Kullanım Örneği**:
    ```csharp
    ViewBag.Message = "Merhaba Dünya!";
    return View();
    ```

## 2. ViewData

- **Tanım**: `ViewData`, `Dictionary` tipinde bir nesnedir ve key-value (anahtar-değer) çiftleri kullanarak veri taşır. `ViewData`, `string` tipinde anahtarlar alır ve herhangi bir veri türü tutabilir.
- **Kapsam**: `ViewBag` ile aynı şekilde, yalnızca o anki request süresince geçerlidir. Sayfa yenilendiğinde veya başka bir sayfaya geçildiğinde veri kaybolur.
- **Kullanım Örneği**:
    ```csharp
    ViewData["Message"] = "Merhaba Dünya!";
    return View();
    ```

## 3. TempData

- **Tanım**: `TempData`, veri geçici olarak depolamak için kullanılır ve veriler, bir request'ten (istek) sonraki request'e (istek) kadar saklanır. `TempData`, genellikle redirect (yönlendirme) işlemlerinden sonra veri saklamak için kullanılır.
- **Kapsam**: Bir sonraki request'te geçerlidir. Kullanıldıktan sonra otomatik olarak silinir, böylece bir sonraki istek için geçerli değildir.
- **Kullanım Örneği**:
    ```csharp
    TempData["Message"] = "Merhaba Dünya!";
    return RedirectToAction("Index");
    ```

## 4. Benzerlikler ve Farklar

| Özellik          | ViewBag                     | ViewData                     | TempData                       |
|------------------|-----------------------------|------------------------------|-------------------------------|
| **Tip**          | Dynamic                     | Dictionary<string, object>   | Dictionary<string, object>     |
| **Kapsam**       | Sadece mevcut request       | Sadece mevcut request        | Bir sonraki request           |
| **Kullanım Alanı**| View'a veri geçirme        | View'a veri geçirme          | Yönlendirme sonrası veri geçirme |
| **Veri Silme**   | Sayfa yenilendiğinde kaybolur | Sayfa yenilendiğinde kaybolur | Kullanıldığında kaybolur      |

## Özet

- **ViewBag** ve **ViewData**, bir view'a veri geçmek için kullanılır, ancak ViewBag dinamik bir yapı olduğu için daha esnek ve daha kolay kullanılabilirken, ViewData anahtar-değer çiftleri ile çalışır.
- **TempData** ise verilerin bir sonraki istekte kullanılabilmesi için geçici olarak saklanmasını sağlar ve yönlendirme işlemlerinde sıkça kullanılır.