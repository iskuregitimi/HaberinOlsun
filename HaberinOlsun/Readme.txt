- Haberlerimiz olacak ++
- Kategorilerimiz olacak ++
- 1 kategoriye 1 den fazla haber ekleyebilece�iz. ++
- 1 haberin 1 den fazla kategorisi olabilecek. ++
- K��e yazarlar�m�z olacak ++
- K��e yaz�lar�m�z olacak ++
- 1 yazar 1 den fazla k��e yaz�s� yazabilecek. ++
- Ana sayfada headerda kategoriler yatay s�rada listelenecek. ++
- Ana sayfada carousel olacak ve g�ndemin 10 haberine ait resimler burada olacak. ++
- Carouselin alt�nda sol tarafta random 10 tane haber g�sterilecek. ++
- Carouselin alt�nda sa� tarafta k��e yazarlar� listelenecek. ++
- Haberlere t�kland���nda haber detaylar� g�sterilecek. ++
- K��e yazarlar�na t�kland���nda yazara ait t�m k��e yaz�lar� listelenecek. (Tarihe g�re ters s�ral�.) 
- Kategorilere t�kland���nda haberler tarihe g�re ters s�ral� listelenecek. 
- Bir haber a��ld���nda okuma say�s� 1 artt�r�lacak. 


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
	- HaberKategoriId
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
	- GundemId
	- HaberId
	- Sira

