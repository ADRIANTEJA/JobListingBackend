IF NOT EXISTS (SELECT * FROM dbo.JobListing)
BEGIN
	
	INSERT INTO dbo.JobListing (Company, Logo, IsNew, IsFeatured, Position, [Role], [Level], PostedAt, ContractType, [Location])
    VALUES ('Photosnap', './images/photosnap.svg', 1, 1, 'Senior Frontend Developer', 'Frontend', 'Senior', '1d ago', 'Full Time', 'USA Only'),
    ('Manage', './images/manage.svg', 1, 1, 'Fullstack Developer', 'Fullstack', 'Midweight', '1d ago', 'Part Time', 'Remote'),
    ('Account', './images/account.svg', 1, 0, 'Junior Frontend Developer', 'Frontend', 'Junior', '2d ago', 'Part Time', 'USA Only'),
    ('MyHome', './images/myhome.svg', 0, 0, 'Junior Frontend Developer', 'Frontend', 'Junior', '5d ago', 'Contract', 'USA Only'),
    ('Loop Studios', './images/loop-studios.svg', 0, 0, 'Software Engineer', 'Fullstack', 'Midweight', '1w ago', 'Full Time', 'Worldwide'),
    ('FaceIt', './images/faceit.svg', 0, 0, 'Junior Backend Developer', 'Backend', 'Junior', '2w ago', 'Full Time', 'UK Only'),
    ('Shortly', './images/shortly.svg', 0, 0, 'Junior Developer', 'Frontend', 'Junior', '2w ago', 'Full Time', 'Worldwide'),
    ('Insure', './images/insure.svg', 0, 0, 'Junior Frontend Developer', 'Frontend', 'Junior', '2w ago', 'Full Time', 'USA Only'),
    ('Eyecam Co.', './images/eyecam-co.svg', 0, 0, 'Full Stack Engineer', 'Fullstack', 'Midweight', '3w ago', 'Full Time', 'Worldwide'),
    ('The Air Filter Company', './images/the-air-filter-company.svg', 0, 0, 'Front-end Dev', 'Frontend', 'Junior', '1mo ago', 'Part Time', 'Worldwide');
    
    INSERT INTO dbo.[Language] ([Name])
    VALUES ('Python'), ('JavaScript'), ('HTML'), ('CSS'), ('Ruby')
   
    INSERT INTO dbo.Tool ([Name])
    VALUES ('React'), ('Sass'), ('Vue'), ('Django'), ('RoR')

    INSERT INTO dbo.JobListingHasLanguage (JobListingId, LanguageId)
    VALUES (1, 3), (1, 4), (1, 2), (2, 1), (3, 2), (4, 4), (4, 2), (5, 2), (5, 5), (6, 5),
    (7, 3), (7, 2), (8, 2), (9, 2), (9, 1), (10, 2)

    INSERT INTO dbo.JobListingHasTool (JobListingId, ToolId)
    VALUES (2, 1), (3, 1), (3, 2), (5, 2), (6, 5), (7, 2), (8, 3), (8, 2), (9, 4), (10, 1),
    (10, 2)
END
