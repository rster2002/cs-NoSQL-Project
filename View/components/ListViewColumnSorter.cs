using System;
using System.Collections;
using System.Windows.Forms;
using Model;

public class ListViewColumnSorter: IComparer {
    private int ColumnToSort;
    private SortOrder OrderOfSort;
    private CaseInsensitiveComparer ObjectCompare;

    public ListViewColumnSorter() {
        ColumnToSort = 0;
        OrderOfSort = SortOrder.None;
        ObjectCompare = new CaseInsensitiveComparer();
    }
    public int Compare(object x, object y) {
        if (ColumnToSort == 2) {
            int returnVal;
            try {
                DateTime firstDate = DateTime.Parse(((ListViewItem) x).SubItems[ColumnToSort].Text);
                DateTime secondDate = DateTime.Parse(((ListViewItem) y).SubItems[ColumnToSort].Text);

                returnVal = DateTime.Compare(firstDate, secondDate);
            } catch {
                returnVal = String.Compare(((ListViewItem) x).SubItems[ColumnToSort].Text, ((ListViewItem) y).SubItems[ColumnToSort].Text);
            }
            if (OrderOfSort == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        } else if(ColumnToSort == 4) {
            int compareResult;
            Priority listviewX, listviewY;
            listviewX = (Priority) Enum.Parse(typeof(Priority), ((ListViewItem) x).SubItems[ColumnToSort].Text.ToString());
            listviewY = (Priority) Enum.Parse(typeof(Priority), ((ListViewItem) y).SubItems[ColumnToSort].Text.ToString());
            
            compareResult = ObjectCompare.Compare(listviewX, listviewY);
            if (OrderOfSort == SortOrder.Ascending) {
                return compareResult;
            } else if (OrderOfSort == SortOrder.Descending) {
                return (-compareResult);
            } else {
                return 0;
            }
        } else {
            int compareResult;
            ListViewItem listviewX, listviewY;
            listviewX = (ListViewItem) x;
            listviewY = (ListViewItem) y;
            compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
            if (OrderOfSort == SortOrder.Ascending) {
                return compareResult;
            } else if (OrderOfSort == SortOrder.Descending) {
                return (-compareResult);
            } else {
                return 0;
            }
        }
    }
    public int SortColumn {
        set {
            ColumnToSort = value;
        }
        get {
            return ColumnToSort;
        }
    }
    public SortOrder Order {
        set {
            OrderOfSort = value;
        }
        get {
            return OrderOfSort;
        }
    }

}