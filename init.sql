CREATE TABLE IF NOT EXISTS projet (
    id          INTEGER GENERATED ALWAYS AS IDENTITY PRIMARY KEY,
    titre       VARCHAR(200) NOT NULL,
    sous_titre  VARCHAR(300),
    description TEXT,
    categorie   VARCHAR(100),
    images      TEXT[] NOT NULL DEFAULT '{}',
    videos      TEXT[] NOT NULL DEFAULT '{}'
);

INSERT INTO projet (titre, sous_titre, description, categorie, images, videos )
VALUES (
    'titre exemple',
    'sous titre exemple',
    'descrition exemple',
    'cat exemple',
    ARRAY['logo1.jpg','logo2.jpg'],
    ARRAY['video.mp4']
);