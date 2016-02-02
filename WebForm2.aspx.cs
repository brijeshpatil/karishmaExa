using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppForCloud
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        PropertyService PS = new PropertyService();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FIllStates();
            }
        }

        private void FIllStates()
        {
            drpState.DataSource = PS.GetAllStates();
            drpState.DataTextField = "StateName";
            drpState.DataValueField = "StateID";

            drpState.DataBind();
        }
        protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillCities();
        }

        private void FillCities()
        {
            drpCity.DataSource = PS.GetCityByState(Convert.ToInt16(drpState.SelectedItem.Value));
            drpCity.DataTextField = "CityName";
            drpCity.DataValueField = "CityID";
            drpCity.DataBind();
        }
    }
}