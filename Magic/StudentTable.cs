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
        private bool search = false;

        public StudentTable()
        {
            InitializeComponent();
            //new ComboBoxManager().LoadInfoToFacultyCombobox(FacultyComboBox);
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
            curriculumInfo = new SaveNLoadManager().LoadCurruculumData();
            dataStudent = new SaveNLoadManager().LoadStudentData();
            LoadInfoToTree();
        }

        private void StudentTable_Load(object sender, EventArgs e)
        {
            //new TableManager().LoadFullInfo(StudentListDataGridView);
        }

        //private void LoadClickedStudent(int currentStudentNumber)
        //{
        //    if (currentStudentNumber != -1)
        //    {
        //        var studentData = new SaveNLoadManager().LoadStudentData();
        //        var currentStudent = studentData[currentStudentNumber];
        //        var currentStudentCard = new StudentCard();
        //        currentStudentCard.ChangeTextBoxes(currentStudent);
        //        currentStudentCard.Show();
        //    }
        //}

        //private void StudentListDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        //{
        //    var address = StudentListDataGridView.CurrentCellAddress;
        //    var currentStudentNumber = address.Y;
        //    LoadClickedStudent(currentStudentNumber);
        //}

        //private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    new ComboBoxManager().LoadInfoToSpecialityComboBox(SpecialityComboBox, FacultyComboBox);
        //    var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;

        //    if (currentFaculty.ID == 0)
        //    {
        //        new TableManager().LoadFullInfo(StudentListDataGridView);
        //    }
        //    else
        //    {
        //        var currentStudentList = new TableManager().FacultyFilter(currentFaculty);
        //        StudentListDataGridView.DataSource = currentStudentList;
        //    }
        //}

        //private void SpecialityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    new ComboBoxManager().LoadInfoToGroupComboBox(GroupComboBox, SpecialityComboBox);
        //    var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
        //    var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
        //    if (currentSpeciality.ID == 0)
        //    {
        //        var facultyStudentList = new TableManager().FacultyFilter(currentFaculty);
        //        StudentListDataGridView.DataSource = facultyStudentList;
        //    }
        //    else
        //    {
        //        var currentStudentList = new TableManager().SpecialityFilter(currentSpeciality);
        //        StudentListDataGridView.DataSource = currentStudentList;
        //    }
        //}

        //private void CourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var currentFaculty = (Faculty)FacultyComboBox.SelectedItem;
        //    var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
        //    var currentGroup = (Group)GroupComboBox.SelectedItem;
        //    var currentCource = (Cource)CourceComboBox.SelectedItem;

        //    var currentStudentList = new TableManager().CourceFilter(currentCource, currentFaculty, currentSpeciality, currentGroup);
        //    StudentListDataGridView.DataSource = currentStudentList;
        //}

        //private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    var currentGroup = (Group)GroupComboBox.SelectedItem;
        //    var currentSpeciality = (Speciality)SpecialityComboBox.SelectedItem;
        //    if (currentGroup.ID == 0)
        //    {
        //        var specialityStudentList = new TableManager().SpecialityFilter(currentSpeciality);
        //        StudentListDataGridView.DataSource = specialityStudentList;
        //    }
        //    else
        //    {
        //        var currentStudentList = new TableManager().GroupFilter(currentGroup);
        //        StudentListDataGridView.DataSource = currentStudentList;
        //    }
        //}

        //private void LoadNewStudentCardButton_Click(object sender, EventArgs e)
        //{
        //    new StudentCard().Show();
        //}

        //private void DeleteButton_Click(object sender, EventArgs e)
        //{
        //    var address = StudentListDataGridView.CurrentCellAddress;
        //    var currentStudentNumber = address.Y;
        //    if (currentStudentNumber != -1)
        //    {
        //        var studentData = new SaveNLoadManager().LoadStudentData();
        //        var currentStudent = studentData[currentStudentNumber];

        //        new SaveNLoadManager().DeleteData(currentStudent);

        //        MessageBox.Show($"Данные {currentStudent.Surname} удалены");
        //    }
        //}

        private void LoadInfoToTree() // Загрузка информации в Treeview начиная с факультетов
        {
            TreeNode facultyNode = new TreeNode("Факультеты");
            var facultyList = curriculumInfo.Faculties;
            foreach (Faculty faculty in facultyList)
            {
                if (faculty.ID != 0)
                {
                    TreeNode currentFacultyNode = new TreeNode(faculty.Name);
                    facultyNode.Nodes.Add(currentFacultyNode);

                    CreateSpecialityNode(currentFacultyNode, faculty); //создание treenode для каждой специальности в каждом факультете
                }
            }
            treeView1.Nodes.Add(facultyNode);
        }

        //Создание treenode специальности
        private void CreateSpecialityNode(TreeNode currentFacultyNode, Faculty faculty)
        {
            var specialityList = curriculumInfo.Specialities;
            foreach (Speciality speciality in specialityList)
            {
                if (speciality.FacultyID == faculty.ID & speciality.ID != 0)
                {
                    TreeNode currentSpecialityNode = new TreeNode(speciality.Name);
                    currentFacultyNode.Nodes.Add(currentSpecialityNode);
                    CreateCourceNode(currentSpecialityNode, speciality);
                }
            }
        }

        private void CreateGroupNode(TreeNode currentCourceNode, Speciality speciality, Cource cource)
        {
            var groupList = curriculumInfo.Groups;

            foreach (Group group in groupList)
            {
                if (group.SpecialityID == speciality.ID & group.ID != 0 & group.Cource == cource.Number)
                {
                    TreeNode currentGroupNode = new TreeNode(group.Name);
                    currentCourceNode.Nodes.Add(currentGroupNode);
                    LoadStudentsToTree(currentGroupNode, group);
                }
            }
        }

        private void CreateCourceNode(TreeNode currentSpecialityNode, Speciality speciality)
        {
            var cources = CreateCourcesForTree();
            foreach (Cource cource in cources)
            {
                TreeNode currentCourceNode = new TreeNode(cource.Number);
                currentSpecialityNode.Nodes.Add(currentCourceNode);
                CreateGroupNode(currentCourceNode, speciality, cource);
            }
        }

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

        private void LoadStudentsToTree(TreeNode currentGroupNode, Group group)
        {
            if (search == false)
            {
                foreach (Student student in dataStudent)
                {
                    if (student.GroupID == group.ID)
                    {
                        TreeNode currentStudent = new TreeNode(student.Surname + student.Names + student.MiddleName)
                        {
                            Name = student.Guid.ToString()
                        };
                        currentGroupNode.Nodes.Add(currentStudent);
                    }
                }
            }
            else
            {
                foreach (Student student in searchStudentList)
                {
                    if (student.GroupID == group.ID)
                    {
                        TreeNode currentStudent = new TreeNode(student.Surname + student.Names + student.MiddleName)
                        {
                            Name = student.Guid.ToString()
                        };
                        currentGroupNode.Nodes.Add(currentStudent);
                    }
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            var studentData = new SaveNLoadManager().LoadStudentData();
            var currentStudent = treeView1.SelectedNode;

            foreach (Student student in studentData)
            {
                if (student.Guid.ToString() == currentStudent.Name)
                {
                    var currentStudentCard = new StudentCard();
                    currentStudentCard.ChangeTextBoxes(student);
                    currentStudentCard.LoadFoto(student);
                    currentStudentCard.LockChanges();
                    currentStudentCard.Show();
                }
            }
        }

        private void Search()
        {
            foreach (Student student in dataStudent)
            {
                var currentCource = (Cource)CourceComboBox.SelectedItem;
                if (currentCource.Number == "Все")
                {
                    if (SurnameSearchTextBox.Text == "" & NameSearchTextBox.Text == "" & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == "" & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == student.Names & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == student.Names & MidNameSearchTextBox.Text == student.MiddleName)
                    {
                        searchStudentList.Add(student);
                    }
                }
                else
                if (student.Cource == currentCource.Number)
                {
                    if (SurnameSearchTextBox.Text == "" & NameSearchTextBox.Text == "" & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == "" & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == student.Names & MidNameSearchTextBox.Text == "")
                    {
                        searchStudentList.Add(student);
                    }
                    if (SurnameSearchTextBox.Text == student.Surname & NameSearchTextBox.Text == student.Names & MidNameSearchTextBox.Text == student.MiddleName)
                    {
                        searchStudentList.Add(student);
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            searchStudentList.Clear();
            search = true;
            Search();
            LoadInfoToTree();
            treeView1.ExpandAll();
            treeView1.Refresh();
        }

        private void DeleteSearchButton_Click(object sender, EventArgs e)
        {
            search = false;
            treeView1.Nodes.Clear();
            searchStudentList.Clear();
            LoadInfoToTree();
            treeView1.Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new StudentCard().Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var currentStudent = treeView1.SelectedNode;

            foreach (Student student in dataStudent)
            {
                if (student.Guid.ToString() == currentStudent.Name)
                {
                    new SaveNLoadManager().DeleteData(student);
                    MessageBox.Show($"Данные {student.Surname} удалены");
                    LoadInfoToTree();
                    treeView1.Refresh();
                }
            }
        }
    }
}