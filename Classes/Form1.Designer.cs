namespace Classes;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";

        CreateButtons();

    }
     private Button[,] buttons;

    private void CreateButtons()
    {
        buttons = new Button[8, 8];
        int x = 0;
        int y = 0;
        // for (int i = 0; i < buttons.GetLength(0); i++)
        for (int i = 0; i < buttons.GetUpperBound(0); i++)
        {
            // for (int j = 0; j < buttons.GetLength(1); j++)
            for (int j = 0; j < buttons.GetUpperBound(1); j++)
            {
                buttons[i, j] = new Button();
                buttons[i, j].Width = x + 50;
                buttons[i, j].Height = 50 + y;
                this.Controls.Add(buttons[i, j]);
                x = x + 50;
                if ((i + j) % 2 == 0)
                {
                    buttons[i, j].BackColor = Color.Black;
                }
                else
                {
                    buttons[i, j].BackColor = Color.White;

                }

            }
            x = 0;
            y = y + 50;
        }
    }

   

    #endregion
}
