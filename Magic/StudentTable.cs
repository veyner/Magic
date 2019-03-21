﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StudentCard
{
    public partial class StudentTable : Form
    {
        private Curriculum _curriculumInfo;
        private List<Student> _dataStudent;
        private List<Student> searchStudentList = new List<Student>();
        private SaveNLoadManager _manager;
        private bool search = false; //переменная для обозначения, осуществляется ли поиск

        public StudentTable()
        {
            InitializeComponent();
            new ComboBoxManager().LoadInfoToCourceComboBox(CourceComboBox);
            _manager = new SaveNLoadManager();
            _curriculumInfo = _manager.LoadCurruculumData();
            _dataStudent = _manager.LoadStudentData();
            _manager.LoadDefaultPhoto(PhotoPictureBox);
            LoadInfoToTree();
        }

        /// <summary>
        /// Загрузка информации в Treeview начиная с факультетов
        /// </summary>
        private void LoadInfoToTree()
        {
            TreeNode facultyNode = new TreeNode("Факультеты");
            foreach (Faculty faculty in _curriculumInfo.Faculties)
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

        /// <summary>
        /// Создание treenode специальности
        /// </summary>
        /// <param name="currentFacultyNode">текущий нод факультета</param>
        /// <param name="faculty">текущий факультет</param>
        private void CreateSpecialityNode(TreeNode currentFacultyNode, Faculty faculty)
        {
            foreach (Speciality speciality in _curriculumInfo.Specialities)
            {
                if (speciality.FacultyID == faculty.ID && speciality.ID != 0)
                {
                    TreeNode currentSpecialityNode = new TreeNode(speciality.Name);
                    currentFacultyNode.Nodes.Add(currentSpecialityNode);
                    CreateCourceNode(currentSpecialityNode, speciality);//создание treenode для каждого курса в каждой специальности
                }
            }
        }

        /// <summary>
        /// treenode групп для определенных специалностей и курсов
        /// </summary>
        /// <param name="currentCourceNode">текущий нод курса</param>
        /// <param name="speciality">текущая специальность</param>
        /// <param name="cource">текущий курс</param>
        private void CreateGroupNode(TreeNode currentCourceNode, Speciality speciality, Cource cource)
        {
            foreach (Group group in _curriculumInfo.Groups)
            {
                if (group.SpecialityID == speciality.ID && group.ID != 0 && group.Cource == cource.Number) // проверка по текущей специальности и текущему курсу
                {
                    TreeNode currentGroupNode = new TreeNode(group.Name);
                    currentCourceNode.Nodes.Add(currentGroupNode);
                    ChooseFullOrSearchList(currentGroupNode, group);
                }
            }
        }

        /// <summary>
        /// treenode курсов для каждой специальности
        /// </summary>
        /// <param name="currentSpecialityNode">текущий нод специальности</param>
        /// <param name="speciality">текущая специальность</param>
        private void CreateCourceNode(TreeNode currentSpecialityNode, Speciality speciality)
        {
            foreach (Cource cource in CreateCourcesForTree())
            {
                TreeNode currentCourceNode = new TreeNode(cource.Number);
                currentSpecialityNode.Nodes.Add(currentCourceNode);
                CreateGroupNode(currentCourceNode, speciality, cource); // создание групп для каждого курса
            }
        }

        /// <summary>
        /// создание списка курсов для treeview
        /// </summary>
        /// <returns>лист курсов</returns>
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
        /// <summary>
        /// создание нода для каждого студента
        /// </summary>
        /// <param name="currentGroupNode">текущий нод группы</param>
        /// <param name="group">текущая группа</param>
        /// <param name="students">лист студентов</param>
        private void LoadStudentsToTree(TreeNode currentGroupNode, Group group, List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.GroupID == group.ID)
                {
                    TreeNode currentStudent = new TreeNode(student.Surname + " " + student.Name + " " + student.MiddleName)
                    {
                        Name = student.Guid.ToString()
                    };
                    currentGroupNode.Nodes.Add(currentStudent);
                }
            }
        }

        /// <summary>
        /// Выбор листа студентов (полный или выбранный поиском) для загрузки в treeview
        /// </summary>
        /// <param name="currentGroupNode">текущий нод группы</param>
        /// <param name="group">текущая группа</param>

        private void ChooseFullOrSearchList(TreeNode currentGroupNode, Group group)
        {
            if (!search)
            {
                LoadStudentsToTree(currentGroupNode, group, _dataStudent); // загрузка всех студентов
            }
            else
            {
                LoadStudentsToTree(currentGroupNode, group, searchStudentList); // загрузка студентов из листа поиска
            }
        }

        /// <summary>
        /// Поиск студентов по выбранному курсу (если курс не выбран - отображаются все студенты по введенным критерям)
        /// </summary>
        private void Search()
        {
            foreach (Student student in _dataStudent)
            {
                var currentCource = (Cource)CourceComboBox.SelectedItem;
                if (currentCource.Number == " ")
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

        /// <summary>
        /// Отбор студентов по фамилии, имени, отчеству в список для поиска
        /// </summary>
        /// <param name="student">текущий студент</param>
        private void AddStudentToSearchList(Student student)
        {
            var surnameSearch = SurnameSearchTextBox.Text;
            var nameSearch = NameSearchTextBox.Text;
            var midNameSearch = MidNameSearchTextBox.Text;
            // условие по отбору всех студентов выбранного курса
            if (string.IsNullOrWhiteSpace(surnameSearch) && string.IsNullOrWhiteSpace(nameSearch) && string.IsNullOrWhiteSpace(midNameSearch))
            {
                searchStudentList.Add(student);
            }
            //условие по отбору студентов по введенной информации в поле "Фамилия"
            if (!string.IsNullOrWhiteSpace(surnameSearch) && string.IsNullOrWhiteSpace(nameSearch) && string.IsNullOrWhiteSpace(midNameSearch))
            {
                if (RegexSearch(surnameSearch, student.Surname))
                {
                    searchStudentList.Add(student);
                }
            }
            //условие по отбору студентов по введенной информации в поле "Фамилия" и "Имя"
            if (!string.IsNullOrWhiteSpace(surnameSearch) && !string.IsNullOrWhiteSpace(nameSearch) && string.IsNullOrWhiteSpace(midNameSearch))
            {
                if (RegexSearch(surnameSearch, student.Surname) && RegexSearch(nameSearch, student.Name))
                {
                    searchStudentList.Add(student);
                }
            }
            //условие по отбору студентов по введенной информации в поле "Фамилия", "Имя" и "Отчество"
            if (!string.IsNullOrWhiteSpace(surnameSearch) && !string.IsNullOrWhiteSpace(nameSearch) && !string.IsNullOrWhiteSpace(midNameSearch))
            {
                if (RegexSearch(surnameSearch, student.Surname) && RegexSearch(nameSearch, student.Name) && RegexSearch(midNameSearch, student.MiddleName))
                {
                    searchStudentList.Add(student);
                }
            }
        }

        /// <summary>
        /// регулярное выражение для отбора студентов
        /// </summary>
        /// <param name="pattern">шаблон выражения</param>
        /// <param name="text">место поиска по шаблону (фамилия, имя или отчество)</param>
        /// <returns>если найдено совпадение - truе</returns>
        private bool RegexSearch(string pattern, string text)
        {
            Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = regex.Match(text);
            return m.Success;
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
            MidNameSearchTextBox.Text = "";
            CourceComboBox.ResetText();
            RefreshInfo();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            new StudentCard(this, _dataStudent).ShowDialog();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (StudentCardsTreeView.SelectedNode != null && StudentCardsTreeView.SelectedNode.Name != "")
            {
                var currentStudent = SearchStudentInStudentList();
                _manager.DeleteData(currentStudent);
                MessageBox.Show($"Данные {currentStudent.Surname} удалены");
                DeleteTextBoxInfo();
                RefreshInfo();
            }
        }

        private void StudentCardsTreeView_DoubleClick(object sender, EventArgs e)
        {
            if (StudentCardsTreeView.SelectedNode.Name != "")
            {
                LoadClickedStudentInfo();
            }
        }

        /// <summary>
        /// обновление данных в treeview
        /// </summary>
        public void RefreshInfo()
        {
            StudentCardsTreeView.Nodes.Clear();
            _dataStudent = _manager.LoadStudentData();
            LoadInfoToTree();
            StudentCardsTreeView.Refresh();
            StudentCardsTreeView.ExpandAll();
        }

        /// <summary>
        /// Очистка данных в текстбоксах
        /// </summary>
        private void DeleteTextBoxInfo()
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            MiddlenameTextBox.Text = "";
            CityTextBox.Text = "";
            AddressTextBox.Text = "";
            TelefonTextBox.Text = "";
            EmailTextBox.Text = "";
        }

        /// <summary>
        /// Загрузка информации выбранного студента для просмотра
        /// </summary>
        private void LoadClickedStudentInfo()
        {
            var currentStudent = SearchStudentInStudentList();

            SurnameTextBox.Text = currentStudent.Surname;
            NameTextBox.Text = currentStudent.Name;
            MiddlenameTextBox.Text = currentStudent.MiddleName;
            CityTextBox.Text = currentStudent.City;
            AddressTextBox.Text = currentStudent.Street;
            TelefonTextBox.Text = currentStudent.TelefonNumber;
            EmailTextBox.Text = currentStudent.Email;
            //если фото выбрано загружается фото
            if (currentStudent.Photo)
            {
                _manager.LoadFoto(currentStudent, PhotoPictureBox);
            }
            //если фото не выбрано загружается дефолтная картинка
            else
            {
                _manager.LoadDefaultPhoto(PhotoPictureBox);
            }
        }

        /// <summary>
        /// поиск студента в списке
        /// </summary>
        /// <returns>найденный студент</returns>
        private Student SearchStudentInStudentList()
        {
            var chosenStudent = StudentCardsTreeView.SelectedNode;
            return _dataStudent.Find(student => student.Guid.ToString() == chosenStudent.Name);
        }

        private void ChangeInfoButton_Click(object sender, EventArgs e)
        {
            if (StudentCardsTreeView.SelectedNode != null && StudentCardsTreeView.SelectedNode.Name != "")
            {
                var currentStudent = SearchStudentInStudentList();
                StudentCard currentStudentCard = new StudentCard(this, _dataStudent);
                currentStudentCard.ChangeBoxes(currentStudent);
                currentStudentCard.ShowDialog();
                DeleteTextBoxInfo();
                RefreshInfo();
            }
        }

        private void SurnameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SurnameSearchTextBox.Text))
            {
                NameSearchTextBox.Enabled = true;
            }
            else
            {
                NameSearchTextBox.Enabled = false;
            }
        }

        private void NameSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameSearchTextBox.Text))
            {
                MidNameSearchTextBox.Enabled = true;
            }
            else
            {
                MidNameSearchTextBox.Enabled = false;
            }
        }
    }
}