using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectLayers.Code.DAL;
using ProjectLayers.Code.DTO;

namespace ProjectLayers.Code.BLL {
    class ClientBLL {
        DatabaseAcess db;

        public void insert(ClientDTO dto) {
            try {
                db = new DatabaseAcess();
                db.ConectaBanco();

                string command = "INSERT INTO CLIENTE (NOME, NASCIMENTO, TELEFONE) VALUES ('"
                                    + dto.Name + "', '"
                                    + dto.Birthday + "', '"
                                    + dto.Phone + "', '" +
                                 ")";

                db.ExecutaComando(command);
            } catch (Exception e) {
                MessageBox.Show(
                    "Error registering Customer\n\n" + e.ToString(),
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            } finally {
                db = null;
            }
        }
    }
}
