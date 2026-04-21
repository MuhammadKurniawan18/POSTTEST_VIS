# 🧾 EasyKasir (VB.NET + MySQL)

Aplikasi kasir berbasis **VB.NET Windows Forms** yang terhubung dengan **database MySQL**.

Aplikasi ini mendukung fitur **CRUD (Create, Read, Update, Delete)** serta **pencarian data (Search)** sesuai dengan perintah tugas.

---

## 🚀 Fitur Utama

* ➕ Tambah data barang (Create)
* 📖 Tampilkan data barang (Read)
* ✏️ Update data barang (Update)
* ❌ Hapus data barang (Delete)
* 🔍 Pencarian barang secara real-time (Search)
* 🔄 Reset form input

---

## 📂 Struktur Database

Database: `kasirdb`
Tabel: `barang`

```sql
CREATE DATABASE kasirdb;

USE kasirdb;

CREATE TABLE barang (
    id_barang VARCHAR(10) PRIMARY KEY,
    nama_barang VARCHAR(100),
    harga INT,
    stok INT
);
```

---

## ⚙️ Konfigurasi Koneksi Database


```vb
server=localhost;user id=root;password=;database=kasirdb
```

---

## 🖥️ Tampilan Aplikasi

Fitur utama dalam 1 form:

* Input data barang
* Tombol CRUD (Tambah, Update, Hapus, Reset)
* Pencarian data
* DataGridView untuk menampilkan data

---

## 🚀 Pengembangan Selanjutnya

Aplikasi ini masih bisa dikembangkan menjadi:

* 🧾 Sistem transaksi kasir (penjualan)
* 💰 Perhitungan total & kembalian
* 🔐 Sistem login user
* 📊 Laporan penjualan

---
