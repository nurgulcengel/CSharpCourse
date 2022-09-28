using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odevlerim
{
    public class Belge
    {
        static int _belgeNo;
        string _belgeBaslik;
        string _icerik;
        bool _olusturuldumu;
        bool _guncellendimi;
        bool _onaylandımı;
        string _renkKodu;

        public Belge()
        {
            _belgeNo++;
        }

        public void BelgeOlusturma(string belgeBaslik, string renkKodu, string icerik = "")
        {

            if (!string.IsNullOrEmpty(belgeBaslik) && (renkKodu.ToLower() == "yeşil" || renkKodu.ToLower() == "sarı" || renkKodu.ToLower() == "kırmızı"))
            {
                Console.WriteLine(_belgeNo+belgeBaslik + " Belge oluşturuldu..");
                this._belgeBaslik = belgeBaslik;
                this._renkKodu = renkKodu;
                this._icerik = icerik;
                _olusturuldumu = true;

            }
            else
            {
                Console.WriteLine("Başlık giriniz..");
                _olusturuldumu = false;
            }

        }

        public void BelgeGuncelleme(string icerik)
        {
            if (_olusturuldumu)
            {
                this._icerik = icerik;
                Console.WriteLine(icerik + "İçerikteki belge güncellendi..");
                _guncellendimi = true;

            }
            else
            {
                Console.WriteLine("Hatalı işlem güncelleme yapılamadı..");
                _guncellendimi = false;
            }

        }

        public void BelgeOnaylama()
        {
            if (_guncellendimi)
            {
                Console.WriteLine("Belge Onaylandı..");
                _onaylandımı = true;
            }
            else
            {
                Console.WriteLine("Belge onaya gitmedi..");
                _onaylandımı = false;
            }

        }

        public void BelgeOnayGeriAlma()
        {
            if (_onaylandımı)
            {
                Console.WriteLine("Belge onayı geri çekildi");
                _onaylandımı = false;
            }
            else
            {
                Console.WriteLine("Onaya gitmedi..");
            }

        }

        public void BelgeGonderme()
        {
            if (_onaylandımı)
            {
                if (_renkKodu=="kırmızı")
                {
                    Console.WriteLine("Acilgönderim");
                }
                else if (_renkKodu == "sarı")
                {
                    Console.WriteLine("Normal gönderim");
                }
                else
                {
                    Console.WriteLine("Ertelemeli gönderim");
                }
                Console.WriteLine("Belge gönderildi..");
            }
            else
            {
                Console.WriteLine("Onaysız belge gönderilemedi..");
            }

        }


    }
}




/*
    Belge : no, baslik, içerik  alanlarını içeriyor olmalı
    Belge ile ilgili işlemler : oluşturma, güncelleme, onaylama, onay geri alma, gonderme

    oluşturma işlemi için   : sadece başlık bilgisi yeterli olmalı. Belge no otomatik ve sıralı bir şekilde oluşturulmalı
    güncelleme işlemi için  : oluşturulmuş olması gerekiyor
    güncelleme işlemi       : sadece içerik için yapılabilir
    onaylama için           : güncelleme işi bitmiş olması gerekiyor
    onay geri alma işlemi   : sadece onaylanmış belge için yapılabilir
    gönderme işlemi         : sadece onaylı belgeler gönderilebilir

    Bu sistemi oluşturmak için gereken Belge sınıfını tasarlayın ve tüm işlemleri test eden bir program yazınız.

    // Geliştirme : Sistemi oluşturduktan sonra
    - Belgelerin üç renk kodula etiketlenebilmesini sağlayınız. (Kırmız, Sarı, Yeşil)
    - Gönderme işleminin renk kodlarına göre faklı çalışmasını sağlayınız.

*/
