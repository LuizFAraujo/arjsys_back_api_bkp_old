﻿using SYS.DOMAIN.Entities.Produtos;

namespace SYS.DOMAIN.Interfaces;

public interface IProdutoRepository
{
    IEnumerable<Produto> GetAll();
    Produto GetById(int id);
    void Add(Produto produto);
    void Update(Produto produto);
    void Delete(int id);
}