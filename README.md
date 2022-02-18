# GoogleCalendarEvetInsert
Çalışmada Google Calendar üzerine api olmadan url yardımı ile Event (etkinlik) ekleme işlemi gerçekleştiriyoruz.
<br/>
1.Verilen başlangıç tarihini istenilen formata çeviriyoruz.
<br/>
2.Verilen başlangıç saatini ve bitiş saatini istenilen formata çeviriyoruz
<br/>
3.Başlık değeri olarak gönderilen cümleyi, boşluklarından arındırıp yerine '+' simgesini koyuyoruz
<br/>
4.İçerik olarak gelen değerde de başlıkta olduğu gibi boşlukları '+' simgesi ile değiştiriyoruz. Ekstra olarak içerikte bir alt paragraf durumu var ise html '<br/>' etiket kullanarak bir alt satıra aktarıyoruz. 
<br/>
Eğer içerikte gönderim esnasında yazı özellikleri html etiketi olarak eklenirse kayıt öyle gerçekleşe bilmektedir.
