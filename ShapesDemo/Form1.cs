namespace ShapesDemo
{
    public partial class Form1 : Form
    {

        //variable

        GeometricFigure shape;
        string output;

        public Form1()
        {
            InitializeComponent();
        }


        // do everthing when this button is pressed. 
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(HeightTextBox.Text) <= 0) // checks to make sure its not computing negative area
            {
                ErrorLabel.Text = " Height must be a positive Number! Try Again!";
            }
            else if (Convert.ToInt32(WidthTextBox.Text) <= 0) // checkks to make sure its not computing negative area
            {
                ErrorLabel.Text = "Width must be a positive Number! Try Again!";
            }

            else //continue if no number is negative 
            {
                if (ChooseBox.SelectedIndex == 0) //checks which item is being selected 
                {

                    shape = new Rectangle(Convert.ToInt32(HeightTextBox.Text), Convert.ToInt32(WidthTextBox.Text)); //creates a shape class of the rectangle type 
                    output = "Rectangle\r\nHeight:  "; // sets text to output 
                    output += shape.Height; //appends to the end of ouput the direct hieght that was passed to the Geometric Figure
                    output += "\r\nWidth: "; // appends more text
                    output += shape.Width; //appends to end of ouput the direct width that was passed down to the geometric figure 
                    output += "\r\nArea:  " + shape.ComputeArea(); // appends more text as as calls forth a the computeArea method 
                    ShapeTextLabel.Text = output; // lastly assigns all collect strings of output to shapeTextLabel so that it displays everything
                }
                 // similiar order of operations ocurres for the following choices of square and triangle. 
                else if (ChooseBox.SelectedIndex == 1)
                {
                    if (Convert.ToInt32(HeightTextBox.Text) != Convert.ToInt32(WidthTextBox.Text))
                    {
                        ErrorLabel.Text = "Height and Width need to be the same for a Square";
                    }
                    else
                    {
                        shape = new Square(Convert.ToInt32(HeightTextBox.Text));
                        output = "Square\r\nHeight:  ";
                        output += shape.Height;
                        output += "\r\nWidth: ";
                        output += shape.Width;
                        output += "\r\nArea:  " + shape.ComputeArea();
                        ShapeTextLabel.Text = output;
                    }
                }
                else if (ChooseBox.SelectedIndex == 2)
                {
                    shape = new Triangle(Convert.ToInt32(HeightTextBox.Text), Convert.ToInt32(WidthTextBox.Text));
                    output = "Triangle\r\nHeight:  ";
                    output += shape.Height;
                    output += "\r\nWidth: ";
                    output += shape.Width;
                    output += "\r\nArea:  " + shape.ComputeArea();
                    ShapeTextLabel.Text = output;
                }
            }

            
        }
        
        
        
        
        //clears out the inputs for shape and as well as the ShapeText Label. 
        private void EraseButton_Click(object sender, EventArgs e)
        {
            shape = null;
            ShapeTextLabel.Text = "";


        }

       
    }
}