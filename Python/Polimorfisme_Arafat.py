class BangunDatar:
    def Luas(self):
        print("Menghitung Luas Bangun Datar")
    def Keliling(self):
        print("Menghitung Keliling Bangun Datar")

class Persegi(BangunDatar):
    def sisi(self):
        pass
    def Persegi(self):
        self.sisi=sisi
    def Luas(self):
        return self.sisi*self.sisi
    def Keliling(self):
        return 4*self.sisi

class PersegiPanjang(BangunDatar):
    def panjang(self):
        pass
    def lebar(self):
        pass
    def PersegiPanjang(self):
        self.panjang=panjang
        self.lebar=lebar
    def Luas(self):
        return self.panjang*self.lebar
    def Keliling(self):
        return 2*(self.panjang+self.lebar)

class Segitiga(BangunDatar):
    def alas(self):
        pass
    def tinggi(self):
        pass
    def Segitiga(self):
        self.alas=alas
        self.tinggi=tinggi
    def Luas(self):
        return 1/2*(self.alas*self.tinggi)

class Lingkaran(BangunDatar):
    def jari(self):
        pass
    def Lingkaran(self):
        self.jari=jari
    def Luas(self):
        return 3.14*self.jari*self.jari
    def Keliling(self):
        return 2*3.14*self.jari

class Main(object):
    print("=====Bangun Datar=====")
    print("1. Persegi")
    print("2. Persegi Panjang")
    print("3. Segitiga")
    print("4. Lingkaran")
    menu = int(input("Pilih Menu : "))

    bangundatar = BangunDatar()
    bangundatar.Luas()
    bangundatar.Keliling()
    
    if menu==1:
        print("=====Persegi=====")
        persegi=Persegi()
        persegi.sisi = int(input("Masukkan Sisi : "))
        print("Luas Persegi : ",persegi.Luas())
        print("Keliling Persegi : ",persegi.Keliling())
    elif menu==2:
        print("=====Persegi Panjang=====")
        persegipanjang=PersegiPanjang()
        persegipanjang.panjang = int(input("Masukkan Panjang : "))
        persegipanjang.lebar = int(input("Masukkan Lebar : "))
        print("Luas Persegi Panjang : ",persegipanjang.Luas())
        print("Keliling Persegi Panjang : ",persegipanjang.Keliling())
    elif menu==3:
        print("=====Segitiga=====")
        segitiga=Segitiga()
        segitiga.alas = int(input("Masukkan Alas : "))
        segitiga.tinggi = int(input("Masukkan Tinggi : "))
        print("Luas Segitiga : ",segitiga.Luas())
    elif menu==4:
        print("=====Lingkaran=====")
        lingkaran=Lingkaran()
        lingkaran.jari = int(input("Masukkan Jari-Jari : "))
        print("Luas Lingkaran : ",lingkaran.Luas())
        print("Keliling Lingkaran : ",lingkaran.Keliling())