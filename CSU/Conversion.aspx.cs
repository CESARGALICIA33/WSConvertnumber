using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSConvertnumber.CSD;

namespace WSConvertnumber.CSU
{
    public partial class Conversion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btnletras_Click(object sender, EventArgs e)
        {
            Convertir oConvertir = new Convertir();
            TxtResultado.Text = oConvertir.Numero2Letras(ulong.Parse(TxtNumero.Text));


        }

        protected void BtnDolares_Click(object sender, EventArgs e)
        {
            Convertir oConvertir = new Convertir();
            TxtResultado.Text = oConvertir.Numero2Dolares(ulong.Parse(TxtNumero.Text));
        }
    }
}