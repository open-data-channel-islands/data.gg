select dc.name ,ds.Name, ds.Stub, ds.Source, dj.id, dj.JSON from dbo.dataset ds
join dbo.datajson dj on dj.datasetid = ds.id
join dbo.datacategory dc on dc.id = ds.datacategoryid
order by dc.name, ds.name

-- update datajson SET
-- Json = '[{"Year":2005,"Fatal":2,"Serious":25,"Slight":166},{"Year":2006,"Fatal":1,"Serious":19,"Slight":161},{"Year":2007,"Fatal":0,"Serious":21,"Slight":154},{"Year":2008,"Fatal":2,"Serious":21,"Slight":141},{"Year":2009,"Fatal":3,"Serious":15,"Slight":101},{"Year":2010,"Fatal":2,"Serious":9,"Slight":118},{"Year":2011,"Fatal":4,"Serious":10,"Slight":97},{"Year":2012,"Fatal":2,"Serious":13,"Slight":128},{"Year":2013,"Fatal":1,"Serious":9,"Slight":111},{"Year":2014,"Fatal":0,"Serious":11,"Slight":145},{"Year":2015,"Fatal":1,"Serious":10,"Slight":88},{"Year":2016,"Fatal":0,"Serious":9,"Slight":133},{"Year":2017,"Fatal":2,"Serious":18,"Slight":101},{"Year":2018,"Fatal":0,"Serious":7,"Slight":119},{"Year":2019,"Fatal":0,"Serious":7,"Slight":119},{"Year":2020,"Fatal":0,"Serious":8,"Slight":79}]'
-- , Stamp = GETDATE()
-- where id = 52