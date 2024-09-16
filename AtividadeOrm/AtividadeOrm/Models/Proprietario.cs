namespace AtividadeOrm.Models
{
    public class Proprietario
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Para fazer um relacionamento um pra muitos entre proprietario e veiculo
        public ICollection <Veiculo> veiculos { get; set; }
    }
}
