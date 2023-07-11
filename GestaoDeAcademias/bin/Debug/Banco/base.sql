--
-- File generated with SQLiteStudio v3.2.1 on dom jul 9 23:07:19 2023
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: tb_Alunos
CREATE TABLE tb_Alunos (
    N_ID_ALUNO     INTEGER       PRIMARY KEY AUTOINCREMENT,
    T_NOME_ALUNO   VARCHAR (30),
    T_TEL_ALUNO    VARCHAR (14),
    T_STATUS_ALUNO VARCHAR (1),
    N_ID_TURMA     INTEGER       REFERENCES tb_Turmas (N_ID_TURMA) ON DELETE SET NULL,
    T_FOTO_ALUNO   VARCHAR (100) 
);

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          1,
                          'CHICO',
                          '(83)95687-4259',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          2,
                          'SONALLY',
                          '(83)99568-7463',
                          'A',
                          4,
                          'D:\Projetos\GestaoDeAcademias\GestaoDeAcademias\bin\Debug\Fotos\NALLY.png'
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          3,
                          'BERTA',
                          '(81)99985-4251',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          4,
                          'ANDERSON',
                          '(83)55679-6316',
                          'A',
                          2,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          5,
                          'NATAN',
                          '(83)98756-5466',
                          'A',
                          6,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          6,
                          'EMERSON',
                          '(31)95684-5240',
                          'B',
                          1,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          7,
                          'GABRIEL',
                          '(83)99857-4232',
                          'A',
                          1,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          8,
                          'BRUNO',
                          '(83)98756-8423',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          9,
                          'PAULO',
                          '(83)98731-7252',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          10,
                          'CARLOS',
                          '(83)97568-4257',
                          'A',
                          6,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          11,
                          'YGOR',
                          '(83)98731-7259',
                          'A',
                          4,
                          'D:\Projetos\GestaoDeAcademias\GestaoDeAcademias\bin\Debug\Fotos\ygor.jpg'
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          12,
                          'PEDRO',
                          '(83)96874-5135',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          13,
                          'DARLAN',
                          '(83)95674-2563',
                          'A',
                          1,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          14,
                          'ANIBAL',
                          '(83)95784-6631',
                          'A',
                          1,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          15,
                          'ERITON',
                          '(83)94455-6231',
                          'A',
                          1,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          16,
                          'ANDRE',
                          '(83)95567-4231',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          17,
                          'MANO BROW',
                          '(31)98754-6231',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          18,
                          'THIAGO',
                          '(87)95687-4263',
                          'A',
                          2,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          19,
                          'Barros',
                          '(83)97756-4211',
                          'A',
                          2,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          20,
                          'NAIRANA',
                          '(83)95687-4212',
                          'A',
                          4,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          21,
                          'JOSE',
                          '(83)95564-7168',
                          'A',
                          2,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          22,
                          'NORISBERTO',
                          '(83)92945-1273',
                          'A',
                          2,
                          NULL
                      );

INSERT INTO tb_Alunos (
                          N_ID_ALUNO,
                          T_NOME_ALUNO,
                          T_TEL_ALUNO,
                          T_STATUS_ALUNO,
                          N_ID_TURMA,
                          T_FOTO_ALUNO
                      )
                      VALUES (
                          23,
                          'FILIPETE',
                          '(84)98875-6485',
                          'A',
                          6,
                          'D:\Projetos\GestaoDeAcademias\GestaoDeAcademias\bin\Debug\Fotos\alexa.jpg'
                      );


-- Table: tb_Horarios
CREATE TABLE tb_Horarios (
    N_ID_HORARIO   INTEGER      PRIMARY KEY AUTOINCREMENT,
    T_DESC_HORARIO VARCHAR (30) 
);

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            1,
                            '05:00 ás 07:00'
                        );

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            2,
                            '07:00 ás 08:00'
                        );

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            3,
                            '13:00 ás 14:00'
                        );

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            5,
                            '17:00 ás 18:00'
                        );

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            6,
                            '18:30 ás 19:30'
                        );

INSERT INTO tb_Horarios (
                            N_ID_HORARIO,
                            T_DESC_HORARIO
                        )
                        VALUES (
                            7,
                            '19:30 ás 20:30'
                        );


-- Table: tb_Professores
CREATE TABLE tb_Professores (
    N_ID_PROFESSORES INTEGER      PRIMARY KEY AUTOINCREMENT,
    T_NOME_PROFESSOR VARCHAR (30),
    T_TEL_PROFESSOR  VARCHAR (14) 
);

INSERT INTO tb_Professores (
                               N_ID_PROFESSORES,
                               T_NOME_PROFESSOR,
                               T_TEL_PROFESSOR
                           )
                           VALUES (
                               1,
                               'DIAMANTE',
                               '(83)99985-4530'
                           );

INSERT INTO tb_Professores (
                               N_ID_PROFESSORES,
                               T_NOME_PROFESSOR,
                               T_TEL_PROFESSOR
                           )
                           VALUES (
                               2,
                               'JUNIOR',
                               '(83)99866-5367'
                           );

INSERT INTO tb_Professores (
                               N_ID_PROFESSORES,
                               T_NOME_PROFESSOR,
                               T_TEL_PROFESSOR
                           )
                           VALUES (
                               4,
                               'THIAGO',
                               '(83)99998-1234'
                           );


-- Table: tb_Turmas
CREATE TABLE tb_Turmas (
    N_ID_TURMA     INTEGER      PRIMARY KEY AUTOINCREMENT,
    T_DESC_TURMA   VARCHAR (20),
    N_ID_PROFESSOR INTEGER      REFERENCES tb_Professores (N_ID_PROFESSORES) ON DELETE SET NULL,
    N_ID_HORARIO   INTEGER      REFERENCES tb_Horarios (N_ID_HORARIO) ON DELETE SET NULL,
    N_MAX_ALUNOS   INTEGER      DEFAULT ( -1),
    T_STATUS       VARCHAR (1)  DEFAULT A
);

INSERT INTO tb_Turmas (
                          N_ID_TURMA,
                          T_DESC_TURMA,
                          N_ID_PROFESSOR,
                          N_ID_HORARIO,
                          N_MAX_ALUNOS,
                          T_STATUS
                      )
                      VALUES (
                          1,
                          'JIU-JITSU',
                          1,
                          1,
                          10,
                          'A'
                      );

INSERT INTO tb_Turmas (
                          N_ID_TURMA,
                          T_DESC_TURMA,
                          N_ID_PROFESSOR,
                          N_ID_HORARIO,
                          N_MAX_ALUNOS,
                          T_STATUS
                      )
                      VALUES (
                          2,
                          'BOXE',
                          1,
                          2,
                          10,
                          'A'
                      );

INSERT INTO tb_Turmas (
                          N_ID_TURMA,
                          T_DESC_TURMA,
                          N_ID_PROFESSOR,
                          N_ID_HORARIO,
                          N_MAX_ALUNOS,
                          T_STATUS
                      )
                      VALUES (
                          3,
                          'JIU-JITSU',
                          2,
                          2,
                          10,
                          'A'
                      );

INSERT INTO tb_Turmas (
                          N_ID_TURMA,
                          T_DESC_TURMA,
                          N_ID_PROFESSOR,
                          N_ID_HORARIO,
                          N_MAX_ALUNOS,
                          T_STATUS
                      )
                      VALUES (
                          4,
                          'MUAITYAI',
                          1,
                          5,
                          10,
                          'A'
                      );

INSERT INTO tb_Turmas (
                          N_ID_TURMA,
                          T_DESC_TURMA,
                          N_ID_PROFESSOR,
                          N_ID_HORARIO,
                          N_MAX_ALUNOS,
                          T_STATUS
                      )
                      VALUES (
                          6,
                          'BOXE',
                          4,
                          6,
                          10,
                          'A'
                      );


-- Table: tb_Usuarios
CREATE TABLE tb_Usuarios (
    N_IdUsuario     INTEGER      PRIMARY KEY AUTOINCREMENT,
    T_NomeUsuario   VARCHAR (30),
    T_Username      VARCHAR (20),
    T_SenhaUsuario  VARCHAR (20),
    T_StatusUsuario VARCHAR (1),
    N_NivelUsuario  INTEGER
);

INSERT INTO tb_Usuarios (
                            N_IdUsuario,
                            T_NomeUsuario,
                            T_Username,
                            T_SenhaUsuario,
                            T_StatusUsuario,
                            N_NivelUsuario
                        )
                        VALUES (
                            1,
                            'Ygor',
                            'ygor',
                            '123',
                            'ATIVADO',
                            3
                        );

INSERT INTO tb_Usuarios (
                            N_IdUsuario,
                            T_NomeUsuario,
                            T_Username,
                            T_SenhaUsuario,
                            T_StatusUsuario,
                            N_NivelUsuario
                        )
                        VALUES (
                            2,
                            'Sonally',
                            'nally',
                            '695',
                            'ATIVADO',
                            3
                        );

INSERT INTO tb_Usuarios (
                            N_IdUsuario,
                            T_NomeUsuario,
                            T_Username,
                            T_SenhaUsuario,
                            T_StatusUsuario,
                            N_NivelUsuario
                        )
                        VALUES (
                            3,
                            'Livia',
                            'manu',
                            '456',
                            'ATIVADO',
                            1
                        );

INSERT INTO tb_Usuarios (
                            N_IdUsuario,
                            T_NomeUsuario,
                            T_Username,
                            T_SenhaUsuario,
                            T_StatusUsuario,
                            N_NivelUsuario
                        )
                        VALUES (
                            4,
                            'Jany',
                            'jany',
                            '789',
                            'ATIVADO',
                            2
                        );

INSERT INTO tb_Usuarios (
                            N_IdUsuario,
                            T_NomeUsuario,
                            T_Username,
                            T_SenhaUsuario,
                            T_StatusUsuario,
                            N_NivelUsuario
                        )
                        VALUES (
                            6,
                            'Gleice',
                            'gleice',
                            '789',
                            'ATIVADO',
                            2
                        );


COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
