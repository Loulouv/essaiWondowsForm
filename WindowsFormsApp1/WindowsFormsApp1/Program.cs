using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            using (var db = new Model1())
            {
                var name = "Plat";

                var category = new RECIPE_CATEGORY { reciep_category_name = name };
                db.RECIPE_CATEGORY.Add(category);
                db.SaveChanges();

            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
