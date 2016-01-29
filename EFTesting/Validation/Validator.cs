using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ITRACK.Validator
{
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;
public class  Validator
{
	public  bool isPresent(DevExpress.XtraEditors.TextEdit textbox, string name)
	{
		if (string.IsNullOrEmpty(textbox.Text)) {
            DevExpress.XtraEditors.XtraMessageBox.Show(name + " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			textbox.Select();
			return false;
		} else {
			return true;
		}

	}

    public static bool isReqired(DevExpress.XtraEditors.TextEdit textbox, string name, ErrorProvider Errorprovider)
	{
		if (string.IsNullOrEmpty(textbox.Text)) {
			//MessageBox.Show(name & " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			Errorprovider.SetError(textbox, "This is a required");
			MessageBox.Show(name + " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			textbox.Select();
			return false;
		} else {
            Errorprovider.Clear();
			return true;
			
		}

	}

    public static bool isNumeric(DevExpress.XtraEditors.TextEdit textbox, string name)
	{

		try {
			Convert.ToInt32(textbox.Text);
			return true;
		} catch (Exception ex) {
			MessageBox.Show(name + "must be a numeric value.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			textbox.Select(0, textbox.Text.Length);
            Debug.WriteLine(ex.Message);
			return false;
		}
	}

    public static bool isWithinRange(DevExpress.XtraEditors.TextEdit textbox, string name, decimal min, decimal max)
	{
		decimal number = Convert.ToDecimal(textbox.Text);
		if (number < min || number > max) {
			MessageBox.Show(name + "must between" + min + "and " + max + ".", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		} else {
			return true;
		}
	}

	public static bool inRange(TextBox textbox, string name, int range)
	{
		int leangth = textbox.TextLength;
		if (leangth < range || range < leangth) {
			MessageBox.Show(name + "must be " + range + " digit number", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return false;
		} else {
			return true;

		}
	}

	
	//Check is Combo Present 
	public  bool isCmboPresent(DevExpress.XtraEditors.ComboBoxEdit combobox, string name)
	{
		if (string.IsNullOrEmpty(combobox.Text)) {
            DevExpress.XtraEditors.XtraMessageBox.Show(name + " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			combobox.Focus();
			return false;
		} else {
			return true;
		}
	}
    //Check is Combo Present 
    public bool isNumaricPresent(DevExpress.XtraEditors.CalcEdit combobox, string name)
    {
        if (string.IsNullOrEmpty(combobox.Text))
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(name + " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            combobox.Focus();
            return false;
        }
        else
        {
            return true;
        }
    }

    //Check is Combo Present 
    public bool isDatePresent(DevExpress.XtraEditors.DateEdit DateEditor, string name)
    {
        if (string.IsNullOrEmpty(DateEditor.Text))
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(name + " is a requierd field", "Entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DateEditor.Focus();
            return false;
        }
        else
        {
            return true;
        }
    }

	//Check input value is Not Numaric value and Return status 
	public static bool isNotNumeric(TextBox textbox, string name)
	{

		try {
			Convert.ToInt32(textbox.Text);
			MessageBox.Show(name + " must not include numeric values.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textbox.Focus();
            return false;
		

		} catch (Exception ex) {
			textbox.Select(0, textbox.Text.Length);
            Debug.WriteLine(ex.Message);
			return true;
		}
	}
	//Reguler expression validating 
	public static bool TPvalidator(TextBox textbox, string name)
	{
		Regex myRegex = new Regex("^\\d{0}\\d{9}");

		if (myRegex.IsMatch(textbox.Text)) {
			return true;
		} else {
			return false;

		}
	}


    

    public static bool IsValidEmail(string email, string name)
    {
        string expresion;
        expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        if (Regex.IsMatch(email, expresion))
        {
            if (Regex.Replace(email, expresion, string.Empty).Length == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            MessageBox.Show(name + " value must be Valid Email Address.", "Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
            return false;
        }
    }



    internal bool isPresent()
    {
        throw new NotImplementedException();
    }
}
}
    

