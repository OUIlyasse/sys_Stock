using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace iTools
{
    public class iMessage
    {
        #region Variables

        private static NotifyIcon ni = new NotifyIcon();

        #endregion Variables

        #region Codes

        public static void sucMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.success;
            popup.BodyColor = Color.FromArgb(40, 167, 69);
            popup.TitleText = titre;
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void infoMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.info;
            popup.BodyColor = Color.FromArgb(23, 162, 184);
            popup.TitleText = titre;
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void warningMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Warning;
            popup.BodyColor = Color.FromArgb(255, 193, 7);
            popup.TitleText = titre;
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        public static void errorMsg(string titre, string message)
        {
            PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.Error;
            popup.BodyColor = Color.FromArgb(220, 53, 69);
            popup.TitleText = titre;
            popup.TitleColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Bold);

            popup.ContentText = message;
            popup.ContentColor = Color.White;
            popup.TitleFont = new Font("Calibri", 15, FontStyle.Regular);
            popup.Popup();
        }

        #endregion Codes
    }
}