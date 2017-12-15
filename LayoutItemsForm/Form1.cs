using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LayoutItemsForm
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      public Form1()
      {
         InitializeComponent( );
         this.f( );
      }

      private void f()
      {
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).BeginInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).BeginInit( );
         this.SuspendLayout( );
         {
            this.x( );
         }
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).EndInit( );
         this.ResumeLayout( false );
         this.PerformLayout( );
      }
      private void x()
      {
         LayoutControl lc = this.layoutControl1; // new LayoutControl( );
         LayoutControlGroup rg = lc.Root;
         {
            lc.Dock = System.Windows.Forms.DockStyle.Fill;
            Form1.configRootGroup( rg );

            LayoutControlItem item1 = rg.AddItem( );
            {
               item1.Name = "Layout Item 1";
               item1.Text = "Name";
               Control textBox1 = item1.Control = new TextEdit( );
               {
                  textBox1.Name = "TextBox1";
               }
            }
            LayoutControlItem item2 = new LayoutControlItem( );
            {
               item2.Parent = lc.Root;
               item2.Name = "Layout Item 2";
               item2.Text = "E-mail";
               Control textBox2 = item2.Control = new TextEdit( );
               {
                  textBox2.Name = "TextBox2";
               }
            }
            // Create a hidden layout item. 
            LayoutControlItem item3 = new LayoutControlItem( );
            {
               lc.HiddenItems.AddRange( new BaseLayoutItem[ ] { item3 } );
               item3.Name = "Layout Item 3";
               item3.Text = "Notes";
               Control textBox3 = item3.Control = new MemoEdit( );
               {
                  textBox3.Name = "TextBox3";
               }
            }
         }
      }

      private static void configRootGroup( LayoutControlGroup rg )
      {
         //
         // rg.AllowHide = false;
         // rg.AllowCustomizeChildren = false;
         //
         rg.GroupBordersVisible = true;
         rg.Text = "Root Group";
         rg.TextLocation = DevExpress.Utils.Locations.Top;
         rg.TextVisible = true;
         //
         rg.Expanded = true; // BUG?!
         rg.ExpandOnDoubleClick = true;
         rg.ExpandButtonVisible = true;
         rg.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
         //
         // rg.CustomHeaderButtons.Add( button );
         // rg.CustomButtonClick += ...,
         // LayoutGroup.CustomButtonChecked += ...
         // LayoutGroup.CustomButtonUnchecked += events.

         //
         // rg.CaptionImage = null;
         // rg.Images = null;
         // rg.CaptionImageIndex = -1;
      }
   }
}
