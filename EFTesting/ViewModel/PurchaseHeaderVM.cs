using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTesting.ViewModel
{
    class PurchaseHeaderVM
    {
        
        NestedExpression nested = new NestedExpression();

        GenaricRepository<PurchaseOrderHeader> _PoRepository = new GenaricRepository<PurchaseOrderHeader>(new ItrackContext());

        public void SearchPo(DevExpress.XtraGrid.GridControl _Grid, DevExpress.XtraEditors.TextEdit _TextBox, DevExpress.XtraEditors.SimpleButton _Btn)
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(PurchaseOrderHeader), "s");
                Expression nameProperty = Expression.Property(argParam, "PurchaseOrderHeaderID");
                Expression nameProperty2 = Expression.Property(argParam, "StyleID");




                var val1 = Expression.Constant(_TextBox.Text);
                var val2 = Expression.Constant(_TextBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(nameProperty2, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<PurchaseOrderHeader, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _PoRepository.SearchFor(lambda1).ToList() select new { item.StyleID,item.Style.Buyer.BuyerName, item.PurchaseOrderHeaderID, item.StartDate, item.EndDate };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    _Grid.Show();
                    _Btn.Show();

                    _Grid.DataSource = selected;
                }
                else
                {
                    _Grid.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }



        public void SearchPoWithoutClose(DevExpress.XtraGrid.GridControl _Grid, DevExpress.XtraEditors.TextEdit _TextBox)
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(PurchaseOrderHeader), "s");
                Expression nameProperty = Expression.Property(argParam, "PurchaseOrderHeaderID");
                Expression nameProperty2 = Expression.Property(argParam, "StyleID");




                var val1 = Expression.Constant(_TextBox.Text);
                var val2 = Expression.Constant(_TextBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(nameProperty2, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<PurchaseOrderHeader, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _PoRepository.SearchFor(lambda1).ToList() select new { item.StyleID, item.Style.Buyer.BuyerName, item.PurchaseOrderHeaderID, item.StartDate, item.EndDate };

                //check is record exist in selected item
                if (selected.Count() > 0)
                {
                    _Grid.Show();
               

                    _Grid.DataSource = selected;
                }
                else
                {
                    _Grid.DataSource = null;
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error - B-0002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

    }
}
