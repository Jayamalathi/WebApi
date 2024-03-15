if not exists(select 1 from dbo.[user])
begin
    insert into dbo.[user] (Firstname,lastname) values ('jaya','malathi'),
    ('shenba','priya'),('yahvi','prabha'),('pal','wari');
end