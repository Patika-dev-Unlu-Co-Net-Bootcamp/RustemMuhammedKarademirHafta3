# 3. Hafta Ödev
Veritabanı 
1. Patikadev yapısını düşünerek bir db oluşturun
  - eğitimler, öğrenciler,katılımcılar,eğitmenler,asistanlar, eğitimde öğrencilerin yoklamalarının ve başarı durumlarının tutulduğu tablolar olacaktır.
  - veritipleri ve ilişkiler belirtilmelidir.
2. trigger yazın
  - öğrenci yoklaması girildiğinde. yoklama durumuna göre başarı durumunu hafta bazlı olarak güncelleyin.(Örn: eğitim 7 hafta olsun. ilk iki hafta derslere katıldı ise başarı oranı 2/7 nin % olarak karşılı olmalı.)
3. stored procedure yazın
  - öğrencileri eğitimlere ekleyen bir procedure olacak. öğrenci belirtilen eğitim tarihinde herhangi başka bir eğitime kayıtlı olmamalıdır.
4. view yazın
  - eğitim bazlı öğrencileri listeleyin(gruplu olarak)

# Bonus
- Aynı yapıyı ef code first olarak sadece model bazında oluşturun

# Yapılanlar

1. Eğitimler, öğrenciler, eğitmenler, asistanlar, öğrenci yoklamaları ve başarı durumlarına ait ilişkisel tablolar oluşturuldu.
2. Tbl_Yoklama_Öğrenci tablosu altında **trg_YoklamayaGöreÖğrenciBasariDurumuGüncelleme** isimli trigger oluşturuldu.
3. Öğrencinin kayıtlı olduğu ders tarihlerini kontrol eden **up_EğitimeÖğrenciEkleme** isimli store procedure oluşturuldu.
4. Eğitim bazlı öğrencileri listeleyen **vw_EğitimeGöreÖğrencileriGetir** isimli view oluşturuldu.
