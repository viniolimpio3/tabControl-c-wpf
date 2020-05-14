using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastro_aluno_atvd
{
    public partial class FormCadatrarAluno : Form
    {
        public FormCadatrarAluno()
        {
            InitializeComponent();
        }

        public string nomeAluno;
        public string conceitoAluno;
        public int codAluno;
        public float nota1Aluno;
        public float nota2Aluno;
        public float mediaAluno; 
        public string fileNameFoto;


        public void LimparControles(Control con)
        {
            foreach (Control caixa in con.Controls)
            {
                if (caixa is TextBox)
                {
                    ((TextBox)caixa).Clear();
                }
                else
                {
                    LimparControles(caixa);
                }
            }
        }


        private void btnFoto_Click(object sender, EventArgs e) {
            openFile.Multiselect = false;
            openFile.Filter = "Arquivo de Imagem|*.jpg";
            openFile.FileName = "*.jpg";
            openFile.Title = "Foto de Perfil do Aluno";
            if(openFile.ShowDialog() == DialogResult.OK){
                //seta picBox
                picBox.Image = Image.FromFile(openFile.FileName);

                //seta atributo!!
                this.fileNameFoto = openFile.FileName;
            }
        }

        private void btnFechar_Click(object sender, EventArgs e){
            string txt = "Você deseja Sair??";
            string title = "*FINALIZANDO*";
            object response = MessageBox.Show(txt, title, MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (response.Equals(DialogResult.Yes)) Application.Exit();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e){
            try{
                string conceito = "";

                float n1 = float.Parse(txtNota1.Text);
                float n2 = float.Parse(txtNota2.Text);

                double media = (n1 + n2)/ 2 ;
                

                if (media < 5){
                    conceito = "IN - Insatisfatório";
                    txtMedia.ForeColor = Color.Red;
                    txtMedia.Font = new Font(txtMedia.Font.Name, 9, FontStyle.Bold);
                    txtMedia.Text = media.ToString();

                    txtConceito.Text = conceito;

                    txtConceito.ForeColor = Color.Red;
                    txtConceito.Font = new Font(txtConceito.Font.Name, 9, FontStyle.Bold);

                }else if(media >= 5 && media < 7){

                    conceito = "R - Regular";
                    txtMedia.ForeColor = Color.Brown;
                    txtMedia.Font = new Font(txtMedia.Font.Name, 9, FontStyle.Bold);
                    txtMedia.Text = media.ToString();

                    txtConceito.Text = conceito;

                    txtConceito.ForeColor = Color.Brown;
                    txtConceito.Font = new Font(txtConceito.Font.Name, 9, FontStyle.Bold);

                } else if(media >= 7 && media < 9){

                    conceito = "B - Bom";
                    txtMedia.ForeColor = Color.Green;
                    txtMedia.Font = new Font(txtMedia.Font.Name, 9, FontStyle.Bold);
                    txtMedia.Text = media.ToString();

                    txtConceito.Text = conceito;
                    
                    txtConceito.ForeColor = Color.Green;
                    txtConceito.Font = new Font(txtConceito.Font.Name, 9, FontStyle.Bold);

                } else if(media >=9 && media <= 10){

                    conceito = "MB - Muito Bom";
                    txtMedia.ForeColor = Color.Blue;
                    txtMedia.Font = new Font(txtMedia.Font.Name, 9, FontStyle.Bold);
                    txtMedia.Text = media.ToString();

                    txtConceito.Text = conceito;

                    txtConceito.ForeColor = Color.Blue;
                    txtConceito.Font = new Font(txtConceito.Font.Name, 9, FontStyle.Bold);

                }else if(media > 10) {
                    MessageBox.Show("Nota Inválida!!!\n\nAs Notas Devem estar entre 0 e 10!", "Erro De Dados!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } catch(FormatException err){
                MessageBox.Show("Dados Incompatíveis\n\n" + err.Message , "Erro De Dados!!", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }


        #region Eventos Key_Press
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) {

            if(e.KeyChar == 9 || e.KeyChar == 13){
                txtNome.Focus();
            }

        }
        private void txtNome_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 9 || e.KeyChar == 13) {
                txtNota1.Focus();
            }
        }
        private void txtNota1_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 9 || e.KeyChar == 13) {
                txtNota2.Focus();
            }
        }
        private void txtNota2_KeyPress(object sender, KeyPressEventArgs e){
            if (e.KeyChar == 13){
                btnCalcular_Click(sender, e);//"Clicando" no Botão
            }
        }
       
        #endregion

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try{

                this.nomeAluno = txtNome.Text;
                this.codAluno = int.Parse(txtCodigo.Text);
                this.nota1Aluno = float.Parse(txtNota1.Text);
                this.nota2Aluno = float.Parse(txtNota2.Text);
                this.mediaAluno = float.Parse(txtMedia.Text);
                this.conceitoAluno = txtConceito.Text;


                var foto = Image.FromFile(this.fileNameFoto);

             
                grid.Rows.Add(this.codAluno, this.nomeAluno, this.nota1Aluno, 
                    this.nota2Aluno,
                    this.mediaAluno,
                    this.conceitoAluno, 
                    foto);

                //Apagando campos
                btnCancelar_Click(sender, e);
            }
            catch(FormatException err){
                MessageBox.Show("Dados Incompatíveis\n\n" + err.Message, "Erro De Dados!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e){
            this.LimparControles(this);
            picBox.Image = null;
        }


        #region Consultar dados Eventos
        private void btnRemover_Click(object sender, EventArgs e){
            try { 
                int linha = grid.Rows.GetRowCount(DataGridViewElementStates.Selected);//linha selecionada!!
                int qtd = grid.RowCount;//verifica quantas linhas existem

                if (linha == -1){
                    MessageBox.Show("A T E N Ç Ã O ------> Selecione um item para excluir!", "*** EXCLUSÃO DE ITEM ***", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else if (qtd != 0){
                    grid.Rows.RemoveAt(grid.CurrentRow.Cells[0].RowIndex);
                }
            }catch(FormatException err) { 
                MessageBox.Show("Dados Incompatíveis\n\n" + err.Message, "Erro De Dados!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            int qtd = grid.RowCount;

            if(qtd !=0) {
                grid.Rows.Clear();
            }else{
                MessageBox.Show("A T E N Ç Ã O ------> Não há aluno para remover!", "*** EXCLUSÃO DE ITEM ***", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }



        }
        #endregion
    }
}
