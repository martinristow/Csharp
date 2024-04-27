/////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////INFORMACII ZA KREATOR//////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////////////////MARTIN RISTOV - 102620/////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////DATUM NA ZAVRSUVANJE 5/24/2023//////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
//////////////////////POTREBNO VREME ZA KREIRANJE NA SAMATA APLIKACIJA : 17 CASA .///////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////
/////////////////////////////////VIZUELNO PROGRAMIRANJE//////////////////////////////////////////////
/////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace Seminarska_Igra//ime na proektoto
{   
    public partial class Form1 : Form
    {
        List<int>broevi=new List<int> {1,1,2,2,3,3,4,4,5,5,6,6,7,7,8,8,9,9,10,10,11,11,12,12,13,13,14,14,15,15,16,16,17,17,18,18 };
        //deklarirame lista od 36 elementi kade shto sekoj element kje zima po edna slika 
        int brojnaobidi;//broj na obidi za toa kolku pati sme kliknale na slikickite potocno eden obid e koga kje klikneme na dve
                        //slikicki , posle drug obid e koga ke klikneme pak na dve slikicki itn.
        string prv_klik;//prvo kliknato dugme , potocno prvo otvoreno pole 
        string vtor_klik;//vtoro kliknato dugme ,  potocno vtoro otvoreno pole 
        List<Button> slikii = new List<Button>();//kreirame lista od sliki 
        Button slika_1;//kopce1 kje ni bide prvata slika sto sme ja kliknale
        Button slika_2;//kopce2 kje ni bide vtorata slika sto sme ja kliknale
        int tajmer =150;//tajmerot go inicijalizirame na 150 sekundi 
        int namali_tajmer;//vrednosta na tajmer ja dodeluvame na promenlivata namali_tajmer kade shto podolu istiot go namaluvame za eden
        bool kraj_na_igrata=false;//na pocetok igrata ne ni e zavrsena 
        int broj_na_otvoreni_dugminja;//ova kje ni broi kolku polinja ni se otvoreni , potocno da ni go ispisuva rezultatot a rezultatot
                                      //kje se zgolemuva za eden sekoj pat koga ke pogodime dve isti slikicki     
        public Form1()//Pocetniot izgled na samata forma , koga aplikacijata ke bide startuvana
        {
            InitializeComponent();
            Prikazi_Sliki();//ja povikuvame funkcijata prikazi_sliki
            timer1.Enabled = true;//na pocetok go pravime da bide dostapen
            timer1.Interval = 1000;//intervalot go postavuvame na 1000 , toa znaci 1sekunda , a vo nasiot slucaj ke se namaluva za 1sekunda
            timer1.Stop();//timerot go postavuvame na stop odnosno da ne ni zapocnuva vednas na samiot pocetok
            this.WindowState= FormWindowState.Maximized;//koga ja startuvame samata aplikacija , da ni bide na celosen ekran a ne na mal ekran .
            broj_na_otvoreni_dugminja = 0;//go inicijalizirame na pocetokot na 0 otvoreni polinja
            button1.Text = "START";//stavame ime na button1 so tekst START
            label4.Visible = false;//gi pravime nevidlivi na samiot start istita kje se prikaze koga ke treba da se ispise porakata msg podolu ja imame
            label3.Visible = false;//nevidlivi se dodeka ne klikneme na dugmeto START
            label2.Visible = false;//nevidlivi se dodeka ne klikneme na dugmeto START
            label1.Visible = false;//nevidlivi se dodeka ne klikneme na dugmeto START
            this.BackColor = Color.LightCoral;//bojata na pozadinata na samata forma 
            button1.Font = new Font("Tahoma", 13, FontStyle.Bold);//Koristime font Tahoma so golemina od 13 i istiot tekst da bide boldiran
            label1.Font = new Font("New Times Roman", 10, FontStyle.Bold);//Koristime font New Times Roman so golemina od 13 i istiot tekst da bide boldiran
            label3.Font = new Font("New Times Roman", 10, FontStyle.Bold);//Koristime font New Times Roman so golemina od 13 i istiot tekst da bide boldiran
            label2.Font = new Font("New Times Roman", 10, FontStyle.Bold);//Koristime font New Times Roman so golemina od 13 i istiot tekst da bide boldiran
            button1.Focus();//pri samoto aktiviranje na formata fokusot vednas da ni bide na dugmeto Button1 
        }
        private void Zapocni_Igra(object sender,EventArgs e)//ovde ja povikuvame metodata Zapocni()
        {
            Zapocni();//znaci koga klikname na start se aktivira metodata Zapocni
        }
        private void Prikazi_Sliki()//prikazuvanje na slika 
        {
            int leva_pozicija = 50;//levata pozicija da bide na rastojanie od 50 od samata forma isto i za gornata pozicija 
            int gorna_pozicija = 50;
            int redovi = 0;//da se pocne od prviot red 
            for(int i = 0; i < 36; i++) //kreiranje na 36 polinja potocno 13 buttoni
            {
                Button slika=new Button();//definirame button so ime slika kade sto na pocetokot slikite kje ni bidat prezemani od 
                //samiot resurs 
                slika.Image = Resource1.icons8_sun_48;//prezemanje na slikata za na pocetokot samite buttoni ja imaat ovaa slika
                slika.Height = 70;//goleminata na slikata 
                slika.Width = 70;//sirinata na slikata
                
                slika.BackColor = Color.Cyan;//boja na samite buttoni 
                slika.Click += slika_Klik;// povrzuva kliknuvanje na slikata so metodot slika_Klik , znaci koga korisnikot kje klikne na slikata
                //ke se povika metodot slika_Klik.
                slikii.Add(slika);//ja dodavame slikata vo lista na slikii pogore definirana
                if(redovi<6)//Proveruvame dali brojot na redovi e pomal od 6 , ako e ispolnet uslovot togas se aktivira
                    //kodot vnatre vo samiot blok, potocno istiot se izvrsuva
                {                  
                    redovi++;//redovi go zgolemuvame za eden
                    
                    slika.Left= leva_pozicija;//postavuvame go leviot del na slikata na leva pozicija , znaci ova ja odreduva
                    //pozicijata po X oskata na samata forma
                    slika.Top=gorna_pozicija;//go postavuvame gorniot del od slikata na vrednosta na promenlivata gorna_pozicija.
                                             //ja odreduva samata pozicija na slikata po Y-oskata vo ovoj slucaj
                                             
                    this.Controls.Add(slika);//dodavame slika kako kontrola vo listata na kontroli na formata , potocno ovozmozuva
                    //prikazuvanje na slikata na samata forma .
                    leva_pozicija = leva_pozicija + 70;//ja azurirame ili pravime update na levata pozicija so dodavanje na 70
                    //za da se pomesti pozicijata na slednata slika na desno od momentalnata slika
                    
                }
                if(redovi==6)//ako vrednosta na redovi e ednakva na 6 togas da se aktivira blokot na naredbi vnatre
                {
                    slika.Image = Resource1.icons8_sun_48;
                    leva_pozicija = 50;//vrednosta na leva pozicija ja resetirame na 50 ova ni sluzi za da 
                    //se postavi pozicijata na slednata slika vo nov red.
                    gorna_pozicija += 70;//istoto go pravime i na gorna pozicija samo sto ovde dodavame +70 , znaci
                    //ova ke ni sluzi da se pomesti pozicijata na slednata slika nadolu na samata Y oska.
                    redovi = 0;//redovi go postavuvame na vrednost 0 odnosno go resetirame , za da se koristi za nov red na sliki
                }
            }
        }
        private void slika_Klik(object sender, EventArgs e)//metoda slika_Klik
        {
            if (kraj_na_igrata)//Proveruvame dali igrata e zavrsena , kraj na igra ima buleva promenliva ,
                //ako e zavrsena metodata kje se prekine so return, sto znaci deka nema da se izvrsi ostanatiot kod vo samata metoda.
            {
                return;
            }
            if(prv_klik==null)//Proveruvame dali prv klik promenlivata e nula, ako e nula togas ova e prvo kliknato kopce
                //i izvrsi go sledniot kod vnatre vo blokot
            {
                slika_1 = sender as Button;//go pretvara objektot sender vo tip button i se dodeluva na promenlivata slika_1 
                //a samiot sender e objekt kade sto go dava(predava) samiot nastat koga kopceto e kliknato

                if (slika_1.Tag!=null&&slika_1.Image==null)//proveruvame dali tag svojstvoto na slika1 ne e nula i dali image svojstovot
                    //na slika1 e nula, tagot se koristi za da se zacuva dopolnitelna informacija za samoto kopce a image svojstvoto
                    //go pretstvavuva samata slika na kopceto.
                {
                    slika_1.Image = Image.FromFile("C:\\Users\\PC\\source\\repos\\Seminarska_Igra\\Seminarska_Igra\\sliki/" + (string)slika_1.Tag + ".png");
                    //slikite gi prezimame od folderot sliki , site 18 sliki se smesteni vo samiot folder pod redni broevi od 1 do 18
                    prv_klik=(string)slika_1.Tag;//prv klik go postavuvame da bide na tag svojstvoto od slika1 
                }
                
            }
            else if (vtor_klik==null)//proveruvame dali vtor klik promenlivata e nula , ako e nula togas toa znaci
                //deka e ova vtoroto kliknato kopce i kodot vo blokot kje se izvrsi
            {
                slika_2=sender as Button;//go pretvara objektot sender vo tip button i se dodeluva na promenlivata slika_2 
                //a samiot sender e objekt kade sto go dava(predava) samiot nastat koga kopceto e kliknato
                if (slika_2.Tag!=null&&slika_2.Image==null)//proveruvame dali tag svojstvoto na slika1 ne e nula i dali image svojstovot
                //na slika1 e nula, tagot se koristi za da se zacuva dopolnitelna informacija za samoto kopce a image svojstvoto
                //go pretstvavuva samata slika na kopceto.
                {
                    slika_2.Image = Image.FromFile("C:\\Users\\PC\\source\\repos\\Seminarska_Igra\\Seminarska_Igra\\sliki/" + (string)slika_2.Tag + ".png");
                    //slikite gi prezimame od folderot sliki , site 18 sliki se smesteni vo samiot folder pod redni broevi od 1 do 18
                    vtor_klik = (string)slika_2.Tag;//prv klik go postavuvame da bide na tag svojstvoto od slika2
                }
            }
            else
            {
                Prikazi_Sliki(slika_1, slika_2);//ako i dvete kliknati kopcinja ne se nuli toa znaci deka imame
                //vekje dve kliknati kopcinja(sliki) i treba da gi prikazeme tie sliki a toa go pravime so metodata prikazi sliki
                //i davanje na slika1 i slika2 kako argumenti na samata metoda
            }
        }
        private void Prikazi_Sliki(Button A,Button B)
        {
            if (prv_klik==vtor_klik)//proveruvame dali prvklik i vtorklik se isti , odnosno dali imaat isti slikicki,
                //ako se isti toa znaci deka sme kliknale na dve isti sliki i treba da se izvrsi kodot vo samiot blok
            {
                A.Tag = null;//Tag svojstvoto na slika A se postavuva na vrednost null sto znaci deka slikite se par i treba da se
                //odstranat od samata igra 
                B.Tag = null;//Tag svojstvoto na slika A se postavuva na vrednost null sto znaci deka slikite se par i treba da se
                //odstranat od samata igra
                broj_na_otvoreni_dugminja++;//i koga imame vise eden pogoden par togas broj na otvoreni dugminja go zgolemuvame za 1
            }
            else//inaku ako ne sme ja pogodile samata slikicka togas se izvrsuvaat slednite naredbi od blokot
            {
                brojnaobidi++;//broj na obidi zgolemi go za eden , znaci sekoj pat koga nema da go pogodime parot 
                //brojot na obidi se zgolemuva se do samiot kraj 
                label1.Text =brojnaobidi + " obidi";//da se prikazuvat samite obidi 
            }
 
            prv_klik = null;//promenlivata prv klik ja postavuvame na vrednost null za da moze da se pocne nov ciklus za klikanje na sliki
            vtor_klik= null;//promenlivata vtor klik ja postavuvame na vrednost null za da moze da se pocne nov ciklus za klikanje na sliki

            

            foreach (Button slikicka in slikii.ToList())//ciklus za site kopcinja koj gi cuvame vo listata slikii 
            {
                if (slikicka.Tag != null)//ovde go proveruvame svojstvoto tag na sekoe kopce potocno slika dali e razlicno od null
                    //ako svojstvoto ne e null togas toa znace deka kopceto kje se otvori i soodvetnata slika e prikazana i 
                    //treba istata da se zatvori 
                {
                    
                    slikicka.Image = null;//svojstvoto image na kopceto e null znaci se otstranuva i kopceto stanuva prazno
                }
            }
            if (slikii.All(o=>o.Tag == slikii[0].Tag))//ako se pogodeni site sliki togas aktiviraj gi funkciite vnatre vo blokot
            {
                Zavrsi("Uspesno zavrsena igra !");//da se aktivira porakata od medotot zavrsi 
                timer1.Stop();//timerot prekinuva da broi , potocno zastanuva koga kje se pogodat site sliki
            }
            else
            {
                label4.Text="povise srekja sleden pat";//da se prikaze ovaa poraka ako ne e ispolneto baranjeto
                label4.Font = new Font("New Times Roman", 10, FontStyle.Bold);//tekstot da go ima navedeniot font , golemina i boldiran tekst
            }

        }
        private void Zapocni()//koga ke se aktivira metodata Zapocni vednas se aktivirat rabotite vo samata metoda
        {
            label3.Visible = true;//labelata stanuva vidliva
            label2.Visible = true;//labelata stanuva vidliva
            label1.Visible = true;//labelata stanuva vidliva
            broj_na_otvoreni_dugminja = 0;//go inicijalizirame na pocetna vrednost 0
            var random_broeivi = broevi.OrderBy(x => Guid.NewGuid()).ToList();//da se raspredelat samite sliki na random pozicii 
            //sekogas koga ke se klikne na dugmeto start
            broevi = random_broeivi;//vrednosta od random broevi ja dodeluvame na promenlivata broevi 
            for (int i=0;i<slikii.Count;i++)//ciklusot se izvrsuva za sekoe kopce od listata slikii 
                //promenlivata i go oznacuva indeksot na momentalnoto kopce vo samata lista
            {
                slikii[i].Image = null;//go postavuvame svojstvoto image na momentalnoto kopce na vrednost null, odnostno
                //ja otsranuva prikazanata slika od momentalnoto kopce
                slikii[i].Tag = broevi[i].ToString();//svojstvoto tag na tekovnoto kopce se postavuva na vrednosta od samata lista
                //broevi so soodveten indeks i vo nasiot slucaj , a vrednosta broevi[i]  go pretvorame vo tekst so pomos na
                //metodata ToString()
            }
            brojnaobidi = 0;//go inicijalizirame na nula potocno se resetira
            label1.Text = brojnaobidi + " obidi";//vo labela1 dodeluva broj na obidi kade sto istite kje gi ispecatime na formata
            label2.Text = "Preostanato vreme : " + tajmer;//preostanato vreme kade sto kje se prikazuva celo vreme se do 
            //zavrsuvanje na igrata potocno dodeka dojde do 0 ili pa do ispolnuvanje na samoto baranje
            kraj_na_igrata = false;//igrata koga e zapocnata ne e vednas zavrsena
            timer1.Start();//timerot zapocnuva da odbrojuva 
            namali_tajmer = tajmer;//vrednosta na tajmer ja dodeluvame na namali_tajmer
        }
        private void Zavrsi(string msg)
        {
            timer1.Stop();//timerot zavrsuva , odnosno se prekinuva
            kraj_na_igrata = true;//kraj na igrata go postavuvame na vrednost true bidejki igrata zavrsila i tuka zastanuva
            label4.Visible = true;//se prikazuva labelata 
            label4.Text = msg;//ja prezemame porakata od metodot i ja dodeluvame na samata labela
            label4.Font = new Font("New Times Roman", 10, FontStyle.Bold);//fontot na tekstot , golemina i boldiran tekst
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            Zapocni();//koga ke se klikne na button1 da se aktivira samata aplikacija
            button1.BackColor = Color.RoyalBlue;//bojata na samiot button ja promenuvame
            button1.ForeColor= Color.White;//bojata na tekstot vo samiot button        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            namali_tajmer--;//timerot pocnuva da se namaluva za eden znaci pocetna vrednost e 150 po
                            //edna pomunata sekunda kje stane 149 se taka do 0 ili pa se do samoto ispolnuvanje na baraniot uslov
            label2.Text = "Preostanato vreme : " + namali_tajmer;//labela koja sto kje ni ispecati preostanato vreme i preostanatite sekundi od timerot
            if(namali_tajmer <1)//ako timerot e pomal od eden da ni se aktivira metodot Zavrsi kade sto kje ni ja ispecati samata poraka.
            {
 
                Zavrsi("Vremeto istece povise srekja sleden pat!");//Se povikuva metodata Zavrsi so prosleden tekst kako argument
                foreach(Button kontrola in slikii)//prebaruvame vo slikii 
                {
                    if(kontrola.Tag!=null)//proveruvame dali tag svojstvoto na kontrola e razlicno od null i ako istiot
                        //uslov e ispolnet togas toa znaci deka samoto kopce e otvoreno i ima asocirana vrednost vo tag svojstovot
                    {
                        kontrola.Image = Image.FromFile("C:\\Users\\PC\\source\\repos\\Seminarska_Igra\\Seminarska_Igra\\sliki/" + (string)kontrola.Tag + ".png");
                        //se postavuva svojstvoto image na tekovnoto kopce(slika) vo nasiot slucaj so slika koja kje se vcita 
                        //od navedenata pateka koja e formirana spored vrednosta na tag svojstovoto na samoto kopce 
                    }
                }
            }
            if(broj_na_otvoreni_dugminja==0)//ako brojot na otvoreni polinja e ednakvo na 0 togas da ni se ispecati deka 
                //rezultatot na nasata igra e ednakva na 0 
            {
                label3.Text = "Rezultat : 0 otvoreni";

            }
            if(broj_na_otvoreni_dugminja!=0)//ako rezultatot e razlicen od 0 togas da ni go ispecati rezultatot
            {
                label3.Text = "Rezultat : " + broj_na_otvoreni_dugminja;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    

}

