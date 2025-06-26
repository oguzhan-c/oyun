# StageSelect Sistemi Dokümantasyonu

## Genel Bakış
StageSelect sistemi, oyuncuların farklı sahneler arasında gezinmesini ve karakter seçimi yapmasını sağlayan menü sistemidir.

## Sahne Yapısı
Oyunda toplam 4 sahne bulunmaktadır:
1. **Çöl (Desert)** - stageShowing = 1
2. **Buz (Ice)** - stageShowing = 2  
3. **Orman (Forest)** - stageShowing = 3
4. **Şehir (Town)** - stageShowing = 4

## Sahne Gezinme Sistemi

### Sağ Ok Tuşu (RBButton)
- Çöl → Buz
- Buz → Orman  
- Orman → Şehir
- Şehir → Çöl (döngü)

### Sol Ok Tuşu (LBButton)
- Buz → Çöl
- Orman → Buz
- Şehir → Orman
- Çöl sahnesinde sol ok görünmez

## Sahne Kilitleme Sistemi
Sahneler GlobalUnlocks sistemi ile kontrol edilir:
- **Çöl**: Her zaman açık
- **Buz**: GlobalUnlocks.iceUnlock == 1
- **Orman**: GlobalUnlocks.forestUnlock == 1  
- **Şehir**: GlobalUnlocks.townUnlock == 1

Kilitli sahnelerde:
- "LOCKED!" yazısı görünür
- PLAY butonu devre dışı kalır
- playLockout overlay aktif olur

## Karakter Seçimi Sistemi

### Mevcut Karakterler
1. **Timmy** - charPlayingAs = 1 (Jump tuşu)
2. **Arissa** - charPlayingAs = 2 (Fire1 tuşu)
3. **Michelle** - charPlayingAs = 3 (varsayılan)
4. **Doozy** - charPlayingAs = 4 (Fire2 tuşu)
5. **Claire** - charPlayingAs = 5 (Fire3 tuşu)
6. **The Boss** - charPlayingAs = 6 (RBButton tuşu)

### Karakter Kilitleme
- **Doozy**: GlobalUnlocks.doozyUnlock == 1
- **Claire**: GlobalUnlocks.claireUnlock == 1
- **The Boss**: GlobalUnlocks.bossUnlock == 1

## Animasyon Sistemi
Kamera animasyonları sahne geçişlerini sağlar:
- "DesertToIce", "IceToForest", "ForestToTown", "TownToDesert"
- "IceToDesert", "ForestToIce", "TownToForest"
- "CharFromDesert", "CharFromIce", "CharFromForest", "CharFromTown"

## Sahne Yükleme
- Oyun sahnesi: SceneManager.LoadScene(3)
- MenuBackground PlayerPrefs değeri stageToGoTo ile ayarlanır:
  - Çöl: 4
  - Buz: 5
  - Orman: 6
  - Şehir: 7

## Önemli Değişkenler

### Durum Değişkenleri
- `stageShowing`: Mevcut sahne numarası (1-4)
- `selectedStageNow`: Karakter seçimi modunda mı?
- `pressingButton`: Buton basma gecikme kontrolü
- `isMoving`: Animasyon sırasında input engelleme

### UI Bileşenleri
- `theCamera`: Sahne kamerası
- `stageName`: Sahne ismi metni
- `pressPlay`: Oynat butonu
- `rightArrow`, `leftArrow`: Gezinme okları
- `charSelButtons[]`: Karakter seçim butonları
- `fadeOut`, `fadeIn`: Geçiş efektleri

## Kullanıcı Girdileri
- **RBButton**: Sağa gezinme / Boss karakter seçimi
- **LBButton**: Sola gezinme
- **Jump**: Sahne seçimi / Timmy karakter seçimi
- **Fire1**: Arissa karakter seçimi
- **Fire2**: Doozy karakter seçimi  
- **Fire3**: Claire karakter seçimi

## Önemli Metodlar

### `ButtonDelay()`
- Sahne geçiş animasyonu sırasında UI güncelleme
- Sahne isimlerini ve ok görünümünü kontrol eder
- 1.1 saniye gecikme ile çalışır

### `CharSelect()`
- Karakter seçim ekranına geçiş
- Karakter butonlarını aktif hale getirir
- "PICK A RUNNER" mesajını gösterir

### `FadeToPlay()`
- Oyuna geçiş animasyonu
- Seçilen karakteri kayıt eder
- Yükleme ekranını gösterir