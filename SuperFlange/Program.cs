using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperFlange
{
    class Program
    {
        /// <summary>
        /// Application Entry Point.
        /// </summary>
        [System.STAThreadAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public static void Main()
        {

            DatabaseConnection conn = DatabaseConnection.GetInstance();
            conn.ExectueQuery("Select * from NPS_Table");

            //SuperFlangeSolver.SuperFlangeSolver solver = new SuperFlangeSolver.SuperFlangeSolver();
            //solver.superflangeNaim();

            SuperFlange.App app = new SuperFlange.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}
