namespace MIDTERM_HO2_POKEMON_BACK_END.models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string name { get; set; }

        public int height { get; set; }
        public int weight { get; set; }

        public List<string> types { get; set; }

        public List<string> generation { get; set; }

        public string NextEvolution { get; set; }
        public string PreviousEvolution { get; set; }

        public string image { get; set; }




    }
}
