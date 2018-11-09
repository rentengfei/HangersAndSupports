using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aveva.Pdms.Database;
using Aveva.Pdms.Shared;
using Aveva.PDMS.Database.Filters;
using Aveva.Pdms.Graphics;

namespace HangersAndSupports
{
    public partial class HSForm : Form
    {
        public HSForm()
        {
            InitializeComponent();
          
        }

        private void btn_Selected_Click(object sender, EventArgs e)
        {

        }

        private void btn_Paste_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TxtPipe_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {

        }

        private void btn_N_Click(object sender, EventArgs e)
        {

        }

        private void btn_HI_Click(object sender, EventArgs e)
        {

        }

        private void btn_G_Click(object sender, EventArgs e)
        {

        }

        private void btn_F_Click(object sender, EventArgs e)
        {

        }

        private void btn_E_Click(object sender, EventArgs e)
        {

        }

        private void btn_Modeling_Click(object sender, EventArgs e)
        {

        }

        private void btn_Drawing_Click(object sender, EventArgs e)
        {

        }

        private void btn_Remittance_Click(object sender, EventArgs e)
        {

        }

        private void btn_AllCE_Click(object sender, EventArgs e)
        {

        }

        private void btn_HII_Click(object sender, EventArgs e)
        {

        }

        private void btn_CE_Click(object sender, EventArgs e)
        {
            DbElement CE = CurrentElement.Element;
            TypeFilter filter = new TypeFilter(DbElementTypeInstance.ATTACHMENT);
            DBElementCollection coll = new DBElementCollection(CE, filter);
            List<NameRef> listNR = new List<NameRef>();
            foreach (DbElement de in coll)
            {
                NameRef nr = new NameRef(de.ToString(),de.RefNo());
                //nr.Name = de.ToString();
                //int[] rn = de.RefNo();
                //foreach (int r in rn)
                //{
                //    nr.Ref+=r.ToString()+"/";
                //}
                //nr.Ref.TrimEnd('/');
                listNR.Add(nr);
            }
            ComBox_ATTA.DataSource = listNR;
            ComBox_ATTA.DisplayMember = "Name";
            //ComBox_ATTA.ValueMember = "Ref";
            BindHS();
        }

        private void btn_D_Click(object sender, EventArgs e)
        {

        }

        private void TxtF_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_WholeAdd_Click(object sender, EventArgs e)
        {

        }

        private void TxtGraphNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void ListBox_Details_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ComBox_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comb = sender as ComboBox;
            HSData.HSModel model = (HSData.HSModel)comb.SelectedItem;
            //XmlHelper helper = new XmlHelper();
            //System.Xml.XmlNodeList list = helper.GetXmlNodeListByXmlNode("ctype/HS", nr.Node);
            //ComBox_Name.Items.Clear();
            //foreach (System.Xml.XmlNode node in list)
            //{
            //    ComBox_Name.Items.Add(new NameNode(node.Attributes["name"].Value, node));
            //}
            HSData.HSDal dal = new HSData.HSDal();
            ListBox_Type.DataSource = dal.GetElementByHS(model.Node);
            ListBox_Type.DisplayMember = "Name";
            ListBox_Type.ValueMember = "Node";
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ComBox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comb = sender as ComboBox;
            HSData.TypeModel model = (HSData.TypeModel)comb.SelectedItem;
            //XmlHelper helper = new XmlHelper();
            //System.Xml.XmlNodeList list = helper.GetXmlNodeListByXmlNode("ctype/HS", nr.Node);
            //ComBox_Name.Items.Clear();
            //foreach (System.Xml.XmlNode node in list)
            //{
            //    ComBox_Name.Items.Add(new NameNode(node.Attributes["name"].Value, node));
            //}
            HSData.HSDal dal = new HSData.HSDal();
            ComBox_Name.DataSource = dal.GetHSListByType(model.Node);
            ComBox_Name.DisplayMember = "Name";
            ComBox_Name.ValueMember = "Node";
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ComBox_Standard_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comb = sender as ComboBox;
            HSData.StandardModel model = (HSData.StandardModel)comb.SelectedItem;
            //XmlHelper helper = new XmlHelper();
            //System.Xml.XmlNodeList list = helper.GetXmlNodeListByXmlNode("types/type", nr.Node);
            //ComBox_Type.Items.Clear();
            //foreach (System.Xml.XmlNode node in list)
            //{
            //    ComBox_Type.Items.Add(new NameNode(node.Attributes["name"].Value, node));
            //}
            HSData.HSDal dal = new HSData.HSDal();
            ComBox_Type.DataSource=dal.GetTypeListByStandard(model.Node);
            ComBox_Type.DisplayMember = "Name";
            ComBox_Type.ValueMember = "Node";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_C_Click(object sender, EventArgs e)
        {

        }

        private void btn_B_Click(object sender, EventArgs e)
        {

        }

        private void btn_A_Click(object sender, EventArgs e)
        {

        }

        private void TxtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHII_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtHI_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtG_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListBox_Element_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            NameRef nr = (NameRef)lb.SelectedItem;
            DbElement dbElement = DbElement.GetElement(nr.Ref);
            CurrentElement.Element = dbElement;
        }

        private void TxtE_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtD_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComBox_ATTA_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPipe.Text = "";
            ComboBox comb = sender as ComboBox;
            NameRef nr = (NameRef)comb.SelectedItem;
            DbElement dbElement = DbElement.GetElement(nr.Ref);
            DbElement Pipe = dbElement.Owner.Owner;
            DrawList dl = DrawListManager.Instance.CurrentDrawList;
            TxtPipe.Text = Pipe.ToString();
            DbElement hanger= dbElement.GetElement(DbAttributeInstance.CREF);
            dl.Add(Pipe);
            dl.Add(hanger);
            //dl.AddToSelection();
            // DbElement Support = hanger.Owner.GetElement(DbAttributeInstance.STLR);
            ListBox_Element.Items.Clear();
            foreach (DbElement h in hanger.Members())
            {
                ListBox_Element.Items.Add(new NameRef(h.ToString(),h.RefNo()));
            }
            //foreach (DbElement s in Support.Owner.Members())
            //{
            //    ListBox_Element.Items.Add(new NameRef(s.ToString(), s.RefNo()));
            //}
            ListBox_Element.DisplayMember = "Name";
        }

        //private void ComBox_ATTA_MouseClick(object sender, MouseEventArgs e)
        //{
        //    ComboBox box = sender as ComboBox;
        //    NameRef nr = (NameRef)box.SelectedItem;
        //    DbElement dbElement = DbElement.GetElement(nr.Ref);
        //    CurrentElement.Element = dbElement;

        //}
        public void BindHS()
        {
           // XmlHelper xmlHelper = new XmlHelper();
           //System.Xml.XmlNodeList list= xmlHelper.GetXmlNodeListByXpath(@"C:\AVEVA\Plant\PDMS12.1.SP4\HS.xml", "//standards//standard");
           // ComBox_Standard.Items.Clear();
           // foreach (System.Xml.XmlNode node in list)
           // {
           //     ComBox_Standard.Items.Add(new NameNode( node.Attributes["name"].Value,node));
           // }
            HSData.HSDal dal = new HSData.HSDal();
            ComBox_Standard.DataSource=dal.GetStandardList();
            ComBox_Standard.DisplayMember = "Name";
            ComBox_Standard.ValueMember = "Node";
        }
    }
}
