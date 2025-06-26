# FEZA - Unity Oyun Projesi Dokümantasyonu

## Genel Bakış

**Feza**, Unity motorunda geliştirilmiş 3D endless runner türünde bir oyundur. Oyuncular farklı karakterlerle çeşitli temalı sahnelerde koşarak engelleri aşar, para ve değerli taşlar toplar, başarımları açar.

## Sahne Yapısı ve Oluşturma Sistemi

### Ana Sahneler

Oyun toplamda **10 ana sahne** içermektedir:

1. **SplashScreen.unity** - Başlangıç logosu ekranı
2. **MainMenu.unity** - Ana menü ekranı
3. **StageSelect.unity** - Sahne seçim ekranı
4. **Controls.unity** - Kontrol ayarları ekranı
5. **DesertRun.unity** - Çöl temalı koşu sahnesi
6. **ForestRun.unity** - Orman temalı koşu sahnesi
7. **IceRun.unity** - Buz temalı koşu sahnesi
8. **TownRun.unity** - Şehir temalı koşu sahnesi
9. **MashRun.unity** - Karma/özel sahne
10. **Rewards.unity** - Ödül sahnesi

### Prosedürel Seviye Üretim Sistemi

Oyun, **önceden hazırlanmış seviye bölümlerini** rastgele seçerek sonsuz bir koşu deneyimi yaratır:

#### **BlockGeneration.cs** - Ana Üretim Scripti
- **Amaç**: "Block Barrage" sahnesinin seviye üretimini yönetir
- **Çalışma Prensibi**:
  - 10 adet önceden hazırlanmış bölüm (`blockSection[0-9]`)
  - `Random.Range(0, 10)` ile rastgele seçim
  - Her 200 birimde yeni bölüm oluşturma
  - Tetikleyici (`OnTriggerEnter`) tabanlı üretim
- **Karakter Desteği**: 10 farklı oynanabilir karakter

#### **DesertGeneration.cs** - Çöl Sahne Üretimi
- **Amaç**: Çöl temalı sahnenin seviye üretimi
- **Mekanizma**:
  - 6 hazır bölüm (`blockSection[1-5]`)
  - `Random.Range(1, 6)` ile rastgele seçim
  - 200 birim aralık ve tetikleyici sistemi
- **Desteklenen Karakterler**: Timmy, Arissa, Michelle, Doozy, Claire, The Boss

#### **MashGeneration.cs** - Karma Sahne Üretimi
- **Amaç**: Özel "Mash" sahnesinin üretimi
- **Özellik**: **En yüksek çeşitlilik** - 50 farklı bölüm
- **Karakter Seçimi**: Oyuncu seçimi yerine rastgele karakter atama

## Karakter Sistemi

### Oynanabilir Karakterler
1. **Arissa** - Standart koşu animasyonu
2. **Claire** - Ninja idle animasyonu
3. **Doozy** - House Dancing animasyonu
4. **Michelle** - Tut Hip Hop Dance animasyonu
5. **Timmy** - Dance animasyonları
6. **The Boss** - Offensive Idle animasyonu
7. **Secret Character** - Chicken Dance (gizli karakter)

### Karakter Animasyon Sistemi
Her karakterin kendi `Animator Controller`'ı bulunmaktadır:
- **Idle** - Bekleme animasyonu
- **Standard Run** - Koşu animasyonu
- **Jump** - Zıplama animasyonu
- **Stumble Backwards** - Geriye tökezleme
- **Dans Animasyonları** - Karaktere özel dans hareketleri

## Kontrol Sistemi

### Klavye ve Mouse Kontrolleri
**PlayerControl.cs** scripti aracılığıyla:
- **A / Sol Ok** - Sola hareket
- **D / Sağ Ok** - Sağa hareket
- **Space / W / Yukarı Ok** - Zıplama

### Gamepad/Controller Desteği

#### **TestJoys.cs** - Controller Yönetimi
- **Xbox ve PlayStation** controller desteği
- Dinamik buton etiketlemesi
- `layoutSet` değişkeni ile platform seçimi (0=Xbox, 1=PlayStation)

#### **MainMenuButtons.cs** - Menü Controller Desteği
```csharp
// Xbox Butonları
public GameObject mainAButton, mainXButton, mainYButton, mainBButton;

// PlayStation Butonları  
public GameObject mainSquareButton, mainCircleButton, mainTriangleButton, mainCrossButton;
```

#### **Controller Özellikler**:
- **Xbox Layout**: A, B, X, Y, LB, RB, LT, RT, L3, R3 butonları
- **PlayStation Layout**: Cross, Circle, Square, Triangle, L1, R1, L2, R2, Share, Options butonları
- **Analog Stick Desteği**: Hareket için sol analog stick
- **Dinamik UI**: Controller tipine göre buton görselleri değişir

## Başarım (Achievement) Sistemi

### **GlobalAchievements.cs** - Ana Başarım Yöneticisi
- **27 farklı başarım** (A01-A27)
- **PlayerPrefs** ile kalıcı kayıt
- Otomatik kaydetme sistemi (`saveAchievements` flag)

### Başarım Trigger Sistemi
Her başarım için ayrı trigger scripti:
- **A01Trig.cs** - **A27Trig.cs** arası individual trigger'lar
- Belirli koşullar sağlandığında başarım açılması
- **GlobalAchDisplay.cs** ile başarım bildirim gösterimi

## Mağaza (Store) Sistemi

### Sanal Para Sistemi
- **Altın Paralar**: Oyun içi temel para birimi
- **Değerli Taşlar**: Premium para birimi
- **PlayerPrefs** ile ilerleme kaydı

### **GlobalCoinsGems.cs** - Para Yönetimi
```csharp
public static int totalCoins;    // Toplam altın
public static int totalGems;     // Toplam değerli taş
public static bool savedValues;  // Kayıt tetikleyicisi
```

### Store Controller Desteği
```csharp
// Mağaza navigasyon butonları
public GameObject storeAButton, storeBButton, storeXButton, storeYButton;
public GameObject storeLBButton, storeRBButton; // Karakter değiştirme
```

## Ses ve Müzik Sistemi

### **Audio Klasör Yapısı**:
- **Ana Müzikler**: 
  - `BlockBGM.mp3`, `DesertBGM.mp3`, `ForestBGM.mp3`
  - `IceBGM.mp3`, `MoonbaseBGM.mp3`, `TownBGM.mp3`
  - `StageSelect.mp3`, `CreditsBGM.mp3`, `RewardBGM.mp3`

- **Ses Efektleri (SFX)**:
  - `AchievementUnlocked.wav` - Başarım açma sesi
  - `ButtonSelect.wav` - Menü butonu sesi
  - `ChestOpen.wav` - Sandık açma sesi
  - `CoinSFX.wav` - Para toplama sesi
  - `JumpSound.wav` - Zıplama sesi
  - `FootSteps` sesleri (kumsal, kar)

## Veri Yönetimi ve Kayıt Sistemi

### **PlayerPrefs Kullanımı**
Oyun ilerlemesi `PlayerPrefs` ile kaydedilir:
```csharp
// Toplam istatistikler
PlayerPrefs.GetInt("TotalDistance");
PlayerPrefs.GetInt("TotalCoins");
PlayerPrefs.GetInt("TotalGems");

// Başarımlar
PlayerPrefs.GetInt("Achievement01"); // ... Achievement27
```

### **LoadAllValuesIn.cs** - Veri Yükleme
- Oyun başlangıcında tüm kaydedilmiş verileri yükler
- UI elementlerini günceller
- Önceki oturum kontrolü (`hasPrevious` flag)

## Animasyon Sistemi

### **Animator Controller'lar**
Her sahne için özel animasyon sistemleri:
- **Kamera Animasyonları**: `CamThud.anim`, `MenuCamAnim.anim`
- **UI Animasyonları**: `FadeIn.anim`, `FadeOut.anim` serisi
- **Karakter Geçiş Animasyonları**: Sahne arası geçişler
- **Ödül Animasyonları**: `RewardFadeIn.anim`, `ChestOpen.anim`

## Çarpışma (Collision) Sistemi

### **GlobalCollisionDetect.cs** - Ana Çarpışma Yöneticisi
- Oyuncu-engel çarpışmalarını tespit eder
- Can kaybı sistemini tetikler
- Çarpışma durumunda animasyon ve ses efektlerini çalar

### Özel Çarpışma Scriptleri
- **CoinCollision.cs** - Para toplama
- **GemCollision.cs** - Değerli taş toplama  
- **ObjectCollision.cs** - Genel engel çarpışması
- **DeductLife.cs** - Can kaybı işlemi

## Sahne Geçiş Sistemi

### **StageSelect** Sistemi
- Oyuncunun hangi sahneyi seçtiğini takip eder
- Karakter seçimini yönetir (`charPlayingAs`)
- Sahne ID'lerine göre yönlendirme yapar

### **ControlSceneMaster.cs** - Kontrol Rehberi
- Her sahne öncesi kontrol bilgilerini gösterir
- Controller tipine göre uygun buton görselleri
- Sahne arkaplan görsellerini yönetir

---

## Teknik Özellikler

- **Unity Versiyonu**: Modern Unity LTS
- **Platform Desteği**: PC (Windows/Mac/Linux)
- **Controller Desteği**: Xbox & PlayStation gamepad'leri
- **3D Grafik**: Low-poly sanat stili
- **Müzik**: Sahneye özel background müzikleri
- **Kayıt Sistemi**: PlayerPrefs tabanlı ilerleme kaydı
- **Performans**: Object pooling ve otomatik garbage collection

## Oyun Akışı

1. **Başlangıç**: SplashScreen → MainMenu
2. **Sahne Seçimi**: StageSelect → Controls 
3. **Oyun**: Desert/Forest/Ice/Town/Mash Run sahneleri
4. **Sonuç**: Rewards → MainMenu döngüsü

*Bu dokümantasyon Unity projesi analiz edilerek hazırlanmıştır. Oyun içi görseller sonradan eklenecektir.*