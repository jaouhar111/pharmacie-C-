using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApplication1
{
    class Class1
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=Pharmacie_app;Integrated Security=True");
        public DataSet ds = new DataSet();
        public SqlDataAdapter da;       
        public SqlDataAdapter da2;
        public SqlDataAdapter da1;
        public SqlDataAdapter da3;
        public SqlDataAdapter da4;
        public SqlDataAdapter da5;
        public SqlDataAdapter da6;
        public SqlDataAdapter da7;
        public SqlDataAdapter da8;
        public SqlDataAdapter da9;
        public SqlDataAdapter da10;

        public Class1()
        {
            da = new SqlDataAdapter("select idProduit as ID,NomProduit as Produits,Prix,Qte as Quantité,DateExpire,nomCategorie as Categorie from Produits join Categorie on Produits.idCategorie= Categorie.idCategorie", cn);
            da1 = new SqlDataAdapter("select * from categorie", cn);
            da10 = new SqlDataAdapter("select SUM(Somme),Status from Commande join detail on Commande.IdCommande=detail.idCommand group by Status", cn);
            da9 = new SqlDataAdapter("select * from connexion", cn);
            da8 = new SqlDataAdapter("select  id,CNI,NomPrenom,Adresse,dateNaissance from Connexion where Role='client'", cn);
            da7 = new SqlDataAdapter("SELECT SUM(Somme),DATEPART(WEEKDAY, DateCom) from detail group by DATEPART(WEEKDAY, DateCom)", cn);
            da6 = new SqlDataAdapter("SELECT TOP 7 NomProduit, Qte FROM Produits ORDER BY Qte, DateExpire ", cn);
            da5 = new SqlDataAdapter("select * from Connexion where Role='Client'", cn);
            da4 = new SqlDataAdapter("select idCommand,Produits.NomProduit as produit,detail.Qte as Quantité,Somme as Total,DateCom as  [La date] ,NomPrenom as Client , Status from Commande join Connexion on Commande.idUser=Connexion.Id join detail on detail.idCommand=Commande.IdCommande join Produits on Produits.idProduit=detail.idProduit", cn);
            da3 = new SqlDataAdapter("select NomPrenom as client,IdCommande as commande,Somme as Total from Connexion c join Commande co on c.Id=co.idUser join detail d on d.idCommand=co.IdCommande order by DateCom desc", cn);
            da2 = new SqlDataAdapter("select COUNT(Produits.idCategorie) as number,SUM(Produits.Qte) as Somme,nomCategorie from Categorie join Produits on Produits.idCategorie=Categorie.idCategorie group by nomCategorie", cn);
           
        }
         

    }

    
}
