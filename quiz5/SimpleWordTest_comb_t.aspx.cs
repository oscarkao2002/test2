using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SimpleWordTest_comb_t : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void 學號_DDL1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string selectedCValue = CBF110005_DDL1.SelectedValue;
        string selectedEValue = CBF110005_DDL1.SelectedItem.Text;
        CBF110005_cambridge.Text += selectedEValue + "=>" + selectedCValue + "<br/>";
    }

    protected void CBF110005_GV1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void CBF110005_NextButton_Click(object sender, EventArgs e)
    {
        int currentIndex = CBF110005_DDL1.SelectedIndex;  // 取得目前選擇的項目索引
        int nextIndex = (currentIndex + 1) % CBF110005_DDL1.Items.Count;  // 計算下一個項目的索引，如果已經是最後一個項目，則回到第一個項目
        CBF110005_DDL1.SelectedIndex = nextIndex;  // 設定下一個項目為選擇狀態

        string selectedEValue = CBF110005_DDL1.SelectedValue;  // 取得選擇項目的值
        string selectedCValue = CBF110005_DDL1.SelectedItem.Text;  // 取得選擇項目的文字內容

        CBF110005_cambridge.Text = selectedCValue + "→" + selectedEValue + "<br />";  // 將選擇項目的文字和值設定到另一個控制項的文字屬性中

    }

    protected void CBF110005_testBtn_Click(object sender, EventArgs e)
    {
        CBF110005_MV1.ActiveViewIndex = 1;
        AAA();
    }

    protected void AAA()
    {
        if (CBF110005_DDL1.Items.Count > 0)
        {
            Random random = new Random();
            int randomIndex = random.Next(CBF110005_DDL1.Items.Count);
            ListItem selectedListItem = CBF110005_DDL1.Items[randomIndex];

            string chineseMeaning = selectedListItem.Value;

            CBF110005_ch_hint.Text = chineseMeaning;

            string englishWord = selectedListItem.Text;
            CBF110005_input.Text = $"{englishWord[0]}{new string('_', englishWord.Length - 1).Replace("_", " _")}";

        }
    }



    protected void CBF110005_nextQBtn_Click(object sender, EventArgs e)
    {
        AAA();
    }
}