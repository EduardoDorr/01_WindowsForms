using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms {
  static class Program {
    /// <summary>
    /// Ponto de entrada principal para o aplicativo.
    /// </summary>
    [STAThread]
    static void Main() {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new HelloWorld());
      //Application.Run(new DemonstracaoKey());
      //Application.Run(new ValidatePassword());
      //Application.Run(new Mask());
      //Application.Run(new ValidateCPF());
      //Application.Run(new ValidateCPF2());
      Application.Run(new Main());
    }
  }
}
