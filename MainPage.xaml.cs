namespace _1RM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void OnEntryCompleted(object sender, EventArgs e)
        {
            //lbl1RM.Text = $"1 RM = {WeightLifted.Text}";
            Update();
        }

        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void btnLowerWeight_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WeightLifted.Text))
                WeightLifted.Text = "0";

            try
            {
                double w = double.Parse(WeightLifted.Text);
                w -= 2.5;
                WeightLifted.Text = w.ToString();

                Update();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private double Calc1RM(double xrm, double reps)
        {
            double oneRM = xrm * (1 + (reps / 30.0));
            return oneRM;
        }

        private void Update()
        {
            try
            {
                double wl = 0.0;
                if (!string.IsNullOrEmpty(WeightLifted.Text))
                    wl = double.Parse(WeightLifted.Text);

                int reps = 0;
                if (!string.IsNullOrEmpty(RepsCompleted.Text))
                    reps = int.Parse(RepsCompleted.Text);

                double oneRM = Calc1RM(wl, reps);

                lbl1RM.Text = ((int)oneRM).ToString();
                lbl2RM.Text = ((int)(oneRM * 0.95)).ToString();
                lbl3RM.Text = ((int)(oneRM * 0.93)).ToString();
                lbl4RM.Text = ((int)(oneRM * 0.9)).ToString();
                lbl5RM.Text = ((int)(oneRM * 0.87)).ToString();
                lbl6RM.Text = ((int)(oneRM * 0.85)).ToString();
                lbl7RM.Text = ((int)(oneRM * 0.83)).ToString();
                lbl8RM.Text = ((int)(oneRM * 0.8)).ToString();
                lbl9RM.Text = ((int)(oneRM * 0.77)).ToString();
                lbl10RM.Text = ((int)(oneRM * 0.75)).ToString();
                lbl11RM.Text = ((int)(oneRM * 0.73)).ToString();
                lbl12RM.Text = ((int)(oneRM * 0.70)).ToString();

                lbl100percent.Text = ((int)(oneRM * 1.0)).ToString();
                lbl95percent.Text = ((int)(oneRM * 0.95)).ToString();
                lbl90percent.Text = ((int)(oneRM * 0.9)).ToString();
                lbl85percent.Text = ((int)(oneRM * 0.85)).ToString();
                lbl80percent.Text = ((int)(oneRM * 0.8)).ToString();
                lbl75percent.Text = ((int)(oneRM * 0.75)).ToString();
                lbl70percent.Text = ((int)(oneRM * 0.7)).ToString();
                lbl65percent.Text = ((int)(oneRM * 0.65)).ToString();
                lbl60percent.Text = ((int)(oneRM * 0.6)).ToString();
                lbl55percent.Text = ((int)(oneRM * 0.55)).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
        }

        private void btnIncreaseWeight_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(WeightLifted.Text))
                WeightLifted.Text = "0";

            try
            {
                double w = double.Parse(WeightLifted.Text);
                w += 2.5;
                WeightLifted.Text = w.ToString();

                Update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void IncreaseReps(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RepsCompleted.Text))
                RepsCompleted.Text = "0";

            try
            {
                int r = int.Parse(RepsCompleted.Text);
                r++;
                RepsCompleted.Text = r.ToString();

                Update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void DecreaseReps(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RepsCompleted.Text))
                RepsCompleted.Text = "0";

            try
            {
                int r = int.Parse(RepsCompleted.Text);
                r--;
                if (r>0)
                    RepsCompleted.Text = r.ToString();

                Update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void RepsCompleted_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        private void RepsCompleted_Completed(object sender, EventArgs e)
        {
            Update();
        }
    }

}
