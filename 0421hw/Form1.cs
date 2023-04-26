using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0421hw
{
    public partial class Form1 : Form
    {
        public SynchronizationContext uiContext;
        List<Employer> Employers = new List<Employer>
        {
            new Employer("firstname1","lastname1",new DateTime(2001,7,4),"0741356509","address1","street1",67,4),
            new Employer("firstname2","lastname2",new DateTime(1901,2,2),"0741935640","address2","street2",36,96)
        };
        List<Student> Students = new List<Student>
        {
            new Student("name1",213,10,11,12,new DateTime(2022,5,4)),
            new Student("name2",213,7,11,9,new DateTime(2022,5,2))
        };
        List<Book> Books = new List<Book>
        {
            new Book(345,"author1","book1","publisher1",2003,new DateTime(2020,8,12),new DateTime(2023,5,7)),
            new Book(382,"author2","book2","publisher2",2009,new DateTime(2019,2,6),new DateTime(2021,6,9))
        };
        List<Product> Products = new List<Product>
        {
            new Product("category1","name1","manufacturer1",new DateTime(2020,8,12),5),
            new Product("category1","name1","manufacturer1",new DateTime(2022,4,16),10)
        };

        public Form1()
        {
            InitializeComponent();
            uiContext = SynchronizationContext.Current;
        }

        private async void buttonV6_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                int EmployersAges = 0;
                int QuantityofEmployers = 0;
                TimeSpan Age;
                try
                {
                    uiContext.Send(x => listBoxResult.Items.Clear(), null);
                    foreach(Employer Employer in Employers)
                    {
                        if (textBoxInput.Text == Employer.Street && Employer.HouseNumber % 2 == 0)
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName),null);
                            QuantityofEmployers++;
                            Age = DateTime.Now.Subtract(Employer.Birth);
                            EmployersAges += Age.Days/365;
                        }
                    }
                    if (QuantityofEmployers != 0)
                    {
                        uiContext.Send(x => listBoxResult.Items.Add(Convert.ToString(EmployersAges / QuantityofEmployers)), null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void buttonV7_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                try
                {
                    uiContext.Send(x => listBoxResult.Items.Clear(), null);
                    foreach (Employer Employer in Employers)
                    {
                        if (Employer.Birth.Year == 1901)
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName), null);
                        }
                        if (textBoxInput.Text == "Spring" && (Employer.Birth.Month==3||Employer.Birth.Month==4 || Employer.Birth.Month == 5))
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName), null);

                        }
                        if (textBoxInput.Text == "Summer" && (Employer.Birth.Month == 6 || Employer.Birth.Month == 7 || Employer.Birth.Month == 8))
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName), null);

                        }
                        if (textBoxInput.Text == "Fall" && (Employer.Birth.Month == 9 || Employer.Birth.Month == 10 || Employer.Birth.Month == 11))
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName), null);


                        }
                        if (textBoxInput.Text == "Winter" && (Employer.Birth.Month == 12 || Employer.Birth.Month == 1 || Employer.Birth.Month == 2))
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Employer.Phone + Employer.LastName), null);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void buttonV8_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                DateTime ExamsEndDate = DateTime.Parse(textBoxInput.Text);
                try
                {
                    uiContext.Send(x => listBoxResult.Items.Clear(), null);
                    Students.Sort((x, y) => (x.CompMark+x.MathMark+x.PhysicsMark/3).CompareTo(x.CompMark + x.MathMark + x.PhysicsMark / 3));
                    var PassedExams = Students.Where(x => x.LastExamPassed.CompareTo(ExamsEndDate) < 0).OrderByDescending(x=>x);
                    foreach (Student Student in PassedExams)
                    {
                        uiContext.Send(x => listBoxResult.Items.Add(Student.Name), null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void buttonV9_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                TimeSpan ExpiredDays;
                try
                {
                    uiContext.Send(x => listBoxResult.Items.Clear(), null);
                    foreach (Book Book in Books)
                    {
                        ExpiredDays = DateTime.Now.Subtract(Book.Expire);
                        if (ExpiredDays.Days > Convert.ToInt32(textBoxInput.Text))
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Book.Title+" "+Book.Authors), null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void buttonV10_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                DateTime Date = DateTime.Parse(textBoxInput.Text);
                try
                {
                    uiContext.Send(x => listBoxResult.Items.Clear(), null);
                    foreach (Product Product in Products)
                    {
                        if (Product.Made.AddDays(Product.ExpirationDate).CompareTo(Date)<0)
                        {
                            uiContext.Send(x => listBoxResult.Items.Add(Product.Name), null);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }
    }
}
