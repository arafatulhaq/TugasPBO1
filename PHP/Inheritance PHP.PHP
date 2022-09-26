<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Project/PHP/PHPProject.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <p>
            =====Menghitung Bangun Datar=====<br>
            1. Menghitung Persegi<br>
            2. Menghitung Persegi Panjang<br>
            3. Menghitung Segitiga<br>
            4. Menghitung Lingkaran<br>
        </p>
        <form method="get">
            Pilih Menu = <input type="text"
                             name="menu"><br>
            <input type="submit">
        </form>

        <?php
        class BangunDatar{
            public function luas(){
                echo "Menghitung Luas Bangun Datar <br>\n";
                return 0;
            }
            public function keliling(){
                echo "Menghitung Keliling Bangun Datar <br>\n";
                return 0;
            }
        }
        
        class Persegi extends BangunDatar{
            public $sisi;
        }
        
        class Lingkaran extends BangunDatar{
            public $r;
        }
        
        class PersegiPanjang extends BangunDatar{
            public $panjang;
            public $lebar;
        }
        
        class Segitiga extends BangunDatar{
            public $alas;
            public $tinggi;
        }
        
        $bangundatar = new BangunDatar();
        $bangundatar->luas();
        $bangundatar->keliling();
        
        if($_GET["menu"]==1){
            $persegi = new Persegi();
            echo "<form method='get'>
            Masukkan Sisi = <input type='text'
                             name='sisi'><br>
                        <input type='submit'>
            </form>";
            $persegi->luas();
            $persegi->keliling();
        }
        if($_GET["menu"]==2){
            $persegipanjang = new PersegiPanjang();
            echo "<form method='get'>
            Masukkan Panjang = <input type='text'
                             name='panjang'><br>
            Masukkan Lebar = <input type='text'
                             name='lebar'><br>
                        <input type='submit'>
            </form>";
            $persegipanjang->luas();
            $persegipanjang->keliling();
        }
        if($_GET["menu"]==3){
            $segitiga = new Segitiga();
            echo "<form method='get'>
            Masukkan Alas = <input type='text'
                             name='alas'><br>
            Masukkan Tinggi = <input type='text'
                             name='tinggi'><br>
                        <input type='submit'>
            </form>";
            $segitiga->luas();
            $segitiga->keliling();
        }
        if($_GET["menu"]==4){
            $lingkaran = new Lingkaran();
            echo "<form method='get'>
            Masukkan Jari-Jari = <input type='text'
                             name='jari'><br>
                        <input type='submit'>
            </form>";
            $lingkaran->luas();
            $lingkaran->keliling();
        }
        ?>
    </body>
</html>