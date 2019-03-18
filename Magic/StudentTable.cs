using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentCard
{
    public partial class StudentTable : Form
    {
        private Curriculum curriculumInfo;
        private List<Student> dataStudent;
        private List<Student> searchStudentList = new List<Student>();
        private bool search = false; //переменная для обозначения, осуществляется ли поиск

        public StudentTable()
        {
            InitializeComponent();
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
            curriculumInfo = new SaveNLoadManager().LoadCurruculumData();
            dataStudent = new SaveNLoadManager().LoadStudentData();

            LoadInfoToTree();
        }

        private void LoadInfoToTree() // Загрузка информации в Treeview начиная с факультетов
        {
            TreeNode facultyNode = new TreeNode("Факультеты");
            foreach (Faculty faculty in curriculumInfo.Faculties)
            {
                if (faculty.ID != 0)
                {
                    TreeNode currentFacultyNode = new TreeNode(faculty.Name);
                    facultyNode.Nodes.Add(currentFacultyNode);

                    CreateSpecialityNode(currentFacultyNode, faculty); //создание treenode для каждой специальности в каждом факультете
                }
            }
            StudentCardsTreeView.Nodes.Add(facultyNode);
        }

        //Создание treenode специальности
        private void CreateSpecialityNode(TreeNode currentFacultyNode, Faculty faculty)
        {
            foreach (Speciality speciality in curriculumInfo.Specialities)
            {
                if (speciality.FacultyID == faculty.ID & speciality.ID != 0)
                {
                    TreeNode currentSpecialityNode = new TreeNode(speciality.Name);
                    currentFacultyNode.Nodes.Add(currentSpecialityNode);
                    CreateCourceNode(currentSpecialityNode, speciality);
                }
            }
        }

        // treenode групп для определенных специалностей и курсов
        private void CreateGroupNode(TreeNode currentCourceNode, Speciality speciality, Cource cource)
        {
            foreach (Group group in curriculumInfo.Groups)
            {
                if (group.SpecialityID == speciality.ID && group.ID != 0 && group.Cource == cource.Number)
                {
                    TreeNode currentGroupNode = new TreeNode(group.Name);
                    currentCourceNode.Nodes.Add(currentGroupNode);
                    ChooseFullOrSearchList(currentGroupNode, group);
                }
            }
        }

        // treenode курсов для каждой специальности
        private void CreateCourceNode(TreeNode currentSpecialityNode, Speciality speciality)
        {
            foreach (Cource cource in CreateCourcesForTree())
            {
                TreeNode currentCourceNode = new TreeNode(cource.Number);
                currentSpecialityNode.Nodes.Add(currentCourceNode);
                CreateGroupNode(currentCourceNode, speciality, cource);
            }
        }

        //создание списка курсов для treeview
        private List<Cource> CreateCourcesForTree()
        {
            var cources = new List<Cource>();
            for (var i = 0; i < 5; i++)
            {
                var cource = new Cource
                {
                    Number = (i + 1).ToString()
                };
                cources.Add(cource);
            }
            return cources;
        }

        // создание treenode для каждого студента в определенной группе
        private void LoadStudentsToTree(TreeNode currentGroupNode, Group group, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.GroupID == group.ID)
                {
                    TreeNode currentStudent = new TreeNode(student.Surname + " " + student.Names + " " + student.MiddleName)
                    {
                        Name = student.Guid.ToString()
                    };
                    currentGroupNode.Nodes.Add(currentStudent);
                }
            }
        }

        //Выбор листа студентов (полный или выбранный поиском) для загрузки в treeview
        private void ChooseFullOrSearchList(TreeNode currentGroupNode, Group group)
        {
            if (!search)
            {
                LoadStudentsToTree(currentGroupNode, group, dataStudent);
            }
            else
            {
                LoadStudentsToTree(currentGroupNode, group, searchStudentList);
            }
        }

        //Поиск студентов по выбранному курсу (если курс не выбран - отображаются все студенты по введенным критерям)
        private void Search()
        {
            foreach (Student student in dataStudent)
            {
                var currentCource = (Cource)CourceComboBox.SelectedItem;
                if (currentCource.Number == "Все")
                {
                    AddStudentToSearchList(student);
                }
                else
                if (student.Cource == currentCource.Number)
                {
                    AddStudentToSearchList(student);
                }
            }
        }

        //Отбор студентов по фамилии, имени, отчеству в список для поиска
        private void AddStudentToSearchList(Student student)
        {
            if (SurnameSearchTextBox.Text?.Length == 0 && NameSearchTextBox.Text?.Length == 0 && MidNameSearchTextBox.Text?.Length == 0)
            {
                searchStudentList.Add(student);
            }
            if (SurnameSearchTextBox.Text == student.Surname && NameSearchTextBox.Text.Length == 0 && MidNameSearchTextBox.Text?.Length == 0)
            {
                searchStudentList.Add(student);
            }
            if (SurnameSearchTextBox.Text == student.Surname && NameSearchTextBox.Text == student.Names && MidNameSearchTextBox.Text?.Length == 0)
            {
                searchStudentList.Add(student);
            }
            if (SurnameSearchTextBox.Text == student.Surname && NameSearchTextBox.Text == student.Names && MidNameSearchTextBox.Text == student.MiddleName)
            {
                searchStudentList.Add(student);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (searchStudentList != null)
            {
                searchStudentList.Clear();
            }
            search = true;
            Search();
            RefreshInfo();
            StudentCardsTreeView.ExpandAll();
        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            search = false;
            if (searchStudentList != null)
            {
                searchStudentList.Clear();
            }
            SurnameSearchTextBox.Text = "";
            NameSearchTextBox.Text = "";
            SurnameSearchTextBox.Text = "";
            CourceComboBox.ResetText();
            RefreshInfo();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new StudentCard(this, dataStudent).ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var chosenStudent = StudentCardsTreeView.SelectedNode;
            var currentStudent = dataStudent.Find(student => student.Guid.ToString() == chosenStudent.Name);
            new SaveNLoadManager().DeleteData(currentStudent);
            MessageBox.Show($"Данные {currentStudent.Surname} удалены");
            RefreshInfo();
        }

        private void StudentCardsTreeView_DoubleClick(object sender, EventArgs e)
        {
            var studentData = new SaveNLoadManager().LoadStudentData();
            var currentStudent = StudentCardsTreeView.SelectedNode;
            StudentCard currentStudentCard;
            foreach (Student student in studentData)
            {
                if (student.Guid.ToString() == currentStudent.Name)
                {
                    currentStudentCard = new StudentCard(this, dataStudent);
                    currentStudentCard.ChangeTextBoxes(student);
                    currentStudentCard.LoadFoto(student);
                    currentStudentCard.LockChanges();
                    currentStudentCard.ShowDialog();
                    RefreshInfo();
                }
            }
        }

        //функция обновления данных в treeview
        public void RefreshInfo()
        {
            StudentCardsTreeView.Nodes.Clear();
            dataStudent = new SaveNLoadManager().LoadStudentData();
            LoadInfoToTree();
            StudentCardsTreeView.Refresh();
            StudentCardsTreeView.ExpandAll();
        }
    }
}