using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms {
  public class Utility {

    public static bool ValidatePassword(string login, string password) {
      if (login == "Eduardo" && password == "1234") {
        return true;
      }
      if (login == "Thais" && password == "4321") {
        return true;
      }

      return false;
    }

    public static string GenerateJSONCEP(string vCEP) {
      System.Net.HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://viacep.com.br/ws/" + vCEP + "/json/");
      HttpWebResponse response = (HttpWebResponse)request.GetResponse();

      int count;
      string temp;

      byte[] buffer = new byte[1000];
      StringBuilder sb = new StringBuilder();
      Stream stream = response.GetResponseStream();

      do {
        count = stream.Read(buffer, 0, buffer.Length);
        temp = Encoding.UTF8.GetString(buffer, 0, count).Trim();
        sb.Append(temp);
      } while (count > 0);

      return sb.ToString();
    }

    public static bool Valida(string vCPF) {
      int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
      string tempCpf;
      string digito;
      int soma;
      int resto;
      vCPF = vCPF.Trim();
      vCPF = vCPF.Replace(".", "").Replace("-", "");
      if (vCPF.Length != 11)
        return false;
      tempCpf = vCPF.Substring(0, 9);
      soma = 0;
      for (int i = 0; i < 9; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
      resto = soma % 11;
      if (resto < 2)
        resto = 0;
      else
        resto = 11 - resto;
      digito = resto.ToString();
      tempCpf = tempCpf + digito;
      soma = 0;
      for (int i = 0; i < 10; i++)
        soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
      resto = soma % 11;
      if (resto < 2)
        resto = 0;
      else
        resto = 11 - resto;
      digito = digito + resto.ToString();
      return vCPF.EndsWith(digito);
    }
  }
}
