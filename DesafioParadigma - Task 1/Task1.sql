
-- schema
CREATE TABLE Departamento (
    Id INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(25) NOT NULL,
    PRIMARY KEY(Id)
);

CREATE TABLE Pessoa (
    Id INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(35) NOT NULL,
    Salario DECIMAL(35) NOT NULL,
    DeptId INT,
    PRIMARY KEY(Id),
    FOREIGN KEY (DeptId) REFERENCES Departamento(Id)
);

-- data
INSERT INTO Departamento
    (Id, Nome)
VALUES
    (1, 'TI'),
    (2, 'Vendas');

INSERT INTO Pessoa
    (Id, Nome, Salario,DeptId)
VALUES
    (1, 'Joe', 70000,1),
    (2, 'Henry',  80000,2),
    (3, 'Sam', 60000,2),
    (4, 'mAX', 90000,1);


--query
Select d.Nome,p.Nome,Max(Salario)Salario FROM Pessoa p INNER JOIN Departamento d ON d.Id = p.DeptId
Group By d.Id;
