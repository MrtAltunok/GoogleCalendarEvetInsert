# GoogleCalendarEvetInsert
Çalışmada Google Calendar (takvim) üzerine api olmadan url yardımı ile Event (etkinlik) ekleme işlemi gerçekleştiriyoruz.
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
<img alt="Resim" sizes="(min-width: 954px) 842px, (min-width: 801px) calc(100vw - 112px), calc(100vw - 64px)" src="https://blogger.googleusercontent.com/img/a/AVvXsEjf6Lo6ktXf_OeaJiQfg3HomYkGV4IuCpKIUoNBE8l6JO5cIMOuVPV1GUhM22tYcFHWe27_lp8k-yZyo-n553C2XdXm4jeh0lBHXg0GayVtoEAKpYsl-FuRCO_oeYsRaQFvvzqnmp5gTW5OHMo_VSDGVRaFSv2jkaiFYU737JUP3TMlKcO_XTH1qNo_Ww=w507-h375">

<img border="0" data-original-height="725" data-original-width="1421" height="248" src="https://blogger.googleusercontent.com/img/a/AVvXsEiNyYKjnlBcfwGUr_BA4PdDc_oKrJ8GcPlF02QPMpZIaTxaFe5UinkSH5cAziefFUt9gN941V-RmTomWFV8tt6Jr6bRg-1T7AmKRCBTVUFYf_KyC6iCXKx-ApllXAoJdBwDJ1_CFC90LWjoTGqqSppNeBmcE_Qui_8z4d3N2C6J7PnRbyIBTB9EdTw9DA=w487-h248" width="487">
