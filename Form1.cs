namespace WFA240906
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            _ = MessageBox.Show(
                caption: "my first WFA program!",
                text: "Hello, World! <3",
                icon: MessageBoxIcon.Warning,
                buttons: MessageBoxButtons.OK);
        }
    }
}
