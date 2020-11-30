# Aplikasi Rubu' Mujayyab

Aplikasi android ini dibuat untuk membantu teman-teman menggambarkan penggunaan Rubu' Mujayyab. dilengkapi pula dengan muri dan syakul interaktif.
kami sadar masih banyak kekurangan dalam projek ini. Anda dapat langsung memperbaiki kodenya.

**ini projek Opensource, semua dapat mengedit, memperbaiki, menambah. semua senang :)** , semoga bisa bermanfa'at bagi siapapun yang menggunakanya. Amiin


# 
# Catatan Rilis
- Pada Android "Cubit" untuk memperbesar objek rubu'. di Windows cukup putar roda Mouse.
- Akan timbul efek "Paralaks" bila sudah sampai batas Zoom dan digerakan ke kanan/kiri, ini terjadi karna setiap objek memiliki Nilai Vector Z yang berbeda-beda.
- Qous = Sudut nilai diantara 0 sampai 90 derajat, bila melebihi itu akan dianggap nol. diukur dari Awal Qous, input Qous yang tersedia akan mengubah nilai Input menjadi Vector lalu syakul akan diposisikan ke nilai vector tsb. Script  ini terdapat pada "GetInput.cs" dan "Nilai Qous.cs" 

- Sitiini = Jaib Sittini nilai diantara 0 sampai 60 derajat,  rumus: **Sin ( Qous ) x 60**

-  Jaib T = Jaib Tamam nilai diantara 0 sampai 60 derajat, rumus: **Cos ( Qous ) x 60**

- Markaz = dalam projek ini kami menempatkan titik markaz pada lokasi vector **X : 27.1674** dan **Y : 27.2406** yang menjadi *child* object dari "Rubuk". alias bukan koordinat vector global. angka tersebut berdasarkan *ijtihad*/kira-kira saja.
- Tiap "Gerigi" di Qous dan Jaib bernilaikan 10 menit.
## Rencana kedepan:

 - [ ] Penambahan Dzil Mankus/Mabsut.
 - [ ] Pilihan untuk mengganti warna atau menyembunyikan objek.
 - [ ] Build untuk Platform Linux basis x86.


# Ketersedian Platform
## Android
Tersedia di Playstore dengan minimal Android Jelly bean. namun sangat disarankan menggunakan Android versi Lolipop v5.1 keatas.
[Unduh untuk android di sini](https://play.google.com/store/apps/details?id=com.kadzalik.rubuk)

## Windows
Tersedia untuk windows yang menggunakan basis arsitektur x86, belum dicoba untuk prosesor berbasis Arm. 
[Unduh untuk Windows di sini](https://drive.google.com/file/d/1IBel4d3hZLEjqfn5ag9-w5ALSuKEb8-v/view?usp=sharing)








# Pertanyaan-Jawaban

- *Gimana* cara menghitung waktu sholat pake aplikasi ini?
	>Wah panjang jawabanya, anda dapat belajar ilmu falak bersama di sini: [Grup Falak Facebook](https://www.facebook.com/groups/falakiyah)

- Mengapa Komputer saya tidak bisa jalan?
	>Coba matikan anti virus dahulu.

- di Android saya *kok ngga* bisa diinstal?
	> Aplikasi ini dibuat menggunakan bahasa C# yang bukan bahasa asal/native Android. kami menerjemahkanya menggunakan fitur Unity *Script Backend* ILPC2PP, jadi kemungkinan di bebrapa jenis android ( Terutama versi 5.1 kebawah ) akan terjadi error.

- Seberapa presisi rotasi Khoith?
	> Kami berusaha menempatkan markaz pada titik tersebut hanya sebatas kira-kira, tidak presisi khoith bisa saja timbul sebab itu. Anda bisa mengubah sendiri posisi markaz pada projek ini. 

- Saya ingin ikut berkontribusi dalam projek ini. tapi saya gak bisa ngoding, *gimana dong*?
	> Cukup email/inbox pada kami ide/saran/kritik anda. labkadzalik@gmail.com, Terimakasih






