CREATE TABLE Pessoa(
    pessoa_id INT         AUTO_INCREMENT,
    acesso    CHAR(1)     NOT NULL,
    celular   VARCHAR(16) NOT NULL,
    cpf       VARCHAR(16) NOT NULL,
    email     VARCHAR(32) NOT NULL,
    nome      VARCHAR(64) NOT NULL,
    senha     VARCHAR(64) NOT NULL,
    telefone  VARCHAR(16) NOT NULL,
    usuario   VARCHAR(32) NOT NULL,

    CONSTRAINT PK_pessoa PRIMARY KEY (pessoa_id)
);

CREATE TABLE Aluno(
    aluno_id       INT        AUTO_INCREMENT,
    cursando       BIT        DEFAULT 1,
    data_matricula DATE       NOT NULL,
    matricula      VARCHAR(8) NOT NULL,

    CONSTRAINT PK_aluno        PRIMARY KEY (aluno_id),
    CONSTRAINT FK_aluno_pessoa FOREIGN KEY (aluno_id) REFERENCES Pessoa(pessoa_id)
);

CREATE TABLE Colab(
    colab_id      INT         AUTO_INCREMENT,
    data_admissao DATE        NOT NULL,
    profissao     VARCHAR(32) NOT NULL,
    salario       FLOAT(7, 2) NOT NULL,

    CONSTRAINT PK_colab        PRIMARY KEY (colab_id),
    CONSTRAINT FK_colab_pessoa FOREIGN KEY (colab_id) REFERENCES Pessoa(pessoa_id)
);

CREATE TABLE Curso(
    curso_id      INT         AUTO_INCREMENT,
    carga_horaria INT         NOT NULL,
    instrumento   VARCHAR(16) NOT NULL,
    modelo        VARCHAR(16) NOT NULL,

    CONSTRAINT PK_curso PRIMARY KEY (curso_id)
);

CREATE TABLE Aula(
    aula_id         INT         AUTO_INCREMENT,
    curso_id        INT         NOT NULL,
    professor_id    INT         NOT NULL,
    data_realizacao DATE        NOT NULL,
    modelo          VARCHAR(16) NOT NULL,

    CONSTRAINT PK_aula       PRIMARY KEY (aula_id),
    CONSTRAINT FK_aula_curso FOREIGN KEY (curso_id) REFERENCES Curso(curso_id)
);

CREATE TABLE Evento(
    evento_id       INT          AUTO_INCREMENT,
    resp_id         INT          NOT NULL,
    data_realizacao DATE         NOT NULL,
    descricao       VARCHAR(255) NOT NULL,
    hora_inicio     TIME         NOT NULL,
    hora_termino    TIME         NOT NULL,
    localidade      VARCHAR(32)  NOT NULL,
    publico_alvo    VARCHAR(32)  NOT NULl,

    CONSTRAINT PK_evento     PRIMARY KEY (evento_id),
    CONSTRAINT FK_resp_colab FOREIGN KEY (resp_id) REFERENCES Colab(colab_id)
);

CREATE TABLE Mensagem(
    mensagem_id   INT  AUTO_INCREMENT,
    dest_id       INT  NOT NULL,
    remet_id      INT  NOT NULL,
    conteudo      TEXT NOT NULL,
    data_envio    DATE DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT PK_mensagem    PRIMARY KEY (mensagem_id),
    CONSTRAINT FK_dest_colab  FOREIGN KEY (dest_id)  REFERENCES Colab(colab_id),
    CONSTRAINT FK_remet_aluno FOREIGN KEY (remet_id) REFERENCES Aluno(aluno_id)
);