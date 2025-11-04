using System.Diagnostics;

namespace PK_Team_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Debug.WriteLine(Pokemon.GetTypeEffectiveness(Moves.Pound, Types.Ghost));
        }
    }
}
