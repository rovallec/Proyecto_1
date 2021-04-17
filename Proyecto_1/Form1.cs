using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_1
{
    
    public partial class Form1 : Form
    {
        /*LISTAS*/
        EstructurasDeDatos.Lists.Lists profileList;
        EstructurasDeDatos.Lists.SimpleLists pixarList;
        EstructurasDeDatos.Lists.SimpleLists disneyList;
        EstructurasDeDatos.Lists.SimpleLists marvelList;
        EstructurasDeDatos.Lists.SimpleLists starwarsList;
        EstructurasDeDatos.Lists.SimpleLists natgeoList;
        EstructurasDeDatos.Lists.SimpleLists allLists;
        EstructurasDeDatos.Lists.SimpleLists resList;

        /*PILAS*/
        EstructurasDeDatos.Piles.Piles myList;

        /*COLAS*/
        EstructurasDeDatos.Queues.Queues continueWatching;

        /*VISTA*/
        /*PIXAR*/
        ImageList ilPixar = new ImageList();
        ImageList ilDisney = new ImageList();
        ImageList ilMarvel = new ImageList();
        ImageList ilStarwars = new ImageList();
        ImageList ilNatGeo = new ImageList();
        ImageList ilRes = new ImageList();

        /*MyList*/
        ImageList ilMylist = new ImageList();
        /*Continuar Viendo*/
        ImageList ilContinueWatching = new ImageList();

        /*INT*/
        int selectedMovie = 0;
        int selectedList = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            profileList = new EstructurasDeDatos.Lists.Lists();
            pixarList = new EstructurasDeDatos.Lists.SimpleLists();
            allLists = new EstructurasDeDatos.Lists.SimpleLists();

            myList = new EstructurasDeDatos.Piles.Piles();
            continueWatching = new EstructurasDeDatos.Queues.Queues();

            profileList.InsertAtLast("Raul Ovalle");
            cmbProfiles.Items.Add("Raul Ovalle");
            profileList.InsertAtLast("Evelyn Mejia");
            cmbProfiles.Items.Add("Evelyn Mejia");
            profileList.InsertAtLast("Simon Stiles");
            cmbProfiles.Items.Add("Simon Stiles");
            cmbProfiles.SelectedIndex = 0;

            EstructurasDeDatos.movies pixarMovies;
            pixarMovies = new EstructurasDeDatos.movies("MONSTERS INC", "https://laverdadnoticias.com/__export/1548971897900/sites/laverdad/img/2019/01/31/tarjetas-animadas-videos-de-monsters-inc-personalizados-d_nq_np_701952-mlv26507730508_122017-f.jpg_423682103.jpg",0);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("LOS INCREIBLES", "https://i.pinimg.com/originals/03/f8/e4/03f8e417b597952ce068aaa9aaec5981.jpg",1);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("TOY STORY 1", "https://images.penguinrandomhouse.com/cover/9781506717197",2);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("TOY STORY 2", "https://static.wikia.nocookie.net/cine/images/c/ce/Toy_Story_2_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20190623232252",3);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("TOY STORY 3", "https://static.wikia.nocookie.net/doblaje/images/2/29/TS3poster-crowd.jpg/revision/latest/top-crop/width/360/height/450?cb=20200724211622&path-prefix=es",4);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("CARS 1", "https://i.pinimg.com/originals/af/42/45/af42453619d769d7c1b98c6930f34465.jpg",5);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            pixarMovies = new EstructurasDeDatos.movies("CARS 2", "https://static.wikia.nocookie.net/cine/images/b/b0/Cars_2.jpg/revision/latest/top-crop/width/360/height/450?cb=20121107222319",6);
            pixarList.InsertAtLast(pixarMovies);
            allLists.InsertAtLast(pixarMovies);
            downloadBanner(pixarList, ilPixar, 0);

            disneyList = new EstructurasDeDatos.Lists.SimpleLists();
            EstructurasDeDatos.movies disneyMovies;
            disneyMovies = new EstructurasDeDatos.movies("ALADIN", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSp2c5GuMbOaihn8ihqah11r3XUxhuV29GW8A&usqp=CAU", 7);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("PHINEAS AND FERB", "https://m.media-amazon.com/images/M/MV5BMTc1NjcxNzg4MF5BMl5BanBnXkFtZTgwOTMzNzgyMDE@._V1_.jpg", 8);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("RALPH EL DEMOLEDOR", "https://images-na.ssl-images-amazon.com/images/I/71NRzl9PAJL.jpg", 9);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("THE PRINCE OF PERSIA", "https://images-na.ssl-images-amazon.com/images/I/81QRz2eHlNL._SL1265_.jpg", 10);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("TRON", "https://www.aceprensa.com/wp-content/uploads/elementor/thumbs/20526-0-ov13wpnfa04hhj6lghj6j73eud2e8v71xsnebdqwhs.jpg", 11);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("NARNIA", "https://static.wikia.nocookie.net/narnia/images/4/43/El_le%C3%B3n%2C_la_bruja_y_el_armario_poster.jpg/revision/latest/top-crop/width/360/height/450?cb=20180414192355&path-prefix=es", 12);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            disneyMovies = new EstructurasDeDatos.movies("LA PRINCESA Y EL SAPO", "https://www.paramiprincesa.com/wp-content/uploads/2020/04/la-princesa-tiana-la-princesa-y-el-sapo.jpg", 13);
            disneyList.InsertAtLast(disneyMovies);
            allLists.InsertAtLast(disneyMovies);
            downloadBanner(disneyList, ilDisney, 1);

            marvelList = new EstructurasDeDatos.Lists.SimpleLists();
            EstructurasDeDatos.movies marvelMovies;
            marvelMovies = new EstructurasDeDatos.movies("WANDA VISION", "https://mx.web.img2.acsta.net/c_310_420/pictures/21/02/01/16/54/3730739.jpg", 14);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("THE FALCON AND THE WINTER SOLDIER", "https://i.pinimg.com/originals/cd/f8/80/cdf8802b740de5cd555910e932dee4c2.png", 15);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("AVENGERS ENDGAME", "https://lumiere-a.akamaihd.net/v1/images/690x0w_f1b0509a.jpeg?region=0%2C0%2C690%2C1035", 16);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("CAPTAIN MARVEL", "https://static.wikia.nocookie.net/marvelcinematicuniverse/images/6/66/Captain_Marvel_-_P%C3%B3ster_Diciembre_2018.png/revision/latest?cb=20191029195629&path-prefix=es", 17);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("ANT MAN AND THE WASP", "https://images-na.ssl-images-amazon.com/images/I/819tOk0RMWL._SL1367_.jpg", 18);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("THOR", "https://www.ecartelera.com/carteles/8900/8905/007_m.jpg", 19);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            marvelMovies = new EstructurasDeDatos.movies("DOCTOR STRANGE", "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/562D1474D253F2F79A02350E7B0D8D8095B5425F2DCA48883CEDC39246F555A0/scale?width=1200&aspectRatio=1.78&format=jpeg", 20);
            marvelList.InsertAtLast(marvelMovies);
            allLists.InsertAtLast(marvelMovies);
            downloadBanner(marvelList, ilMarvel,2);

            starwarsList = new EstructurasDeDatos.Lists.SimpleLists();
            EstructurasDeDatos.movies starwarsMovie;
            starwarsMovie = new EstructurasDeDatos.movies("THE MANDALORIAN", "https://static.wikia.nocookie.net/esstarwars/images/3/30/TheArtofTheMandalorian%28Season_One%29.jpg/revision/latest?cb=20200701040145", 21);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("THE CLONE WARS", "https://static.wikia.nocookie.net/esstarwars/images/d/de/Star_Wars_The_Clone_Wars_Season_7_poster_2.jpg/revision/latest?cb=20200122154425", 22);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("REBELS", "https://m.media-amazon.com/images/M/MV5BY2Q1ZTAzNzMtMzlmNy00NjdjLThhYjgtMzgxN2ZkYmFhMDIwXkEyXkFqcGdeQXVyMjg5NDMwMQ@@._V1_.jpg", 23);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("EL ASCENSO DE SKYWALKER", "https://static.wikia.nocookie.net/esstarwars/images/0/05/EADS-Edici%C3%B3nExpandida.jpg/revision/latest?cb=20200910153400", 24);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("LOS ULTIMOS JEDI", "https://static.wikia.nocookie.net/esstarwars/images/f/f3/Los_%C3%9Altimos_Jedi_La_Novela.jpg/revision/latest?cb=20191004195856", 25);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("THE RETURN OF THE JEDI", "https://images-na.ssl-images-amazon.com/images/I/91H37HUG4kL._RI_.jpg", 26);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            starwarsMovie = new EstructurasDeDatos.movies("THE EMPIRE STRIKES BACK", "https://insidethemagic-119e2.kxcdn.com/wp-content/uploads/2020/09/scale-1-800x400.jpeg", 27);
            starwarsList.InsertAtLast(starwarsMovie);
            allLists.InsertAtLast(starwarsMovie);
            downloadBanner(starwarsList, ilStarwars, 3);

            natgeoList = new EstructurasDeDatos.Lists.SimpleLists();
            EstructurasDeDatos.movies natGeoMovies;
            natGeoMovies = new EstructurasDeDatos.movies("RUNNING WILD", "https://imagenes.montevideo.com.uy/imgnoticias/201410/_W933_80/472979.jpg", 28);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("LOS CICLOS DE LA TIERRA", "https://i2.wp.com/coolbites.mx/wp-content/uploads/2021/03/original_1615842125_ciclos_tierra.jpg?resize=1000%2C600&ssl=1", 29);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("LOS ELEGIDOS DE LA GLORIA", "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/D9AACCFAAB2B006CF0A4B14680358C7FCBDB026A644223BC9C8EC01EA039B821/scale?width=1200&aspectRatio=1.78&format=jpeg", 30);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("EL INCREIBLE DOCTOR POL", "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/2C58CC86EB1F43A09CD406CD25033D0FFD413F7C16AAC86F3A2ACEA864B5F0DD/scale?width=1200&aspectRatio=1.78&format=jpeg", 31);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("SECRETOS VETERINARIOS", "https://is4-ssl.mzstatic.com/image/thumb/tB6gvXraTxKcQ-egp976XA/1200x675.jpg", 32);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("NATGEO LAB", "https://foxtelecolombia.com/wp-content/uploads/2020/01/poster-natgeolab-2-660x440.jpg", 33);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            natGeoMovies = new EstructurasDeDatos.movies("RARO PERO CIERTO", "https://static.wikia.nocookie.net/doblaje/images/7/77/Rarocierto_poster.png/revision/latest?cb=20201021053831&path-prefix=es", 34);
            natgeoList.InsertAtLast(natGeoMovies);
            allLists.InsertAtLast(natGeoMovies);
            downloadBanner(natgeoList, ilNatGeo, 4);

            ilPixar.ImageSize = new Size(190, 190);
            lstPixar.LargeImageList = ilPixar;

            ilDisney.ImageSize = new Size(190, 190);
            lstviewDisney.LargeImageList = ilDisney;

            ilMarvel.ImageSize = new Size(190, 190);
            lstviewMarvel.LargeImageList = ilMarvel;

            ilStarwars.ImageSize = new Size(190, 190);
            lstviewStarWars.LargeImageList = ilStarwars;

            ilNatGeo.ImageSize = new Size(190, 190);
            lstviewNatGeo.LargeImageList = ilNatGeo;

            EstructurasDeDatos.Lists.SimpleLists tempList = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 1; i < pixarList.count; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)pixarList.GetFirst();
                tempList.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = 7 - i;
                lstPixar.Items.Add(lst);
            }

            pixarList = tempList;

            EstructurasDeDatos.Lists.SimpleLists tempList2 = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 1; i < disneyList.count; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)disneyList.GetFirst();
                tempList2.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = 7 - i;
                lstviewDisney.Items.Add(lst);
            }

            disneyList = tempList2;

            EstructurasDeDatos.Lists.SimpleLists tempList3 = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 1; i < marvelList.count; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)marvelList.GetFirst();
                tempList3.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = 7 - i;
                lstviewMarvel.Items.Add(lst);
            }

            marvelList = tempList3;

            EstructurasDeDatos.Lists.SimpleLists tempList4 = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 1; i < starwarsList.count; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)starwarsList.GetFirst();
                tempList4.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = 7 - i;
                lstviewStarWars.Items.Add(lst);
            }

            starwarsList = tempList4;

            EstructurasDeDatos.Lists.SimpleLists tempList5 = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 1; i < natgeoList.count; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)natgeoList.GetFirst();
                tempList5.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = 7 - i;
                lstviewNatGeo.Items.Add(lst);
            }

            natgeoList = tempList5;
        }

        private void downloadBanner(EstructurasDeDatos.Lists.SimpleLists movies, ImageList il, int cond)
        {
            EstructurasDeDatos.Lists.SimpleLists tempList = new EstructurasDeDatos.Lists.SimpleLists();
            for (int i = 1; i < movies.count; i++)
            {

                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)movies.GetFirst();
                tempList.InsertAtLast(movie);

                System.Net.WebRequest request = System.Net.WebRequest.Create(movie.img_path);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                il.Images.Add(bmp);
            }
            switch (cond)
            {
                case 0:
                    pixarList = tempList;
                    break;
                case 1:
                    disneyList = tempList;
                    break;
                case 2:
                    marvelList = tempList;
                    break;
                case 3:
                    starwarsList = tempList;
                    break;
                case 4:
                    natgeoList = tempList;
                    break;
                case 5:
                    resList = tempList;
                    break;
            }
        }

        private void downloadBanner(EstructurasDeDatos.Piles.Piles movies, ImageList il)
        {
            EstructurasDeDatos.Piles.Piles tempList = new EstructurasDeDatos.Piles.Piles();
            int max_count = movies.data_count;
            for (int i = 0; i < max_count; i++)
            {

                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)movies.Pop();
                tempList.Push(movie);

                System.Net.WebRequest request = System.Net.WebRequest.Create(movie.img_path);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                il.Images.Add(bmp);
            }
            myList = tempList;
        }

        private void downloadBanner(EstructurasDeDatos.Queues.Queues movies, ImageList il)
        {
            EstructurasDeDatos.Queues.Queues tempQueue = new EstructurasDeDatos.Queues.Queues();
            int max_count = movies.data_count;
            for (int i = 0; i < max_count; i++)
            {

                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)movies.Dequeue();
                tempQueue.Queue(movie);

                System.Net.WebRequest request = System.Net.WebRequest.Create(movie.img_path);
                System.Net.WebResponse resp = request.GetResponse();
                System.IO.Stream respStream = resp.GetResponseStream();
                Bitmap bmp = new Bitmap(respStream);
                respStream.Dispose();

                il.Images.Add(bmp);
            }
            continueWatching = tempQueue;
        }

        private void enableView()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            cmbProfiles.Visible = true;
            lstPixar.Visible = true;
            lstviewMylist.Visible = true;
            lstviewContinue.Visible = true;
            imgHeader.Visible = true;
            btnAdd.Visible = true;
            btnWatch.Visible = true;
            imgView.Visible = false;
            btnStop.Visible = false;
        }

        private void disableView()
        {
            cancelSearch();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            cmbProfiles.Visible = false;
            lstPixar.Visible = false;
            lstviewMylist.Visible = false;
            lstviewContinue.Visible = false;
            lstviewMarvel.Visible = false;
            lstviewStarWars.Visible = false;
            lstviewNatGeo.Visible = false;
            lstviewDisney.Visible = false;
            imgHeader.Visible = false;
            btnAdd.Visible = false;
            btnWatch.Visible = false;
            btnFind.Visible = false;
            btnCancel.Visible = false;
            imgView.Visible = true;
            btnStop.Visible = true;
        }

        private void closeView()
        {
            cancelSearch();
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            cmbProfiles.Visible = true;
            lstPixar.Visible = true;
            lstviewMylist.Visible = true;
            lstviewContinue.Visible = true;
            lstviewMarvel.Visible = true;
            lstviewStarWars.Visible = true;
            lstviewNatGeo.Visible = true;
            lstviewDisney.Visible = true;
            imgHeader.Visible = true;
            btnAdd.Visible = true;
            btnWatch.Visible = true;
            btnFind.Visible = true;
            btnCancel.Visible = true;
            imgHeader.Visible = false;
            btnAdd.Visible = false;
            btnWatch.Visible = false;
            imgView.Visible = false;
            btnStop.Visible = false;
        }
        private void lstPixar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPixar.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstPixar.SelectedItems[0].Index;
                selectedList = 0;
                Image img = ilPixar.Images[6 - lstPixar.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstPixar.SelectedItems.Clear();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            move_to();
        }

        private void btnWatch_Click(object sender, EventArgs e)
        {
            disableView();
            move_to();
        }

        private void lstviewMylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewMylist.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewMylist.SelectedItems[0].Index;
                selectedList = 1;
                Image img = ilMylist.Images[lstviewMylist.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewMylist.SelectedItems.Clear();
            }
        }

        private void move_to()
        {
            switch (selectedList)
            {
                case 0:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t = (EstructurasDeDatos.movies)pixarList.FindLists(selectedMovie);
                    EstructurasDeDatos.movies mv = new EstructurasDeDatos.movies(mv_t.name, mv_t.img_path, mv_t.id);
                    myList.Push(mv);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList = new EstructurasDeDatos.Piles.Piles();
                    int max_count = myList.data_count;
                    for (int i = 0; i < max_count; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                        myList = tempList;
                    break;

                case 2:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t_2 = (EstructurasDeDatos.movies)disneyList.FindLists(selectedMovie + 7);
                    EstructurasDeDatos.movies mv_2 = new EstructurasDeDatos.movies(mv_t_2.name, mv_t_2.img_path, mv_t_2.id);
                    myList.Push(mv_2);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList_2 = new EstructurasDeDatos.Piles.Piles();
                    int max_count_2 = myList.data_count;
                    for (int i = 0; i < max_count_2; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList_2.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                    myList = tempList_2;
                    break;

                case 3:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t_3 = (EstructurasDeDatos.movies)marvelList.FindLists(selectedMovie + 14);
                    EstructurasDeDatos.movies mv_3 = new EstructurasDeDatos.movies(mv_t_3.name, mv_t_3.img_path, mv_t_3.id);
                    myList.Push(mv_3);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList_3 = new EstructurasDeDatos.Piles.Piles();
                    int max_count_3 = myList.data_count;
                    for (int i = 0; i < max_count_3; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList_3.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                    myList = tempList_3;
                    break;

                case 4:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t_4 = (EstructurasDeDatos.movies)starwarsList.FindLists(selectedMovie + 21);
                    EstructurasDeDatos.movies mv_4 = new EstructurasDeDatos.movies(mv_t_4.name, mv_t_4.img_path, mv_t_4.id);
                    myList.Push(mv_4);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList_4 = new EstructurasDeDatos.Piles.Piles();
                    int max_count_4 = myList.data_count;
                    for (int i = 0; i < max_count_4; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList_4.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                    myList = tempList_4;
                    break;

                case 5:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t_5 = (EstructurasDeDatos.movies)natgeoList.FindLists(selectedMovie + 28);
                    EstructurasDeDatos.movies mv_5 = new EstructurasDeDatos.movies(mv_t_5.name, mv_t_5.img_path, mv_t_5.id);
                    myList.Push(mv_5);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList_5 = new EstructurasDeDatos.Piles.Piles();
                    int max_count_5 = myList.data_count;
                    for (int i = 0; i < max_count_5; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList_5.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                    myList = tempList_5;
                    break;

                case 6:
                    ilMylist.Images.Clear();
                    lstviewMylist.Clear();
                    var mv_t_6 = (EstructurasDeDatos.movies)resList.FindLists(resList.count - 2 - selectedMovie);
                    EstructurasDeDatos.movies mv_6 = new EstructurasDeDatos.movies(mv_t_6.name, mv_t_6.img_path, mv_t_6.id);
                    myList.Push(mv_6);
                    downloadBanner(myList, ilMylist);
                    ilMylist.ImageSize = new Size(190, 190);
                    lstviewMylist.LargeImageList = ilMylist;

                    EstructurasDeDatos.Piles.Piles tempList_6 = new EstructurasDeDatos.Piles.Piles();
                    int max_count_6 = myList.data_count;
                    for (int i = 0; i < max_count_6; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)myList.Pop();
                        EstructurasDeDatos.movies tmp_movie = new EstructurasDeDatos.movies(movie.name, movie.img_path, i);
                        tempList_6.Push(tmp_movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewMylist.Items.Add(lst);
                    }
                    myList = tempList_6;
                    break;
                case 1:
                    EstructurasDeDatos.Piles.Piles tempPile = new EstructurasDeDatos.Piles.Piles();
                    int count = myList.data_count;
                    int found = 0;
                    for (int i = 0; i < count; i++)
                    {
                        EstructurasDeDatos.movies curr_movie = (EstructurasDeDatos.movies)myList.Pop();
                        if (curr_movie.id == (count - 1 - selectedMovie))
                        {
                            EstructurasDeDatos.movies tm_mv = new EstructurasDeDatos.movies(curr_movie.name, curr_movie.img_path, continueWatching.data_count);
                            continueWatching.Queue(tm_mv);
                            ilMylist.Images.RemoveAt(i);
                            lstviewMylist.Items.RemoveAt(i);
                            found = 1;
                        }
                        else
                        {
                            EstructurasDeDatos.movies mov = new EstructurasDeDatos.movies(curr_movie.name, curr_movie.img_path, (i - found));
                            tempPile.Push(mov);
                        }
                    }
                    int cnt = tempPile.data_count;
                    for (int i = 0; i < cnt; i++)
                    {
                        EstructurasDeDatos.movies mov = (EstructurasDeDatos.movies)tempPile.Pop();
                        EstructurasDeDatos.movies tp_mv = new EstructurasDeDatos.movies(mov.name, mov.img_path, i);
                        myList.Push(tp_mv);
                    }
                    

                    ilContinueWatching.Images.Clear();
                    lstviewContinue.Clear();
                    downloadBanner(continueWatching, ilContinueWatching);
                    ilContinueWatching.ImageSize = new Size(190, 190);
                    lstviewContinue.LargeImageList = ilContinueWatching;

                    EstructurasDeDatos.Queues.Queues tempQueue = new EstructurasDeDatos.Queues.Queues();
                    count = continueWatching.data_count;
                    for (int i = 0; i < count; i++)
                    {
                        EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)continueWatching.Dequeue();
                        movie.id = i;
                        tempQueue.Queue(movie);
                        ListViewItem lst = new ListViewItem();
                        lst.Text = movie.name;
                        lst.ImageIndex = i;
                        lstviewContinue.Items.Add(lst);
                    }
                    continueWatching = tempQueue;
                    break;
            }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            if(selectedList != 1)
            {
                selectedList = 1;
                move_to();
            }
            closeView();
        }

        private void lstviewDisney_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewDisney.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewDisney.SelectedItems[0].Index;
                selectedList = 2;
                Image img = ilDisney.Images[6 - lstviewDisney.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewDisney.SelectedItems.Clear();
            }
        }

        private void lstviewMarvel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewMarvel.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewMarvel.SelectedItems[0].Index;
                selectedList = 3;
                Image img = ilMarvel.Images[6 - lstviewMarvel.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewMarvel.SelectedItems.Clear();
            }
        }

        private void lstviewStarWars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewStarWars.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewStarWars.SelectedItems[0].Index;
                selectedList = 4;
                Image img = ilStarwars.Images[6 - lstviewStarWars.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewStarWars.SelectedItems.Clear();
            }
        }

        private void lstviewNatGeo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewNatGeo.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewNatGeo.SelectedItems[0].Index;
                selectedList = 5;
                Image img = ilNatGeo.Images[6 - lstviewNatGeo.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewNatGeo.SelectedItems.Clear();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            resList = new EstructurasDeDatos.Lists.SimpleLists();
            label3.Text = "RESULTS:";
            lstviewRes.Visible = true;
            lstPixar.Visible = false;

            int count = allLists.count - 1;
            for (int i = 0; i < count; i++)
            {
                EstructurasDeDatos.movies current_movie = (EstructurasDeDatos.movies)allLists.GetFirst();
                if (current_movie.name.Contains(txtFind.Text))
                {
                    EstructurasDeDatos.movies setMovie = new EstructurasDeDatos.movies(current_movie.name, current_movie.img_path, resList.count-1);
                    resList.InsertAtLast(setMovie);
                }
            }
            downloadBanner(resList, ilRes, 5);


            ilRes.ImageSize = new Size(190, 190);
            lstviewRes.LargeImageList = ilRes;

            EstructurasDeDatos.Lists.SimpleLists tempList2 = new EstructurasDeDatos.Lists.SimpleLists();

            for (int i = 0; i < resList.count - 1; i++)
            {
                EstructurasDeDatos.movies movie = (EstructurasDeDatos.movies)resList.GetFirst();
                tempList2.InsertAtLast(movie);
                ListViewItem lst = new ListViewItem();
                lst.Text = movie.name;
                lst.ImageIndex = i;
                lstviewRes.Items.Add(lst);
            }

            resList = tempList2;
        }

        private void lstviewRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewRes.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewRes.SelectedItems[0].Index;
                selectedList = 6;
                Image img = ilRes.Images[lstviewRes.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewRes.SelectedItems.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cancelSearch();
        }

        private void cancelSearch()
        {
            label3.Text = "PIXAR:";
            lstviewRes.Visible = false;
            lstPixar.Visible = true;
        }

        private void lstviewContinue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstviewContinue.SelectedItems.Count > 0)
            {
                enableView();
                selectedMovie = lstviewContinue.SelectedItems[0].Index;
                selectedList = 6;
                Image img = ilContinueWatching.Images[lstviewContinue.SelectedItems[0].Index];
                imgView.Image = img;
                imgHeader.Image = img;
                lstviewRes.SelectedItems.Clear();
            }
        }
    }
}
