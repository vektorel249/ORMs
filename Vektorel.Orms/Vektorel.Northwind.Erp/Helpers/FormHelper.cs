using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Northwind.Erp.Helpers
{
    internal class FormHelper
    {
        private static Form rootForm;
        private static Dictionary<string, Form> forms;

        public void Initialize(Form root)
        {
            if (rootForm is not null)
            {
                return;
            }
            forms = new Dictionary<string, Form>();
            rootForm = root;
        }

        public void OpenForm<T>() where T : Form
        {
            var formName = typeof(T).Name;

            if (forms.ContainsKey(formName))
            {
                var alreadyOpenedForm = forms[formName];
                alreadyOpenedForm.BringToFront();
                return;
            }

            var f = Activator.CreateInstance<T>(); // method ile instance alma yöntemi (Reflection)
            //var f = new T(); ama bunu yazamayız. Bkz. Generic konusu
            f.MdiParent = rootForm; // FRMMain içinde açılması için
            f.ShowInTaskbar = false;
            f.MaximizeBox = false;
            f.MinimizeBox = false;
            f.FormBorderStyle = FormBorderStyle.FixedSingle;
            f.FormClosing += OnChildFromClosing;
            f.Show();

            forms.Add(typeof(T).Name, f);

            // Her formu yalnızca bir kere açabilecek bir şey yapın.
            // İpucu: Araştırınız => Dictionary
        }

        private void OnChildFromClosing(object sender, FormClosingEventArgs e)
        {
            var form = (Form)sender;
            if (forms.ContainsKey(form.Name))
            {
                forms.Remove(form.Name);
                form.Dispose();
            }
        }
    }
}
