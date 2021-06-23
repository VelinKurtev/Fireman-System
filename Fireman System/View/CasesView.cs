using System;
using System.Linq;
using System.Windows.Forms;
using Fireman_Systemn.Controller;
using Fireman_Systemn.View.EditViews;
using Fireman_Systemn.View.Pop_Ups;

namespace Fireman_Systemn.View
{
    public partial class CasesView : Form
    {
        CasesController CasesController = new CasesController();
        Cases Case = new Cases();
        public CasesView()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new MainMenuView());
        }

        private void Cases_Load(object sender, EventArgs e)
        {
            FormLayout.FormLoad(this);
            Refresh_table();
        }

        private void btn_add_case_Click(object sender, EventArgs e)
        {
            FormLayout.NavigateForms(this, new Add_Case_View());
        }

        private void Refresh_table()
        {
            dgvCases.DataSource = CasesController.GetAll();
        }

        private void btn_delete_case_Click(object sender, EventArgs e)
        {

            var row = dgvCases.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
            else
            {
                try
                {
                    int id = int.Parse(row.Cells["CaseID"].Value.ToString());
                    CasesController.Delete(id);
                    Refresh_table();
                    DeleteRow deleteRow = new DeleteRow();
                    deleteRow.ShowDialog();
                }
                catch
                {
                    InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                    invalidRowSelected.ShowDialog();
                    FormLayout.NavigateForms(this, new CasesView());
                }

            }

        }

        private void btn_update_table_Click(object sender, EventArgs e)
        {
            var row = dgvCases.CurrentRow;

            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
            else
            {
                int id = int.Parse(row.Cells["CaseID"].Value.ToString());
                using (FiremanSysEntities fse = new FiremanSysEntities())
                {
                    var fireCase = fse.Cases.Where(c => c.case_id == id).FirstOrDefault();
                    FormLayout.NavigateForms(this, new CaseView(fireCase));
                }
            }
        }

        private void btn_end_case_Click(object sender, EventArgs e)
        {
            var row = dgvCases.CurrentRow;
            if (row == null)
            {
                InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                invalidRowSelected.ShowDialog();
            }
            else
            {
                try
                {
                    int id = int.Parse(row.Cells["CaseID"].Value.ToString());
                    using (FiremanSysEntities fse = new FiremanSysEntities())
                    {
                        var fireCase = fse.Cases.Where(c => c.case_id == id).FirstOrDefault();
                        var team = fse.Teams.Where(t => t.team_id == fireCase.Selected_team).FirstOrDefault();
                        if (fireCase.End_date_time_of_case == null)
                        {
                            if (team != null)
                            {
                                team.is_team_busy = "Свободен";
                                fse.Teams.Attach(team);
                                fse.Entry(team).State = System.Data.Entity.EntityState.Modified;
                                fse.SaveChanges();
                            }
                            fireCase.End_date_time_of_case = DateTime.Now;
                            fse.SaveChanges();
                            EndCase endCase = new EndCase();
                            endCase.ShowDialog();
                            FormLayout.NavigateForms(this, new CasesView());
                        }
                        else
                        {
                            InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                            invalidRowSelected.ShowDialog();
                        }
                    }
                }
                catch
                {
                    InvalidRowSelected invalidRowSelected = new InvalidRowSelected();
                    invalidRowSelected.ShowDialog();
                }
            }
        }
    }
}
