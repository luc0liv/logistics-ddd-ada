﻿public class Endereco : BaseEntity
{
    public string Logradouro { get; set; }
    public int Numero { get; set; }
    public string UF { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string? Complemento { get; set;}
}

