using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Mapping;
using EXP.Model;

namespace EXP.Mapping
{
    /// <summary>
    /// Transforme l'objet ObjectModel en fonction du support de données en fonction des opérations CRUD défini par le Business
    /// L'héritage du DataMap doit correspondre à l'héritage du Business dans la couche métier.
    /// </summary>
    public class MapObjetModel:DataMap<ObjContact>
    {

        DBContactDataContext dbcontact;

        public override void Initialize(System.Data.IDbConnection connection)
        {
            //Code pour l'initialisation de la base de données
            //C'est le Business qui ouvre la base de données car c'est son rôle gérer les transactions.

            dbcontact = new DBContactDataContext(connection);

        }
        
        /// <summary>
        /// Ajout un contact dans la base de donnée
        /// </summary>
        /// <param name="myObject">Objet contact</param>
        /// <returns>Retourn l'objet ajouté incluant l'idetifiant assigné par la BD</returns>
        public override ObjContact Add(ObjContact myObject)
        {
            
            //Convertion de l'objet pour celui de la table
            Contact c=new Contact();
            c.Nom=myObject.Nom;
            c.Prenom=myObject.Prenom;
            c.Telephone=myObject.Telephone;

            dbcontact.Contacts.InsertOnSubmit(c);
            dbcontact.SubmitChanges();

            //remet le ID qui a ete créé par la base de donnée.
            myObject.Id = c.Id;
             
            return myObject; 
        }
        /// <summary>
        /// Charche un contact en fonction de son nom et prenom
        /// </summary>
        /// <param name="myObject">Objet contact</param>
        /// <returns>Retourn l'objet trouvé ou null</returns>
        public override ObjContact Select(ObjContact myObject)
        {
            //Converti l'objet pour celui de la table
            Contact c = dbcontact.Contacts.SingleOrDefault(x => x.Nom == myObject.Nom && x.Prenom==myObject.Prenom);

            if (c != null)
            {
                //Convertion de l'objet de BD en objet modele
                myObject.Id = c.Id;
                myObject.Nom = c.Nom;
                myObject.Prenom = c.Prenom;
                myObject.Telephone = c.Telephone;
                return myObject;
            }
            else
                return null;
        }
        
    }
}
