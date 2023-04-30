using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoSalvaMySQL
{
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }
        public string caminhoFoto;
        private void Btn_AdicionarFoto_Click(object sender, EventArgs e)
        {
            string foto = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foto = openFileDialog1.FileName.ToString();
                Pb_foto.ImageLocation = foto;
                caminhoFoto = foto;
            }
        }

        private void Btn_Enviar_Click(object sender, EventArgs e)
        {
            string nome = Lbl_Nome.Text;
            byte[] imagem_byte = null;

            FileStream fStream = new FileStream(this.caminhoFoto, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);

            imagem_byte = br.ReadBytes((int)fStream.Length);

            string con = @"server=localhost;uid=root;pwd=root;database=projetop";
            string comando = "insert into enviafoto(nome, foto) values(@nome, @foto);";

            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(comando, conn);
            MySqlDataReader meu_reader;

            try
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@foto", imagem_byte);
                meu_reader = cmd.ExecuteReader();

                MessageBox.Show("Cadastro comcluido");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

            
        }
    }
}
