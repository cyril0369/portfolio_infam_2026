CREATE TABLE IF NOT EXISTS projet (
    id          INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    titre       VARCHAR(200) NOT NULL,
    sous_titre  VARCHAR(300),
    description TEXT,
    categorie   VARCHAR(100),
    images      TEXT[] NOT NULL DEFAULT '{}',
    videos      TEXT[] NOT NULL DEFAULT '{}'
);
