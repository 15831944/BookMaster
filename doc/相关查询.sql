SELECT   MAX(BookBorrowID) AS maxbrId, RCode, ReaderName, COUNT(*) AS borrowBooks, MAX(BorrowDate) AS LastBorrowDate, 
                MAX(ReturnDate) AS LastReturnDate
FROM      S_BookBorrow a
GROUP BY RCode, ReaderName

;

select * from S_BookBorrow
where BorrowDate='2017/12/6'
order by RCode, BorrowDate

select * from S_BookBorrow
where BorrowDate='2017/12/6'
order by RCode, BorrowDate

--1. 按人查询借书情况：详细  00055735: 徐永烨
select * from S_BookBorrow
where RCode='00055735'


--2. 按人查询：借书次数，每次借书本书， 总借书次数，总借书本书; 上次借书距今天数,  00055735: 徐永烨

--2.1 按照“借书日期”进行统计，借书次数
select RCode, BorrowDate, 
       count(BorrowDate)  PreBorrowBookNums  -- 每次借书本书
  from S_BookBorrow
 where RCode='00055735'
 group by RCode, BorrowDate

--2.2 每次借书4本，但是还书时不一定是4本，或许会少; 这样会导致group by查询，出现“还书次数>借书次数”
select BorrowDate, ReturnDate, count(BorrowDate) from S_BookBorrow
where RCode='00055735'
group by BorrowDate,ReturnDate

/*
--- 统计:借书总次数:allBrTimes, 总本书:allBrBookNums, 距今天数: daysAgo
Rcode: 读者编号
LastBorrowDate: 最后一次借书日期
LastReturnDate : 最后一次还书日期
sumBrBooks: 总借书本书
sumRtBooks: 总还书本书
NotRtBooks: 未还本书
daysAgo: 最后一次借书距今时间
*/

select max(RCode) Rcode, 
       max(LastBorrowDate) as LastBorrowDate,
       max(LastFactReturnDate) as LastReturnDate,
       sum(PreBorrowBookNums) as sumBrBooks, 
       sum(PreReturnBookNums) as sumRtBooks,
       sum(PreBorrowBookNums)  -  sum(PreReturnBookNums) as NotRtBooks,
       min(daysAgo) as daysAgo   
  from (
				select RCode, 
							 MAX(BorrowDate) AS LastBorrowDate, 
							 MAX(FactReturnDate) AS LastFactReturnDate,   
				       count(BorrowDate) as PreBorrowBookNums,   
				       count(FactReturnDate) as PreReturnBookNums,
				       DateDiff("d", BorrowDate, Now()) daysAgo   
				  from S_BookBorrow
				 where RCode='00055735'
				 group by RCode, BorrowDate,FactReturnDate
				)
	group by Rcode
;				

--- 创建视图
create view  V_TJ_BorrowInfo
(rcode, name, tel, mobile, LastBorrowDate, LastReturnDate, sumBrBooks, sumRtBooks, NotRtBooks, daysAgo)
as
select n.readercode,  n.name, n.tel, n.mobile, n.ValidityDate, n.stop,
       m.LastBorrowDate1, m.LastReturnDate1, m.sumBrBooks, m.sumBookPrice1,  m.sumRtBooks, m.NotRtBooks, m.daysAgo1
  from 
(
select max(RCode) as Rcode1, 
       max(LastBorrowDate) as LastBorrowDate1,
       max(LastFactReturnDate) as LastReturnDate1,
       sum(PreBorrowBookNums) as sumBrBooks, 
       sum(sumBookPrice) as sumBookPrice1,
       sum(PreReturnBookNums) as sumRtBooks,
       sum(PreBorrowBookNums)  -  sum(PreReturnBookNums) as NotRtBooks,
       min(daysAgo) as daysAgo1 
  from (
				select RCode, 
							 MAX(BorrowDate) AS LastBorrowDate, 
							 MAX(FactReturnDate) AS LastFactReturnDate,   
				       count(BorrowDate) as PreBorrowBookNums,   
				       count(FactReturnDate) as PreReturnBookNums,
				       sum(BookPrice) as sumBookPrice,
				       DateDiff("d", BorrowDate, Now()) as daysAgo   
				  from S_BookBorrow
				  where BorrowDate between #2019-01-01# and #019-09-16#
				 group by RCode, BorrowDate,FactReturnDate
				)
	group by Rcode
) m, t_reader n
where m.rcode1 = n.readercode

select n.readercode,  n.name, ValidityDate
from t_reader n
;

--2.4 按读者分析： 统计每年，每月的借阅图书数量信息	, 每月的借阅人次信息, 
select Format(BorrowDate, 'YYYY-mm') as ny, count(BorrowDate) as jysl
  from S_BookBorrow	
 where BorrowDate between #2019-01-01# and #019-09-16#
 group by Format(BorrowDate, 'YYYY-mm')   
	
-- 每月借阅人次
select count(rcode), Format(ny, 'YYYY-mm') 
from (	
	select Format(BorrowDate, 'YYYY-mm-dd') as ny, rcode, count(BorrowDate) as jysl
	  from S_BookBorrow	
	 where BorrowDate between #2019-01-01# and #019-09-16#
	 group by Format(BorrowDate, 'YYYY-mm-dd'), rcode 
 ) 	
group by Format(ny, 'YYYY-mm') 
	
--集成	
select m.ny, m.jysl, n.jyrc
from 	
(
-- 每月借阅本数
select Format(BorrowDate, 'YYYY-mm') as ny, count(BorrowDate) as jysl
  from S_BookBorrow	
 where BorrowDate between #2019-01-01# and #019-09-16#
 group by Format(BorrowDate, 'YYYY-mm')   
) m, 
(
-- 每月借阅人次
select count(rcode)  as jyrc, Format(ny, 'YYYY-mm') as ny
from (	
	select Format(BorrowDate, 'YYYY-mm-dd') as ny, rcode, count(BorrowDate) as jysl
	  from S_BookBorrow	
	 where BorrowDate between #2019-01-01# and #019-09-16#
	 group by Format(BorrowDate, 'YYYY-mm-dd'), rcode 
 ) 	
group by Format(ny, 'YYYY-mm') 
)	n
where m.ny = n.ny
	
	
--2.3 统计:借书总次数:allBrTimes, 总本书:allBrBookNums, 距今天数: daysAgo
select count(*) as allBrTimes, 
       sum(PreBorrowBookNums) as allBrBookNums,
       max(LastBorrowDate) as LastBorrowDate,
       max(LastReturnDate) as LastReturnDate,
       min(daysAgo) as daysAgo
  from (select RCode, count(*) as PreBorrowBookNums,
  						 MAX(BorrowDate) AS LastBorrowDate, 
               MAX(ReturnDate) AS LastReturnDate,
               DateDiff("d", BorrowDate, Now()) daysAgo
          from S_BookBorrow
 				 where RCode='00055735'
 				 group by RCode, BorrowDate
  		 )



select RCode, count(*) as PreBorrowBookNums,
  						 MAX(BorrowDate) AS LastBorrowDate, 
               MAX(ReturnDate) AS LastReturnDate,
               DateDiff("d", BorrowDate, Now()) diffday
          from S_BookBorrow
 				 where RCode='00055735'
 				 group by RCode, BorrowDate


select t.今天 from(select top 1 * ,Format(Date(),"yyyy-mm-dd") as 今天 from S_BookBorrow) t;
 				 
select RCode, count(*) as PreBorrowBookNums,
  						 MAX(BorrowDate) AS LastBorrowDate, 
               MAX(ReturnDate) AS LastReturnDate,
               date()
          from S_BookBorrow
 				 where RCode='00055735'
 				 group by RCode, BorrowDate 				 
 				 
 				 


select RCode, count(*) from S_BookBorrow
where RCode='00055735'
select * from S_BookBorrow
order by RCode, BorrowDate

select * 
from S_BookBorrow
where BookBorrowID=4386


----图书查询
SELECT BookCode, Name, NameCode, BookPlace, BookPrice, Barcode, RegDate, Number, RestNumber
  FROM T_Book
  where Barcode is not null
  
  
  SELECT *
  FROM T_Book
  where BookCode=''
  
SELECT   BookBorrowID, RCode, Code, BorrowDate, ReturnDate, RenewDate, RenewTimes, State, RentDay, Rent, ExceedDay, 
                ExceedFund, Operator, IsPay, FactReturnDate, BookCode, Name, NameCode, ISBN, Type, BookCern, Author, Translator, 
                BookPlace, BookPrice, MoneyType, PageNum, Depart, Tel, Mobile, ReaderName, ReaderNameCode, ReadType, 
                BookRent, BookExceedFund, BookRenewNum
FROM      S_BookBorrow
---                
select a.code, a.name, a.BorrowDate, a.rcode, a.ReaderName
from S_BookBorrow a, (
select code,	 max(BorrowDate) as lastBorrowDate
FROM      S_BookBorrow
group by code) b
where a.code = b.code 
  and a.BorrowDate = b.lastBorrowDate


SELECT m.BookCode, m.Name, m.NameCode, m.BookPlace, m.BookPrice, m.Barcode, m.RegDate, m.Number, m.RestNumber,
			  n.BorrowDate, n.ReaderName
FROM (SELECT BookCode, Name, NameCode, BookPlace, BookPrice, Barcode, RegDate, Number, RestNumber
  FROM T_Book
  where Barcode is not null) m
  LEFT JOIN (select a.code, a.name, a.BorrowDate, a.rcode, a.ReaderName
from S_BookBorrow a, (
select code,	 max(BorrowDate) as lastBorrowDate
FROM      S_BookBorrow
group by code) b
where a.code = b.code 
  and a.BorrowDate = b.lastBorrowDate) n
 ON m.BookCode = n.code
 
 ----
 SELECT   m.BookCode, m.Name, m.NameCode, m.BookPlace, m.BookPrice, m.BarCode, m.RegDate, m.[Number], m.RestNumber, 
                n.BorrowDate, n.ReaderName, n.factReturnDate, n.rtReaderName, n.jccs
FROM      ((SELECT   BookCode, Name, NameCode, BookPlace, BookPrice, BarCode, RegDate, [Number], RestNumber
                  FROM      T_Book
                  WHERE   (BarCode IS NOT NULL)) m LEFT OUTER JOIN
                     --最后借书人
                    (	select i.Code, i.Name, i.BorrowDate, i.RCode, i.ReaderName,  i.jccs, j.factReturnDate, j.rtRcode, j.rtReaderName
										from ( SELECT   a.Code, a.Name, a.BorrowDate, a.RCode, a.ReaderName, b.jccs
										                     FROM      (S_BookBorrow a INNER JOIN
										                                         (SELECT   Code, COUNT(Code) AS jccs, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate
										                                          FROM      S_BookBorrow
										                                          where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%' )
										                                          GROUP BY Code) b ON a.Code = b.Code AND a.BorrowDate = b.lastBorrowDate)
										) i left join (
										--最后还书人                                       
										SELECT   a.Code, a.Name, a.factReturnDate, a.RCode as rtRcode, a.ReaderName as rtReaderName
										                     FROM      (S_BookBorrow a INNER JOIN
										                                         (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate
										                                          FROM      S_BookBorrow
										                                          where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%' )
										                                          GROUP BY Code) b ON a.Code = b.Code AND a.factReturnDate = b.lastReturnDate)
										) j	on i.code = j.code     ) n ON 
                m.BookCode = n.Code)
                

--最后借书人
select i.Code, i.Name, i.BorrowDate, i.RCode, i.ReaderName, 
       j.factReturnDate, j.rtRcode, j.rtReaderName
from (
SELECT   a.Code, a.Name, a.BorrowDate, a.RCode, a.ReaderName
                     FROM      (S_BookBorrow a INNER JOIN
                                         (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, 
                                         					max(factReturnDate) AS lastReturnDate
                                          FROM      S_BookBorrow
                                          where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%' )
                                          GROUP BY Code) b ON a.Code = b.Code AND a.BorrowDate = b.lastBorrowDate)
) i left join 
(
--最后还书人                                       
SELECT   a.Code, a.Name, a.factReturnDate, a.RCode as rtRcode, a.ReaderName as rtReaderName
                     FROM      (S_BookBorrow a INNER JOIN
                                         (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, 
                                         					max(factReturnDate) AS lastReturnDate
                                          FROM      S_BookBorrow
                                          where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%')
                                          GROUP BY Code) b ON a.Code = b.Code AND a.factReturnDate = b.lastReturnDate)
) j
on i.code = j.code                                          




  if(!"".Equals(keyword))
            {
                sql += string.Format(" where (Name like '%{0}%' or NameCode like '%{0}%' or BarCode like '%{0}%')", keyword);
            }
            
SELECT   m.BookCode, m.Name, m.NameCode, m.BookPlace, m.BookPrice, m.BarCode, m.RegDate, m.Number, m.RestNumber,   n.BorrowDate, n.ReaderName, n.factReturnDate, n.rtReaderName  FROM      ((SELECT   BookCode, Name, NameCode, BookPlace, BookPrice, BarCode, RegDate, Number, RestNumber  FROM      T_Book  where (Barcode is not null) ) m LEFT OUTER JOIN  (	select i.Code, i.Name, i.BorrowDate, i.RCode, i.ReaderName,  j.factReturnDate, j.rtRcode, j.rtReaderName  from ( SELECT   a.Code, a.Name, a.BorrowDate, a.RCode, a.ReaderName  FROM      (S_BookBorrow a INNER JOIN   (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate   FROM      S_BookBorrow  where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%')   GROUP BY Code) b ON a.Code = b.Code AND a.BorrowDate = b.lastBorrowDate)   ) i left join (   SELECT   a.Code, a.Name, a.factReturnDate, a.RCode as rtRcode, a.ReaderName as rtReaderName    FROM      (S_BookBorrow a INNER JOIN  where (Name like '%a%' or NameCode like '%a%' or BarCode like '%a%')   (SELECT   Code, MAX(BorrowDate) AS lastBorrowDate, max(factReturnDate) AS lastReturnDate    FROM      S_BookBorrow    GROUP BY Code) b ON a.Code = b.Code AND a.factReturnDate = b.lastReturnDate)    ) j	on i.code = j.code     ) n ON     m.BookCode = n.Code) order by m.RegDate desc            


---2019.11.11 根据图书名称查询：借阅该书的历史记录
	
SELECT BookBorrowID, BookCode, Name, '' as  BarCode,  RCode, ReaderName, Tel, Mobile, 
			 BorrowDate, ReturnDate,  FactReturnDate, ExceedDay
  FROM S_BookBorrow
 where BookCode='TS-00004937'