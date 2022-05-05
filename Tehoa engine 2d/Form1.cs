using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Tehoa_engine_2d
{
    public partial class Form1 : Form
    {
        private string filename;
        private List<GameObject> objetOnScene = new List<GameObject>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            objetOnScene.Add(new GameObject
            {
                Position = new Vector2(2,3),
                Name = inputBoxName.Text,
                Type = comboBoxType.Text,
                SpritePath = "c:/Hiu"
            });
            UpdateList();
        }

        private void UpdateList()
        {
            SceneItems.Items.Clear();
            foreach (GameObject item in objetOnScene)
            {
                SceneItems.Items.Add(item.Name+" (Type: "+item.Type+")");
            }
        }

        private void SaveScene_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            else
                filename = saveFileDialog1.FileName;

            XmlSerializer serializer = new XmlSerializer(typeof(Scene));
            TextWriter textWriter = new StreamWriter(Path.GetFullPath(filename));
            Scene scene = new Scene();

            scene.objects = objetOnScene;

            serializer.Serialize(textWriter, scene);
            textWriter.Close();
        }
        private void OpenScene_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            else
            {
                filename = openFileDialog1.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(Scene));

                using (Stream reader = new FileStream(filename, FileMode.Open))
                {
                    Scene scene = (Scene)serializer.Deserialize(reader);

                    foreach (GameObject item in scene.objects)
                    {
                        objetOnScene.Add(item);
                    }
                }
            }
            UpdateList();
        }
        private void SaveObject_Click(object sender, EventArgs e)
        {

        }

        private void SceneItems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.SceneItems.IndexFromPoint(e.Location);
            if (SceneItems.SelectedIndex != -1)
            {
                inputBoxName.Text = objetOnScene[index].Name;
                comboBoxType.Text = objetOnScene[index].Type;
            }
        }
    }
}
