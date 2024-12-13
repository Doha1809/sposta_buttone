namespace sposta_buttone
{
    public partial class Form1 : Form
    {
        Button pulsante;


        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            pulsante = new Button();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pulsante.Size = new System.Drawing.Size(20, 20);
            pulsante.Location =new Point(ClientSize.Width/2 , 20);
            Controls.Add(pulsante);

            Thread thread1 = new Thread(Sposta_sin);
            Thread thread2 = new Thread(Sposta_dis);
            thread1.Start();
            thread2.Start();
        }
        int posizione;
        private void Sposta_sin()
        { 
            while (pulsante.Location.X<ClientSize.Width)
            {
                Random generatore = new Random();
                int ritardo = generatore.Next(0,50);
                Thread.Sleep(ritardo);
                pulsante.Location = new System.Drawing.Point(pulsante.Location.X + 10, 20);

            }
        }
       int  posizione2;
        private void Sposta_dis()
        { 
            while (pulsante.Location.X>0)
            {
                Random generatore = new Random();
                int ritardo = generatore.Next(0,50);
                Thread.Sleep(ritardo);
                pulsante.Location = new System.Drawing.Point(pulsante.Location.X - 10, 20);

            }
        }

    }
   
}
    