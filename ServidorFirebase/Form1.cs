using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServidorFirebase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async Task btnPeticion_ClickAsync()
        {
            //INICIALIZACION DEL SDK CON LAS CREDENCIALES PROPORCIONADAS POR FIREBASE
            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile("C:/Users/kokod/Downloads/fir-3aea1-firebase-adminsdk-1i19f-0b40e0855a.json")
            });

            //TOKEN DEL DISPOSITIVO PARA ENVIAR LA NOTIFICACION
            var registrationToken = "cJKqQVSsQiqsJNBlP3Aj13:APA91bGwB56RkH2C2dpvl9Iwf4G4pqa9Hw6PKIVc3RYwGY2dy4b2ez8ncrjJ72a2Rdy6Yyst3Kj_NE4hz_eXZfkBd7pqGqdasd0-uIFxHhcSVjjU2At9mS0d3Y0J03nx4sefxEaxEWEI";

            //DEFINICION DE UN MENSAJE, QUE INCLUYE UNA NOTIFICACION CON TITULO Y CUERPO, ASI COMO EL TOKEN
            var message = new FirebaseAdmin.Messaging.Message()
            {
                Notification = new Notification()
                {
                    Title = txtTitulo.Text,
                    Body = txtCuerpo.Text,
                },
                Token = registrationToken,
            };

            //ENVIAR EL MENSAJE AL TOKEN INDICADO
            string response = await FirebaseMessaging.DefaultInstance.SendAsync(message);

            //RESPUESTA DE LA PETICION CON EL ID DEL MENSAJE ENVIADO
            MessageBox.Show("Successfully sent message: " + response);
        }

        private void btnPeticion_Click(object sender, EventArgs e)
        {
            btnPeticion_ClickAsync();
        }

    }
}
