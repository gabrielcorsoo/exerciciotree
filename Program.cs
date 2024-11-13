﻿using atividadetree;

Tree tree = new Tree();

tree.Root = new Node()
{
    Data = new Person() { Name = "Zé Gotinha", Role = "Chefe Supremo" }
};

tree.Root.Children = new List<Node>()
{
    new Node() { Data = new Person() { Name = "Batman", Role = "Guardião da Tecnologia" }, Parent = tree.Root },
    new Node() { Data = new Person() { Name = "Superman", Role = "Mestre das Finanças" }, Parent = tree.Root },
    new Node() { Data = new Person() { Name = "Homem-Aranha", Role = "Rei do Marketing" }, Parent = tree.Root }
};

tree.Root.Children[0].Children = new List<Node>() { // Batman
    new Node() { Data = new Person() { Name = "Robin", Role = "Tecnologia Júnior" }, Parent = tree.Root.Children[0] }
};

tree.Root.Children[0].Children[0].Children = new List<Node>() { // Robin
    new Node() { Data = new Person() { Name = "Alfred", Role = "Assistente Técnico" }, Parent = tree.Root.Children[0].Children[0] },
    new Node() { Data = new Person() { Name = "Batgirl", Role = "Engenheira de Sistemas" }, Parent = tree.Root.Children[0].Children[0] }
};

tree.Root.Children[0].Children[0].Children[1].Children = new List<Node>() { // Batgirl
    new Node() { Data = new Person() { Name = "Pingüim", Role = "Desenvolvedor Júnior" }, Parent = tree.Root.Children[0].Children[0].Children[1] }
};  

tree.Root.Children[1].Children = new List<Node>() { // Superman
    new Node() { Data = new Person() { Name = "Lois Lane", Role = "Contadora de Superpoderes" }, Parent = tree.Root.Children[1] },
    new Node() { Data = new Person() { Name = "Lex Luthor", Role = "Analista Financeiro Malévolo" }, Parent = tree.Root.Children[1] }
};

tree.Root.Children[2].Children = new List<Node>() { // Homem-Aranha
    new Node() { Data = new Person() { Name = "Mary Jane", Role = "Gerente de Vendas" }, Parent = tree.Root.Children[2] },
    new Node() { Data = new Person() { Name = "Harry Osborn", Role = "Especialista em Marketing Digital" }, Parent = tree.Root.Children[2] },
    new Node() { Data = new Person() { Name = "Venom", Role = "Estratégia de Marca" }, Parent = tree.Root.Children[2] }
};

tree.Root.Children[2].Children[0].Children = new List<Node>()
{
    new Node() { Data = new Person() { Name = "J.J. Jameson", Role = "Analista de Mídia Social" }, Parent = tree.Root.Children[2].Children[0] },
    new Node() { Data = new Person() { Name = "Gwen Stacy", Role = "Estagiária de Marketing" }, Parent = tree.Root.Children[2].Children[0] }
};

tree.PrintTree(tree.Root);
