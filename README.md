                             🎮 HAFTANIN PROJESI = ADAM ASMACA (ADAM_ASMACA 📂)

--------------------------------------------------------------------------------------------------------------------------------

📖 HAFTANIN SORULARI:

🔶 1) (SPIRALMATRIS 📂) = Spiral Matris: NxN boyutlarında oluşturulan bir matrisin ve bu matrisi spiral şekilde
yazdıracak programın C# kodunu yazınız.

Örnek:

01 02 03 04 05

16 17 18 19 06

15 24 25 20 07

14 23 22 21 08

13 12 11 10 09

🔶 2) (MATRISCARPIMI 📂) = İki Matrisin Çarpımı: Kullanıcıdan alınan iki NxN matrisin çarpımını gerçekleştiren bir
program yazın ve sonucu ekrana yazdırın.

🔶 3) (ASALSAYITOPLAMLARI 📂) = N'e Kadar Asal Sayıların Toplamı: Kullanıcıdan alınan N sayısına kadar olan tüm asal
sayıların toplamını bulan bir program yazın.

🔷 4) (TECHCITY 📂) = Bir gün, büyük bir teknoloji şehri olan TechCity büyük bir felaketle karşı karşıya kaldı.
Şehrin merkezindeki büyük bir veri merkezine kötü amaçlı yazılım bulaştı ve tüm
bilgisayarlar ve sistemler tehlikeye girdi. Eğer bu yazılım durdurulamazsa, şehir tamamen
çökecek ve insanlar dijital kimliklerini kaybedecekler. TechCity'nin merkezindeki
mühendisler, durumu kurtarmak için çok hızlı düşünmek zorundalar. Şehrin veri
merkezindeki bilgisayar ağı, bir N x N boyutunda bir grid ile temsil ediliyor. Bu grid,
birbirine bağlı bilgisayar düğümlerinden oluşuyor ve bazı düğümler zarar görmüş
durumda. Şehir, 3 robot kullanarak zararı durdurmaya çalışacak. Ancak robotlar
birbirlerinden bağımsız çalışıyor ve aynı anda birden fazla düğüme müdahale
edebiliyorlar. Robotlar bir kez çalışmaya başladıklarında, zarar görmemiş bir düğüme
geçiş yapabiliyorlar ve komşu düğümlere (yukarı, aşağı, sağ, sol) müdahale edebiliyorlar.
Amaç, robotların şehirdeki en fazla düğümü kurtarmasıdır. Ancak robotlar aynı düğüme
birden fazla kez müdahale edemez. Her robot yalnızca bir düğüme bir kez müdahale
edebilir ve komşu düğümlere geçebilir.
Görev: Bir N x N boyutundaki grid'i (haritayı) ve robotların başlangıç noktalarını temsil
eden bir listeyi giriş olarak alan bir fonksiyon yazın. Bu fonksiyon, robotların kaç tane
düğümü kurtarabileceğini hesaplamalıdır.
Her bir hücre aşağıdaki değerlerle temsil edilir:
* 1: Bu düğüm zarar görmemiştir ve robot burayı kurtarabilir.
* 0: Bu düğüm zarar görmüş ve robot tarafından müdahale edilemez.
Her robot, sadece kendi komşu düğümlerine (yukarı, aşağı, sağ, sol) müdahale edebilir.
Robotlar aynı anda çalışacaklar ve robotlar aynı düğüme iki kez müdahale edemez.

Örnek:

Grid:

1 1 0 1
  
0 1 0 0

1 1 1 0

0 0 1 1

Başlangıç Pozisyonları:
Robot 1: (0, 0)
Robot 2: (2, 2)
Robot 3: (3, 3)
Açıklama:
* Robot 1 (0, 0) pozisyonundan başlayarak 2 düğüm kurtarır (sol üst köşedeki
düğümler).
* Robot 2 (2, 2) pozisyonundan başlayarak 3 düğüm kurtarır (alt ortadaki düğümler).
* Robot 3 (3, 3) pozisyonundan başlayarak 1 düğüm kurtarır (en sağ alt düğüm).
* Aynı düğümün birden fazla robot tarafından kurtarılmaması gerekir.
* Robotlar sadece komşu düğümlere hareket edebilir (yukarı, aşağı, sağ, sol).
* Her robot en fazla kaç düğüm kurtarabilir hesaplanmalı.
* Verilen grid ve başlangıç pozisyonlarına göre robotların optimal hareketi
belirlenmelidir.

🔷 5) (ALTINTAPINAK 📂) = Efsanelere göre, ormanın derinliklerinde saklı Altın Tapınak’a ulaşan kişi, tapınağın
içindeki paha biçilemez hazineyi bulacaktır. Ancak bu tapınağa ulaşmak o kadar kolay
değildir. Tapınağın etrafını kuşatan kadim bir labirent, içinde birçok tuzak ve çıkmaz
barındırıyor. Tapınağın içindeki hazineye ulaşabilmek için maceracılar N x N
boyutlarındaki bir labirentte doğru yolu bulmak zorunda. Labirent, 0 ve 1'lerden oluşan bir
grid ile temsil ediliyor. 1’ler yürünebilen yolları, 0’lar ise tuzaklar veya duvarları temsil
ediyor. Maceracılar, sadece 1 olan hücrelerde yürüyebilirler. Macera sırasında, maceracı
tapınağın girişinden (0, 0) hücresinden başlayarak (N-1, N-1) hücresindeki hazinenin
bulunduğu noktaya gitmek zorunda. Ancak bu yolculuk sırasında en kısa rotayı bulmak
çok önemlidir, çünkü tapınağın etrafındaki tuzaklar giderek kapanıyor. Maceracının
yukarı, aşağı, sağ ve sola doğru hareket edebildiğini unutmayın. Ayrıca sadece geçerli
hücrelere (1 olan hücrelere) adım atabilir.
Görev: Bu N x N boyutlarındaki labirentte maceracının başlangıç noktasından hazinenin
bulunduğu noktaya en kısa yolu bulması gerekiyor. En kısa yolu bulan bir fonksiyon yazın
ve kaç adımda hazinenin bulunduğunu hesaplayın. Eğer hazineye ulaşılamıyorsa, "Yol
Yok" sonucunu döndürün.

Örnek:

Labirent:

1 0 0 0

1 1 0 1

0 1 1 1

0 0 0 1

Çıktı:
En Kısa Yol: 6 adım
Açıklama:
* Maceracı (0, 0) noktasından başlayarak aşağı, sağ, aşağı, sağ, sağ, aşağı adımlarıyla hazineye
(3, 3) ulaşır. Bu yolculuk toplam 6 adımdır.
