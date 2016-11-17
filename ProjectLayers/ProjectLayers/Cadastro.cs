using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLayers.Code.BLL;
using ProjectLayers.Code.DTO;

namespace ProjectLayers {
    public partial class Clientes : Form {
        ClientBLL bll = new ClientBLL();
        ClientDTO dto = new ClientDTO();

        public Clientes() {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            dto.Name = tbName.Text;
            dto.Birthday = tbBirthday.Text;
            dto.Phone = tbPhone.Text;

            bll.insert(dto);        
        }
    }
}
