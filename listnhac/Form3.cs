using listnhac.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listnhac
{
    public partial class frmEdit : Form
    {
        private Song currentSong;
        public frmEdit()
        {
            InitializeComponent();         
          
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmEdit_Load(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            //sửa tên của bài nhạc hoặc tên video
        }


        private void txtFile_TextChanged(object sender, EventArgs e)
        {
            //sửa file location
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //lưu sửa đổi và thoát
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //không lưu nữa và thoát
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            //mở ra file location bài hát hoặc video được chọn để sửa tên
        }
    }
}
