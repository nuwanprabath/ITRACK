﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using ITRACK.models;
using System.IO;
using ITRACK.Validator;

namespace EFTesting.UI
{
    public partial class frmOparationScaning : DevExpress.XtraEditors.XtraForm
    {
        public frmOparationScaning()
        {
            InitializeComponent();
        }


        public string  BarcodeID { get; set; }
        public string  Grade { get; set; }

        public string  Role  { get; set; }

        public Employee Employee { get; set; }



        #region Scaning Operations



        GenaricRepository<Employee> _EmployeeRepository = new GenaricRepository<Employee>(new ItrackContext());


        private void scaning(string barcode) {

            if (barcode.Length > 6 && barcode.Length == 14)
            {
                if (txtEmployeeID.Text != "")
                {
                    ScanBarcode(barcode);
                }
                else 
                {
                    MessageBox.Show("Please Scan Employee ID before Scan Oprations !", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
           
            }
            else
            {

                ScaningEmployee(barcode);
            
            }
        }


        private void ScanBarcode(string _barcode) {
            try {
                GenaricRepository<OprationBarcodes> _BarcodeRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                foreach (var barcode in _BarcodeRepository.GetAll().Where(p => p.OprationBarcodesID == _barcode).ToList()) {

                  txtStyleNo.Text =   barcode.BundleDetails.BundleHeader.CuttingItem.CuttingHeader.StyleID;
                  txtBundleNo.Text =Convert.ToString( barcode.BundleDetails.BundleDetailsID);
                  txtNoOfPCS.Text = Convert.ToString(barcode.BundleDetails.NoOfItem);
                  txtOperationNo.Text = barcode.OprationNO;
                  txtOperationName.Text = barcode.OparationName;
                  txtSize.Text = barcode.BundleDetails.BundleHeader.CuttingItem.Size;
                  txtColor.Text = barcode.BundleDetails.BundleHeader.CuttingItem.Color;
                  txtPartName.Text = barcode.PartName;
                  txtComplatedAt.Text = Convert.ToString(DateTime.Now);
                  lblTextDisplay.Text ="Last Scaning Opration is :"+ _barcode  + "  "+ barcode.OparationName;
                  this.BarcodeID = _barcode;
                  this.Grade = barcode.OprationGrade;
                  this.Role = barcode.OprationRole;
                  UpdateOprationStatus();



                }
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        
        }

      

        private void UpdateOprationStatus() {
            try {
                GenaricRepository<OprationBarcodes> _BarcodeEditRepository = new GenaricRepository<OprationBarcodes>(new ItrackContext());
                OprationBarcodes _barcode = new OprationBarcodes();
                _barcode.OprationComplteAt = DateTime.Now;
                _barcode.isOparationComplete = true;
                _barcode.EmployeeID = txtEmployeeID.Text;
                _barcode.OprationBarcodesID = this.BarcodeID;
                _barcode.OprationNO = txtOperationNo.Text;
                _barcode.OparationName = txtOperationName.Text;
                _barcode.OprationGrade = this.Grade;
                _barcode.OprationRole = this.Role;
                _barcode.BundleDetailsID =Convert.ToInt16( txtBundleNo.Text);
                _barcode.PartName = txtPartName.Text;
                _BarcodeEditRepository.Update(_barcode);

            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }



        private void ScaningEmployee(string _barcode) {
            try {

                GenaricRepository<Employee> _EmployeeRepository = new GenaricRepository<Employee>(new ItrackContext());
                foreach (var employee in _EmployeeRepository.GetAll().Where(p => p.EmployeeID == _barcode).ToList()) {

                    txtEmployeeID.Text = employee.EmployeeID;
                    txtEmployeeName.Text = employee.FullName;
                    txtEPFNo.Text = employee.EPFNo;
                    txtDesignation.Text = employee.Designation;
                    Employee = employee;

                    byte[] picture = employee.Image;
                    imgprofile.Image = Image.FromStream(new MemoryStream(picture));
                    imgprofile.Refresh();
                }
            
            
            }
            catch(Exception ex){
                Debug.WriteLine(ex.Message);
            }
        }

        #endregion



        private void textEdit13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13) {
                Debug.WriteLine(txtBarcode.Text);
                scaning(txtBarcode.Text);
                txtBarcode.Text = "";
                txtBarcode.Focus();
            }
        }

        private void txtBarcode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmOparationScaning_Load(object sender, EventArgs e)
        {

        }
    }
}