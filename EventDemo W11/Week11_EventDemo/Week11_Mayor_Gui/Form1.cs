using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week11_Mayor_Gui
{
    public partial class Form1 : Form
    {
        Dictionary<string, Mayor> mayors = new Dictionary<string, Mayor>();
        int mayorIndex = 0;
        public Form1()
        {
            InitializeComponent();
            foreach (Mayor mayor in Mayor.CreateMayors())
            {
                string key = mayor.Name.Split().Last();
                if (mayors.ContainsKey(key))
                    continue;
                mayors.Add(key, mayor);
            }
            DisplayMayor();
        }
        void DisplayMayor()
        {
            Mayor mayor = mayors.ElementAt(mayorIndex).Value;

            lblTo.Text = $"To: {mayor.End}";
            lblFrom.Text = $"From: {mayor.Start}";
            lblName.Text = mayor.Name;
            pboxName.Image = mayor.GetImage();
        }
        private void btnFirst_Click(object sender, EventArgs e)
        {
            mayorIndex = 0;
            DisplayMayor();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            mayorIndex--;
            if (mayorIndex < 0)
                mayorIndex = 0;
            DisplayMayor();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            mayorIndex++;
            if (mayorIndex == mayors.Count)
                mayorIndex = mayors.Count - 1;
            DisplayMayor();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            mayorIndex = mayors.Count - 1;
            DisplayMayor();
        }
    }
    class Mayor
    {
        public string Name { get; }
        public string Start { get; }
        public string End { get; }

        public Mayor(string name, string start, string end)
        {
            Name = name; Start = start; End = end;
        }
        public Bitmap GetImage(int width = 300, int height = 400)
        {
            Bitmap result = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(result);
            g.Clear(Color.Aquamarine);
            int linePos = 0;
            foreach (var part in Name.Split())
            {
                g.DrawString(part, new Font("Arial", 36f), Brushes.Black, 20, linePos += 64);
                g.DrawString(part, new Font("Arial", 36f), Brushes.Aqua, 20 - 3, linePos - 2);
            }
            return result;
        }
        public static List<Mayor> CreateMayors()
            => new List<Mayor>
            {
                new Mayor("William Lyon Mackenzie", "1834 (March 27)", "1835"),
                new Mayor("Robert Baldwin Sullivan", "1835 (January 15)", "1836"),
                new Mayor("Thomas David Morrison", "1836", "1837"),
                new Mayor("George Gurnett", "1837", "1838"),
                new Mayor("John Powell", "1838", "1841"),
                new Mayor("George Monro", "1841", "1842"),
                new Mayor("Henry Sherwood", "1842", "1845"),
                new Mayor("William H. Boulton", "1845", "1848"),
                new Mayor("George Gurnett", "1848", "1851"),
                new Mayor("John George Bowes", "1851", "1854"),
                new Mayor("Joshua George Beard", "1854", "1855"),
                new Mayor("George William Allan", "1855", "1856"),
                new Mayor("John Beverley Robinson", "1856", "1857"),
                new Mayor("John Hutchison", "1857", "1858 (resigned)"),
                new Mayor("William H. Boulton", "1858", "1858 (resigned November 8)"),
                new Mayor("David Breakenridge Read", "1858 (November 11)", "1858 (December 31)"),
                new Mayor("Francis Henry Medcalf", "1864", "1867"),
                new Mayor("John George Bowes", "1861", "1864"),
                new Mayor("(Sir) Adam Wilson", "1859", "1861"),
                new Mayor("James Edward Smith", "1867", "1869"),
                new Mayor("Samuel Bickerton Harman", "1869", "1871"),
                new Mayor("Joseph Sheard", "1871", "1873"),
                new Mayor("Alexander Manning", "1873", "1874"),
                new Mayor("Francis Henry Medcalf", "1874", "1875"),
                new Mayor("Angus Morrison", "1876", "1878"),
                new Mayor("James Beaty", "1879", "1880"),
                new Mayor("William Barclay McMurrich", "1881", "1882"),
                new Mayor("Arthur Radcliffe Boswell", "1883", "1884"),
                new Mayor("Alexander Manning", "1885", "1885"),
                new Mayor("William Holmes Howland", "1886", "1887"),
                new Mayor("Edward Frederick Clarke", "1888", "1891"),
                new Mayor("Robert John Fleming", "1892", "1893"),
                new Mayor("Warring Kennedy", "1894", "1895"),
                new Mayor("Robert John Fleming", "1896", "1897 (resigned August 5)"),
                new Mayor("John Shaw", "1897 (August 6)", "1899"),
                new Mayor("Ernest A. Macdonald", "1900", "1900"),
                new Mayor("Oliver Aiken Howland", "1901", "1902"),
                new Mayor("Thomas Urquhart", "1903", "1905"),
                new Mayor("Emerson Coatsworth", "1906", "1907"),
                new Mayor("Joseph Oliver", "1908", "1909"),
                new Mayor("George Reginald Geary", "1910", "1912 (resigned October 21)"),
                new Mayor("Horatio C. Hocken", "1912", "1914"),
                new Mayor("Thomas Langton Church", "1915", "1921"),
                new Mayor("Charles A. Maguire", "1922", "1923"),
                new Mayor("W. W. Hiltz", "1924", "1924"),
                new Mayor("Thomas Foster", "1925", "1927"),
                new Mayor("Sam McBride", "1928", "1929"),
                new Mayor("Bert Sterling Wemp", "1930", "1930"),
                new Mayor("William James Stewart", "1931", "1934"),
                new Mayor("James Simpson", "1935", "1935"),
                new Mayor("Sam McBride", "1936", "1936 (died November 10)"),
                new Mayor("William D. Robbins", "1936 (November 18)", "1937"),
                new Mayor("Ralph C. Day", "1938", "1940"),
                new Mayor("Frederick J. Conboy", "1941", "1944"),
                new Mayor("Robert Hood Saunders", "1945", "1948 (resigned February 23)"),
                new Mayor("Hiram E. McCallum", "1948", "1951"),
                new Mayor("Allan Lamport", "1952 (January 1)", "Alderman for Ward 2 (1937)"),
                new Mayor("Leslie Howard Saunders", "1954 (June 28)", "1954 (November 30)"),
                new Mayor("Nathan Phillips", "1955 (January 1)", "1962 (November 30)"),
                new Mayor("Donald Dean Summerville", "1963 (January 1)", "November 19, 1963 (died in office) [7]"),
                new Mayor("Philip Givens", "1963 (November 19)", "1966 (December 31)"),
                new Mayor("William Dennison", "1967 (January 1)", "1972 (December 31)"),
                new Mayor("David Crombie", "1973 (January 1)", "1978 (August 31)"),
                new Mayor("Fred Beavis", "1978 (September 1)", "1978 (November 30)"),
                new Mayor("John Sewell", "1978 (December 1)", "1980 (November 30)"),
                new Mayor("Art Eggleton", "1980 (December 1)", "1991 (November 30)"),
                new Mayor("June Rowlands", "1991 (December 1)", "1994 (November 30)"),
                new Mayor("Barbara Hall", "1994 (December 1)", "1997 (December 31)"),
                new Mayor("Mel Lastman", "1998 (January 1)", "2003 (November 30)"),
                new Mayor("David Miller", "2003 (December 1)", "2010 (November 30)"),
                new Mayor("Rob Ford", "2010 (December 1)", "2014 (November 30)"),
                new Mayor("John Tory", "2014 (December 1)", "Present")
            };
    }
}
