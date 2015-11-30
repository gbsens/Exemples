using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MKS.Web;
using MKS.Core.Presenter.UI;

using EXP.Presenter;
using System.Text;


namespace EXP.UI
{
    /// <summary>
    /// Implémante la vue défini dans la couche de présentation  et fais l'assignation au contrôles de la page web.
    /// Hérite du MKS.Web.MVP.Page pour supporter les fonctions incluse dans le IView.    
    /// </summary>
    public partial class Default : MKS.Web.MVP.Page, IModelVue
    {
        PresenterModelVue p;

        protected void Page_Load(object sender, EventArgs e)
        {
            p = new PresenterModelVue(this);
            p.Start();
        }
        protected void btnSauvegarder_Click(object sender, EventArgs e)
        {
            // Envoi la commade Sauvegarder tel que défini dans l'Initialisation du processus. L'opération est également défini dans le processus
           ExecuteCommand(_Sauvegarder.Command);
        }
        protected void btnAbout_Click(object sender, EventArgs e)
        {
            // Envoi la commade About tel que défini dans l'Initialisation du processus. L'opération est également défini dans le processus
            ExecuteCommand(_About.Command);
        }

        
        #region surcharge de la page de base
        public string _MessageTitre;
        public string _MessageDescription;
        public string _MessageSeverity;

        
        public override void ShowMessage(string title, string message, MKS.Core.Severity severity)
        {
            _MessageTitre = title;
            _MessageDescription = message;
            switch (severity)
            {
                case MKS.Core.Severity.Error:
                    //msg.ForeColor = System.Drawing.Color.Red;
                    _MessageSeverity = "danger";

                    break;

                case MKS.Core.Severity.Warning:
                    //msg.ForeColor = System.Drawing.Color.OrangeRed;
                    _MessageSeverity = "warning";

                    break;

                case MKS.Core.Severity.Information:
                    //msg.ForeColor = System.Drawing.Color.Blue;
                    _MessageSeverity = "info fade in";

                    break;

                case MKS.Core.Severity.Success:
                    //msg.ForeColor = System.Drawing.Color.Green;
                    _MessageSeverity = "success fade in";
                    
                    break;

                default:
                    break;
            }
        }
        public override void ShowBusinessValidation(string title, string message, MKS.Core.ProcessResults processResults)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in processResults.MessagesList)
            {
                sb.AppendFormat("{0} - {1}", item.CodeMessage, item.Description);
                sb.Append("<br>");
            }
            _MessageDescription = sb.ToString();
            ShowMessage(title, _MessageDescription, MKS.Core.Severity.Warning);
        }
        public override void ShowContextValidation(string title, string message, List<MKS.Core.ReturnMessage> result)
        {
            _MessageTitre = title;
            _MessageSeverity = "danger";

            StringBuilder sb = new StringBuilder();
            foreach (var item in result)
            {
                sb.AppendFormat("{0} - {1}",item.CodeMessage, item.Description);
                sb.Append("<br>");
            }            
            _MessageDescription = sb.ToString();
        }
        #endregion

        #region Implémentation de la vue



        public MKS.Core.Presenter.UI.Label LabelNom
        {
            get
            {
                return null;
            }
            set
            {
                lblNom.Text = value.Text;
            }
        }
        private MKS.Core.Presenter.UI.Input _Nom = new MKS.Core.Presenter.UI.Input();
        public MKS.Core.Presenter.UI.Input Nom
        {
            get
            {
                _Nom.Text = txtNom.Text;
                return _Nom;
            }
            set
            {
                _Nom = value;                
                txtNom.Text = _Nom.Text;

            }
        }
        public MKS.Core.Presenter.UI.Label LabelPrenom
        {
            get
            {
                return null;
            }
            set
            {
                lblPrenom.Text = value.Text;
            }
        }
        private MKS.Core.Presenter.UI.Input _Prenom = new MKS.Core.Presenter.UI.Input();
        public MKS.Core.Presenter.UI.Input Prenom
        {
            get
            {
                _Prenom.Text = txtPrenom.Text;
                return _Prenom;
            }
            set
            {
                _Prenom = value;                
                txtPrenom.Text = _Prenom.Text;

            }
        }

        public MKS.Core.Presenter.UI.Label LabelTelephone
        {
            get
            {
                return null;
            }
            set
            {
                lblTelephone.Text = value.Text;
            }
        }
        private MKS.Core.Presenter.UI.Input _Telephone = new MKS.Core.Presenter.UI.Input();
        public MKS.Core.Presenter.UI.Input Telephone
        {
            get
            {
                _Telephone.Text = txtTelephone.Text;
                return _Telephone;
            }
            set
            {
                _Telephone = value;                
                txtTelephone.Text = _Telephone.Text;

            }
        }
        private MKS.Core.Presenter.UI.Button _Sauvegarder = new MKS.Core.Presenter.UI.Button();
        public MKS.Core.Presenter.UI.Button Sauvegarder
        {
            get
            {
                return _Sauvegarder;
            }
            set
            {
                _Sauvegarder = value;
                btnSauvegarder.Text = _Sauvegarder.Text;
                btnSauvegarder.Enabled = _Sauvegarder.Enabled;
            }
        }
        private MKS.Core.Presenter.UI.Button _About = new MKS.Core.Presenter.UI.Button();
        public MKS.Core.Presenter.UI.Button About
        {
            get
            {
                return _About;
            }
            set
            {
                _About = value;
                btnAbout.Text = _About.Text;
                btnAbout.Enabled = _About.Enabled;
            }
        }


        #endregion implémentation de la vue



    }
}