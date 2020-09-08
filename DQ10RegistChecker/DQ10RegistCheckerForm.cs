using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DQ10RegistChecker {
    public partial class DQ10RegistCheckerForm : Form {

        bool seraching = false;

        public DQ10RegistCheckerForm() {
            InitializeComponent();

            checkedListBox1.Items.AddRange(Const.REGISTSET_LIST.Select(x => x.Name.PadRight(10 - (Encoding.GetEncoding("Shift_JIS").GetByteCount(x.Name) - x.Name.Length)) + "\t" + string.Join(",",x.RegistEntityList.Select(y => y.Name).ToArray())).ToArray());
            checkedListBox2.Items.AddRange(Const.REGIST_LIST.Select(x => x.name).ToArray());
        }

        private void button1_Click(object sender, EventArgs e) {
            seraching = true;
            CombinationRegist combination = new CombinationRegist();
            List<RegistSet> registsetList = new List<RegistSet>();
            List<string> allPartsList = new List<string>();
            CheckedListBox.CheckedItemCollection list = checkedListBox1.CheckedItems;
            for(int i = 0; i < list.Count; i++) {
                string name = list[i].ToString().Split(new char[] { '\t'})[0].Replace(" ", "");
                registsetList.Add(Const.REGISTSET_LIST.Where(x => x.Name == name).First());
            }
            List<List<string[]>> partsList = registsetList.Select(x => x.RegistEntityList.Select(y => y.Parts).ToList()).ToList();
            for(int i = 0; i < partsList.Count; i++) {
                for(int j = 0; j < partsList[i].Count; j++) {
                    allPartsList.AddRange(partsList[i][j]);
                }
            }
            allPartsList = allPartsList.Distinct().ToList();

            if (registsetList.Count > 0) {
                (List<Dictionary<string, string>> bestList, List<Dictionary<string, string>> betterList) ret = combination.GetBestRegistEquip(registsetList, allPartsList);
                DisplayResult(ret.betterList);
            }
            seraching = false;
        }

        private void button2_Click(object sender, EventArgs e) {
            seraching = true;
            CombinationRegist combination = new CombinationRegist();
            List<RegistSet> registsetList = new List<RegistSet>();
            CheckedListBox.CheckedItemCollection list = checkedListBox2.CheckedItems;
            (string name, string[] parts, int count)[] reg = Const.REGIST_LIST.Where(x => list.Contains(x.name)).ToArray();
            List<RegistGroupEntity> group = new List<RegistGroupEntity>();
            for(int i = 0; i < reg.Length; i++) {
                group.Add(new RegistGroupEntity(reg[i]));
            }

            List<string> allPartsList = new List<string>();
            if (group.Count > 0) {
                RegistSet set = new RegistSet("自由検索", group.ToArray());
                registsetList.Add(set);

                List<List<string[]>> partsList = registsetList.Select(x => x.RegistEntityList.Select(y => y.Parts).ToList()).ToList();
                for (int i = 0; i < partsList.Count; i++) {
                    for (int j = 0; j < partsList[i].Count; j++) {
                        allPartsList.AddRange(partsList[i][j]);
                    }
                }
                allPartsList = allPartsList.Distinct().ToList();

                (List<Dictionary<string, string>> bestList, List<Dictionary<string, string>> betterList) ret = combination.GetBestRegistEquip(registsetList, allPartsList);
                DisplayResult(ret.betterList);
            }
            seraching = false;
        }

        private void DisplayResult(List<Dictionary<string, string>> betterList) {
            textBox1.Clear();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < betterList.Count; i++) {
                sb.Append((i+1) + "件目" + Environment.NewLine);
                if (betterList[i].ContainsKey(Const.PARTS_HEAD)) {
                    sb.Append(Const.PARTS_HEAD + "\t" + betterList[i][Const.PARTS_HEAD] + Environment.NewLine);
                }
                if (betterList[i].ContainsKey(Const.PARTS_UPBODY)) {
                    sb.Append(Const.PARTS_UPBODY + "\t" + betterList[i][Const.PARTS_UPBODY] + Environment.NewLine);
                }
                if (betterList[i].ContainsKey(Const.PARTS_LOWBODY)) {
                    sb.Append(Const.PARTS_LOWBODY + "\t" + betterList[i][Const.PARTS_LOWBODY] + Environment.NewLine);
                }
                if (betterList[i].ContainsKey(Const.PARTS_LEG)) {
                    sb.Append(Const.PARTS_LEG + "\t" + betterList[i][Const.PARTS_LEG] + Environment.NewLine);
                }
                sb.Append(Environment.NewLine);
            }
            textBox1.Text = sb.ToString();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }

        private void checkedListBox1_SelectedValueChanged(object sender, EventArgs e) {
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e) {

        }

        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            if (seraching) {
                return;
            }

            switch (e.CurrentValue) {
                case CheckState.Checked:
                    e.NewValue = CheckState.Unchecked;
                    break;

                case CheckState.Unchecked:
                    e.NewValue = CheckState.Checked;
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e) {
            seraching = true;
            CheckedListBox.CheckedItemCollection list = checkedListBox1.CheckedItems;
            Dictionary<string, int> registDic = new Dictionary<string, int>();
            for (int i = 0; i < list.Count; i++) {
                string[] registStr = list[i].ToString().Split(new char[] { '\t' })[1].Split(new char[] { ',' });
                for(int j = 0; j < registStr.Length; j++) {
                    if(!registDic.ContainsKey(registStr[j])) {
                        registDic.Add(registStr[j], 1);
                    }
                }
            }
            for (int i = 0; i < checkedListBox2.Items.Count; i++) {
                string itemName = checkedListBox2.Items[i].ToString();
                if(registDic.ContainsKey(itemName)) {
                    checkedListBox2.SetItemChecked(i, true);
                }
                else {
                    checkedListBox2.SetItemChecked(i, false);
                }
            }
            seraching = false;
        }

        private void button4_Click(object sender, EventArgs e) {
            seraching = true;
            for (int i = 0; i < checkedListBox1.Items.Count; i++) {
                string itemName = checkedListBox1.Items[i].ToString();
                checkedListBox1.SetItemChecked(i, false);
            }
            seraching = false;
        }

        private void button5_Click(object sender, EventArgs e) {
            seraching = true;
            for (int i = 0; i < checkedListBox2.Items.Count; i++) {
                string itemName = checkedListBox2.Items[i].ToString();
                checkedListBox2.SetItemChecked(i, false);
            }
            seraching = false;
        }
    }
}
