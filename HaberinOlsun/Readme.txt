- Haberlerimiz olacak -- ok
- Kategorilerimiz olacak -- ok
- 1 kategoriye 1 den fazla haber ekleyebileceðiz. 
- 1 haberin 1 den fazla kategorisi olabilecek. --ok
- Köþe yazarlarýmýz olacak -- ok
- Köþe yazýlarýmýz olacak -- ok
- 1 yazar 1 den fazla köþe yazýsý yazabilecek. 
- Ana sayfada headerda kategoriler yatay sýrada listelenecek. --ok  
- Ana sayfada carousel olacak ve gündemin 10 haberine ait resimler burada olacak. -- ok
- Carouselin altýnda sol tarafta random 10 tane haber gösterilecek.
- Carouselin altýnda sað tarafta köþe yazarlarý listelenecek. --ok
- Haberlere týklandýðýnda haber detaylarý gösterilecek. 
- Köþe yazarlarýna týklandýðýnda yazara ait tüm köþe yazýlarý listelenecek. (Tarihe göre ters sýralý.)
- Kategorilere týklandýðýnda haberler tarihe göre ters sýralý listelenecek. 
- Bir haber açýldýðýnda okuma sayýsý 1 arttýrýlacak. -- ok


DB Adi: HaberinOlsun

Haberler
	- HaberId
	- Baslik
	- Tarih
	- Ozet
	- Detay
	- Kaynak
	- OkunmaSayisi
	- ResimURL

Kategori
	- KategoriId
	- Adi
	- Aciklama

HaberKategori
	- KategoriId
	- HaberId

KoseYazilari
	- YaziId
	- YazarId
	- Ozet
	- Detay

Yazarlar
	- YazarId
	- AdiSoyadi
	- ResimURL

Gundem
	- HaberId
	- Sira

