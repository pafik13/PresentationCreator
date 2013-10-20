using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
 //       int count = 0;
        List <Presentation> presentations = new List <Presentation>();
        List<Bitmap> bml = new List<Bitmap>();

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void добавитьПрезентациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            if (id.ShowDialog() == DialogResult.OK)
            {
                //treeView1.Nodes.Add(id.tbInput.Text);
                Presentation p = new Presentation() { name = id.tbInput.Text, imgIdx = 0 };
                if (p != null)
                {
                    presentations.Add(p);
                }
            }
            id.Dispose();
        }

        private void добавитьТематикуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TreeNode node = treeView1.Nodes[0];
            //node.Nodes.Add("Theme_" + (count = count + 1).ToString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private bool LoadPic(PictureBox sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    sender.Image = new Bitmap(ofd.FileName);
                    return true;
                }
                return false;
            }
        }

        private void btn_AddImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bm = new Bitmap(ofd.FileName);
                    presentations[tvPresentations.SelectedNode.Parent.Index].parts[tvPresentations.SelectedNode.Index].slides.Add(new MyBitMap() {Image = bm});
                    il_128_80.Images.Add(bm);
                    lvImages.Items.Add(new ListViewItem("Slide"+il_128_80.Images.Count.ToString(), il_128_80.Images.Count - 1));
                }
            }
        }

        private void lvImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(((ListView)sender).Items.);
        }

        private void lvImages_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = presentations[tvPresentations.SelectedNode.Parent.Index].parts[tvPresentations.SelectedNode.Index].slides[e.ItemIndex].Image;
        }

        private void btnAddPresantation_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.Text = "Введите название презинтации:";
            if (id.ShowDialog() == DialogResult.OK)
            {
                presentations.Add(new Presentation() {name = id.tbInput.Text, imgIdx = 3});
                tvPresentations.Nodes.Add("pres"+presentations.Count,id.tbInput.Text, 3);
            }
            id.Dispose();
        }

        private void btnAddTheme_Click(object sender, EventArgs e)
        {
            InputDialog id = new InputDialog();
            id.Text = "Введите название тематики:";
            if (id.ShowDialog() == DialogResult.OK)
            {
                if (tvPresentations.SelectedNode == null)
                {
                    MessageBox.Show("Перед добавлением тематики необхадимо выделить презентацию!");
                }
                else
                {
                    int parentIdx = 0;
                    if (tvPresentations.SelectedNode.Level == 0)
                    {
                        parentIdx = tvPresentations.SelectedNode.Index;
                    }
                    else
                    {
                        parentIdx = tvPresentations.SelectedNode.Parent.Index;
                    }
                    if (presentations[parentIdx].parts == null)
                    {
                        presentations[parentIdx].parts = new List<Part>();
                    }
                    presentations[parentIdx].parts.Add(new Part() { name = id.tbInput.Text, imgIdx = 4 });
                    tvPresentations.Nodes[parentIdx].Nodes.Add("part" + presentations[parentIdx].parts.Count.ToString(), id.tbInput.Text, 4);
                }
            }
            id.Dispose();
        }

        private void tvPresentations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Level == 0)
            {
                btn_AddImg.Enabled = false;
                lvImages.Clear();
                il_128_80.Images.Clear();
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = pictureBox1.InitialImage;
                return;
            }
            else
            {
                btn_AddImg.Enabled = true;
                if (presentations[e.Node.Parent.Index].parts[e.Node.Index].slides == null)
                {
                    return;
                }
                else
                {
                    //MessageBox.Show(e.Node.Index.ToString());
                    Refresh2ndPanel();
                }
            }
        }

        private bool Refresh2ndPanel()
        {
            if (presentations[tvPresentations.SelectedNode.Parent.Index].parts[tvPresentations.SelectedNode.Index].slides == null)
            {
                return false;
            }
            else
            {
                lvImages.Clear();
                il_128_80.Images.Clear();
                pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
                pictureBox1.Image = pictureBox1.InitialImage;
                for (int i = 0; i <= presentations[tvPresentations.SelectedNode.Parent.Index].parts[tvPresentations.SelectedNode.Index].slides.Count - 1; i++)
                {
                    il_128_80.Images.Add(presentations[tvPresentations.SelectedNode.Parent.Index].parts[tvPresentations.SelectedNode.Index].slides[i].Image);
                    lvImages.Items.Add(new ListViewItem("Slide" + il_128_80.Images.Count.ToString(), il_128_80.Images.Count - 1));
                }

            }
            return true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Presentation>));
            var fileStream = File.OpenWrite(@"test.xml");
            serializer.Serialize(fileStream, presentations);
            fileStream.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var serializer = new XmlSerializer(typeof(List<Presentation>));
            var fileStream = File.OpenRead(@"test.xml");
            presentations = (List<Presentation>)serializer.Deserialize(fileStream);
            LoadInfo();
            fileStream.Close();
        }

        private void LoadInfo()
        {
            tvPresentations.Nodes.Clear();
            for (int i=0; i<=presentations.Count-1; i++)
            {
                tvPresentations.Nodes.Add("pres"+i, presentations[i].name, presentations[i].imgIdx);
                for (int j = 0; j <= presentations[i].parts.Count - 1; j++)
                {
                    tvPresentations.Nodes[i].Nodes.Add("part"+j, presentations[i].parts[j].name, 4/*presentations[i].parts[j].imgIdx*/);
                }
            }
        }
    }
}
