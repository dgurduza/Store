using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Store
{
    [Serializable]
    public partial class Store : Form
    {
        public static string Product;
        public static int AmountOfProduct;
        public static double Price;
        public static string VenCode;
        public static string PathOfProduct;
        public static string FullPath;
        public static List<Product> ListOfProducts = new List<Product>();
        public static string NameOfStore;
        public static List<Buyer> buyers = new List<Buyer>();
        public static List<Order> Orders = new List<Order>();
        public Store()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Вызов добавления раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickToCreate(object sender, EventArgs e)
        {
            GetSection();
        }
        /// <summary>
        /// Вызов переименования раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RenameButton_Click(object sender, EventArgs e)
        {
            Renaming();
        }
        /// <summary>
        /// Вызов удаления раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickToDelete(object sender, EventArgs e)
        {
            Deleting();
        }
        /// <summary>
        /// Метод переименования товара.
        /// </summary>
        public void Renaming()
        {
            try
            {
                if (GetNewName.TextLength != 0)
                {
                    if (CheckNaming())
                    {
                        for (int i = 0; i < ListOfProducts.Count; i++)
                        {
                            if (Classifier.SelectedNode.FullPath == ListOfProducts[i].Path)
                            {
                                ListOfProducts[i].Path = GetNewName.Text;
                            }
                        }
                        Classifier.SelectedNode.Text = GetNewName.Text;
                        GetNewName.Text = "";
                        GetNewName.Visible = false;
                        RenameButton.Visible = false;
                        // Сокрытие элементов формы.
                        SubSection.Visible = true;
                        CreateProduct.Visible = true;
                        Changing.Visible = true;
                        CreatorCSV.Visible = true;
                        OldStore.Visible = true;
                        SaveStore.Visible = true;
                        OpenShop.Visible = true;
                        // Вывод элементов формы.
                    }
                    else
                    {
                        MessageBox.Show("Enter new name again");
                    }
                }
                else
                {
                    MessageBox.Show("Enter new name");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для переименования раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ClickToRename(object sender, EventArgs e)
        {
            if (Classifier.SelectedNode != null)
            {
                SubSection.Visible = false;
                CreateProduct.Visible = false;
                GetNameForSection.Visible = false;
                GetNewName.Visible = true;
                RenameButton.Visible = true;
                Changing.Visible = false;
                CreatorCSV.Visible = false;
                OldStore.Visible = false;
                SaveStore.Visible = false;
                OpenShop.Visible = false;
            }
            else
            {
                MessageBox.Show("Select section");
            }
        }
        /// <summary>
        /// Сокрытие ненужных элементов и появление элементов для добавление раздела.
        /// </summary>
        public void GetSection()
        {
            GetNewName.Visible = true;
            GetNameForSection.Visible = true;
            SubSection.Visible = false;
            CreateProduct.Visible = false;
            Changing.Visible = false;
            CreatorCSV.Visible = false;
            OldStore.Visible = false;
            SaveStore.Visible = false;
            OpenShop.Visible = false;
        }
        /// <summary>
        /// Проверка на наличие в узле раздела товаров с одинаковым именем.
        /// </summary>
        /// <returns></returns>
        private bool CheckNaming()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Classifier.SelectedNode.Nodes.Count; i++)
                // В цикле проверка узлов на наличие одинаковых названий.
                {
                    if (Classifier.SelectedNode.Nodes[i].Text == GetNewName.Text)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }
        /// <summary>
        /// Проверка классификатора на наличие одинаковых разделов.
        /// </summary>
        /// <returns></returns>
        public bool CheckClassifier()
        {
            try
            {
                int count = 0;
                for (int i = 0; i < Classifier.Nodes.Count; i++)
                {
                    if (Classifier.Nodes[i].Text == GetNewName.Text)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            return false;
        }
        /// <summary>
        /// Метод для получения названия раздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Naming(object sender, EventArgs e)
        {
            if (GetNewName.TextLength != 0)
            {
                if (CheckClassifier())
                {
                    Classifier.Nodes.Add(GetNewName.Text);
                    // Добавление раздела в классификатор.
                    Classifier.SelectedNode = null;
                    GetNewName.Text = "";
                    GetNewName.Visible = false;
                    GetNameForSection.Visible = false;
                    SubSection.Visible = true;
                    CreateProduct.Visible = true;
                    Changing.Visible = true;
                    CreatorCSV.Visible = true;
                    OldStore.Visible = true;
                    SaveStore.Visible = true;
                    OpenShop.Visible = true;
                }
                else
                {
                    MessageBox.Show("A section with the same name already exists");
                }
            }
            else
            {
                MessageBox.Show("Enter new name");
            }
        }
        /// <summary>
        /// Удаление раздела.
        /// </summary>
        public void Deleting()
        {
            if (Classifier.SelectedNode != null)
            {
                if (Classifier.SelectedNode.Nodes.Count == 0)
                {
                    Classifier.Nodes.Remove(Classifier.SelectedNode);
                    // Удаление раздела.
                }
                else
                {
                    MessageBox.Show("Section is not empty");
                }
            }
            else
            {
                MessageBox.Show("Select section");
            }
        }
        /// <summary>
        /// Вызов процессов для создания товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                Information information = new Information();
                // Инициализация новой формы для получения информации о создаваемом товаре.
                if (Classifier.SelectedNode != null)
                {
                    PathOfProduct = Classifier.SelectedNode.FullPath;
                    // Получение пути для товара.
                    information.ShowDialog();
                    // Открытие формы.
                }
                else
                {
                    MessageBox.Show("Select section");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Вызов нужных и сокрытие ненужных элементов для добавления подраздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubSection_Click(object sender, EventArgs e)
        {
            if (Classifier.SelectedNode != null)
            {
                GetNewName.Visible = true;
                SaveStore.Visible = false;
                SubSectionName.Visible = true;
                SubSection.Visible = false;
                CreateProduct.Visible = false;
                Changing.Visible = false;
                CreatorCSV.Visible = false;
                OldStore.Visible = false;
                OpenShop.Visible = false;
            }
            else
            {
                MessageBox.Show("Select section");
            }
        }
        /// <summary>
        /// Получение имени подраздела.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubSectionName_Click(object sender, EventArgs e)
        {
            if (GetNewName.TextLength != 0)
            {
                if (CheckNaming())
                {
                    Classifier.SelectedNode.Nodes.Add(GetNewName.Text);
                    // Добавление подсекции.
                    Classifier.SelectedNode = null;
                    GetNewName.Text = "";
                    GetNewName.Visible = false;
                    SubSectionName.Visible = false;
                    SubSection.Visible = true;
                    CreateProduct.Visible = true;
                    Changing.Visible = true;
                    SaveStore.Visible = true;
                    CreatorCSV.Visible = true;
                    OldStore.Visible = true;
                    OpenShop.Visible = true;
                }
                else
                {
                    MessageBox.Show("A product with the same name already exists");
                }
            }
            else
            {
                MessageBox.Show("Enter new name");
            }
        }
        /// <summary>
        /// Вывод товаров раздела в таблицу.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Classifier_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                int countOfRows = 0;
                if (Classifier.SelectedNode != null)
                {
                    CsvOutput.Rows.Clear();
                    // Очистка таблицы.
                    for (int i = 0; i < ListOfProducts.Count; i++)
                    {
                        if (ListOfProducts[i].Path == Classifier.SelectedNode.FullPath)
                        {
                            CsvOutput.Visible = true;
                            CsvOutput.Rows.Add(ListOfProducts[i].NameOfProduct, ListOfProducts[i].VCode, ListOfProducts[i].Price, ListOfProducts[i].Quantity);
                            // Добавление строк с информацией в таблицу.
                            CsvOutput.Rows[countOfRows].ReadOnly = true;
                            // Запрет на изменение таблицы.
                            countOfRows++;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Изменение информации о товаре.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Changing_Click(object sender, EventArgs e)
        {
            try
            {
                if (Classifier.SelectedNode != null)
                {
                    if (GetProductsInClassfier())
                    {
                        FullPath = Classifier.SelectedNode.FullPath;
                        СhangingProducts сhanging = new СhangingProducts();
                        сhanging.ShowDialog();
                        // Создание и открытие новой формы для изменения информации о товаре.
                    }
                    else
                    {
                        MessageBox.Show("There are no products in the section");
                    }
                }
                else
                {
                    MessageBox.Show("Select section");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Проверка на наличие товаров в разделе.
        /// </summary>
        /// <returns></returns>
        public bool GetProductsInClassfier()
        {
            for (int i = 0; i < ListOfProducts.Count; i++)
            {
                if (ListOfProducts[i].Path == Classifier.SelectedNode.FullPath)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Сокрытие элементов для вывода нужных элементов управления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatorCSV_Click(object sender, EventArgs e)
        {
            SubSection.Visible = false;
            Changing.Visible = false;
            CreateProduct.Visible = false;
            GetNewName.Visible = true;
            MakeCSV.Visible = true;
            OldStore.Visible = false;
            SaveStore.Visible = false;
            CreatorCSV.Visible = false;
            OpenShop.Visible = false;
        }
        /// <summary>
        /// Метод для создания файла формата CSV. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeCSV_Click(object sender, EventArgs e)
        {

            int num;
            List<Product> ending = new List<Product>();
            try
            {
                if (GetNewName.TextLength > 0 && int.TryParse(GetNewName.Text, out num) && num > 0)
                {
                    for (int i = 0; i < ListOfProducts.Count; i++)
                    {
                        if (ListOfProducts[i].Quantity < num)
                        {
                            ending.Add(ListOfProducts[i]);
                            // Получение товаров заканчивающихся на складе.
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter number of products again");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            string path = @"..\..\..\table.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.UTF8))
                // Использование StreamWriter для записи в файл.
                {
                    string nameOfColumns = "Путь;Артикул;Название;Количество на складе";
                    sw.WriteLine(nameOfColumns);
                    // Запись названий столбцов в файл.
                    for (int i = 0; i < ending.Count; i++)
                    {
                        string str = ending[i].Path + ";" + ending[i].VCode + ";" + ending[i].NameOfProduct + ";" + ending[i].Quantity;
                        // Строка читаемая в формате CSV.
                        sw.WriteLine(str);
                        // Запись в файл.
                    }
                }
                MessageBox.Show("File created");
                SubSection.Visible = true;
                Changing.Visible = true;
                CreateProduct.Visible = true;
                GetNewName.Visible = false;
                MakeCSV.Visible = false;
                OldStore.Visible = true;
                SaveStore.Visible = true;
                CreatorCSV.Visible = true;
                OpenShop.Visible = true;
            }
            catch
            {
                MessageBox.Show("File not created");
            }

        }
        /// <summary>
        /// Расшифровка сериализованных данных.
        /// </summary>
        public void Deserialize()
        {
            try
            {
                GetStore gos = new GetStore();
                // Создание формы для выбора склада.
                if (gos.MasOfPath.Length > 0)
                {
                    gos.ShowDialog();
                    // Открытие формы.
                    BinaryFormatter formatter = new BinaryFormatter();
                    // Использование BinaryFormatter для дешифровки.
                    if (gos.PathOfDirectory != null)
                    {
                        using (FileStream fs = new FileStream($@"{gos.PathOfDirectory}\Nodes.bin", FileMode.Open))
                        {
                            List<TreeNode> desTree = (List<TreeNode>)formatter.Deserialize(fs);
                            Classifier.Nodes.Clear();
                            for (int i = 0; i < desTree.Count; i++)
                            {
                                Classifier.Nodes.Add(desTree[i]);
                            }
                        }
                        using (FileStream fs = new FileStream($@"{gos.PathOfDirectory}\Products.bin", FileMode.Open))
                        {
                            ListOfProducts = (List<Product>)formatter.Deserialize(fs);
                        }
                        using (FileStream fs = new FileStream($@"{gos.PathOfDirectory}\Orders.bin", FileMode.Open))
                        {
                            Orders = (List<Order>)formatter.Deserialize(fs);
                        }
                        using (FileStream fs = new FileStream($@"{gos.PathOfDirectory}\Buyers.bin", FileMode.Open))
                        {
                            buyers = (List<Buyer>)formatter.Deserialize(fs);
                        }
                    }
                    else
                    {
                        MessageBox.Show("File not found");
                    }
                }
                else
                {
                    MessageBox.Show("No stores created");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Дешифровка данных.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OldStore_Click(object sender, EventArgs e)
        {
            Deserialize();
        }
        /// <summary>
        /// При загрузке формы вывод правил работы с программой.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Store_Load(object sender, EventArgs e)
        {
            Rules();
            NameToStore nst = new NameToStore();
            nst.ShowDialog();
            // Получение названия склада.
        }
        /// <summary>
        /// Вызов методя для сохранение склада.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveStore_Click(object sender, EventArgs e)
        {
            Serialize();
        }
        /// <summary>
        /// Сохранение склада.
        /// </summary>
        public void Serialize()
        {
            try
            {
                if (Classifier.Nodes.Count > 0)
                {
                    Directory.CreateDirectory($@"..\..\..\Stores\{NameOfStore}");
                    // Создание папки в которой будут храниться данные о сохраняемом складе.
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream($@"..\..\..\Stores\{NameOfStore}\Nodes.bin", FileMode.OpenOrCreate))
                    {
                        List<TreeNode> nodes = new List<TreeNode>();
                        for (int i = 0; i < Classifier.Nodes.Count; i++)
                        {
                            nodes.Add(Classifier.Nodes[i]);
                        }
                        formatter.Serialize(fs, nodes);
                        // Сериализация данных
                    }
                    using (FileStream fs = new FileStream($@"..\..\..\Stores\{NameOfStore}\Products.bin", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, ListOfProducts);
                    }
                    using (FileStream fs = new FileStream($@"..\..\..\Stores\{NameOfStore}\Orders.bin", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, Orders);
                    }
                    using (FileStream fs = new FileStream($@"..\..\..\Stores\{NameOfStore}\Buyers.bin", FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, buyers);
                    }
                    MessageBox.Show("Store is saved");
                }
                else
                {
                    MessageBox.Show("Classifier is empty.Save failed.");
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Вывод правил использования программы на экран.
        /// </summary>
        public void Rules()
        {
            try
            {
                string letter = File.ReadAllText(@"..\..\..\Rules.txt");
                MessageBox.Show(letter);
                // Для оптимизации вывод правил из файла.
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        /// <summary>
        /// Вывод правил на экран.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Information_Click(object sender, EventArgs e)
        {
            Rules();
        }
        /// <summary>
        /// Открытие формы для работы с магазином.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenShop_Click(object sender, EventArgs e)
        {
            if (ListOfProducts.Count > 0)
            {
                LoginUsers lu = new LoginUsers();
                lu.ShowDialog();
            }
            else
            {
                MessageBox.Show("There are no items in stock, it is impossible to open a store.");
            }
        }
    }
}
