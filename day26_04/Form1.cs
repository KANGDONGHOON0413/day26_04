using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day26_04
{
    public partial class Form1 : Form
    {
        Form2 form02 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(form02 == null)
            {
                form02 = new Form2();
                form02.Show();
            }
            //모달형과 모델리스형의 차이는 모달형은 subform이 실행중일때 mainform을 조작할 수 없지만, 모델리스형은 조작할 수 있다.
            // 모달은 ShowDialog()를 사용하고 모델리스는 Show()를 사용한다.
        }
    }
}
