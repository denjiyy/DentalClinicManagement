using DentalClinicManagement.Classes;

public class ToothUserControl : UserControl
{
    public Label toothNumberLabel;
    public Label statusLabel;
    public Label crownStatusLabel;
    public Label notesLabel;
    public Label NotesLabel { get { return notesLabel; } }

    private Tooth? tooth;

    public ToothUserControl(Tooth tooth)
    {
        toothNumberLabel = new Label();
        statusLabel = new Label();
        crownStatusLabel = new Label();
        notesLabel = new Label();

        this.tooth = tooth;

        this.Controls.Add(toothNumberLabel);
        this.Controls.Add(crownStatusLabel);
        this.Controls.Add(statusLabel);
        this.Controls.Add(notesLabel);

        toothNumberLabel.Location = new Point(10, 10);
        toothNumberLabel.AutoSize = true;

        statusLabel.Location = new Point(10, 30);
        statusLabel.AutoSize = true;

        crownStatusLabel.Location = new Point(10, 50);
        crownStatusLabel.AutoSize = true;

        notesLabel.Location = new Point(10, 70);
        notesLabel.AutoSize = true;
    }

    /*public string Notes
    {
        get { return notesLabel.Text; }
        set { notesLabel.Text = value; }
    }*/

    public Tooth? Tooth
    {
        get { return tooth; }
        set { tooth = value; }
    }

    private void ToothUserControl_Load(object sender, EventArgs e)
    {
    }

    /*private void InitializeComponent(Tooth tooth)
    {
        SuspendLayout();
        // 
        // ToothUserControl
        // 
        Name = "ToothUserControl";
        Load += ToothUserControl_Load_2;
        this.tooth = tooth;
        toothNumberLabel.Text = tooth.ToothNumber.ToString();
        statusLabel.Text = tooth.ToothStatus.GetStatus().ToString();
        crownStatusLabel.Text = tooth.CrownStatus.ToString();
        notesLabel.Text = tooth.Notes.ToString();
        ResumeLayout(false);
    }*/

    private void ToothUserControl_Load_1(object sender, EventArgs e)
    {
    }

    private void ToothUserControl_Load_2(object sender, EventArgs e)
    {

    }

    private void InitializeComponent()
    {

    }

    private void ToothUserControl_Load_3(object sender, EventArgs e)
    {
    }
}
