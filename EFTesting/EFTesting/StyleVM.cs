using ITRACK.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace EFTesting
{
    class StyleVM
    {
        Style _Style = new Style();
        NestedExpression nested = new NestedExpression();
        
        GenaricRepository<Style> _StyleRepository = new GenaricRepository<Style>(new ItrackContext());

        public void SearchStyle(DevExpress.XtraGrid.GridControl _Grid,DevExpress.XtraEditors.TextEdit _TextBox,DevExpress.XtraEditors.SimpleButton _Btn )
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Style), "s");
                Expression nameProperty = Expression.Property(argParam, "StyleID");
                Expression nameProperty2 = Expression.Property(argParam, "StyleID");


              

                var val1 = Expression.Constant(_TextBox.Text);
                var val2 = Expression.Constant(_TextBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(nameProperty2, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Style, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _StyleRepository.SearchFor(lambda1).ToList() select new { item.StyleID, item.Buyer.BuyerName, item.GarmantType, item.Article };

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



        public void SearchStyle2(DevExpress.XtraGrid.GridControl _Grid, DevExpress.XtraEditors.TextEdit _TextBox)
        {

            try
            {


                //create expression 
                ParameterExpression argParam = Expression.Parameter(typeof(Style), "s");
                Expression nameProperty = Expression.Property(argParam, "StyleID");
                Expression nameProperty2 = Expression.Property(argParam, "StyleID");




                var val1 = Expression.Constant(_TextBox.Text);
                var val2 = Expression.Constant(_TextBox.Text);
                //expresttion 1 
                Expression e1 = Expression.Call(nameProperty, "Contains", null, val1);
                // expresstion 2
                Expression e2 = Expression.Call(nameProperty2, "Contains", null, val2);
                var andExp = Expression.Or(e1, e2);


                // get expresttion to labda objet 
                var lambda1 = Expression.Lambda<Func<Style, bool>>(andExp, argParam);
                // pass object to query 
                var selected = from item in _StyleRepository.SearchFor(lambda1).ToList() select new { item.StyleID, item.Buyer.BuyerName, item.GarmantType, item.Article };

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
